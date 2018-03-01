using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace BlueCentaurea
{
    public partial class NetworkForm : Form
    {
        Thread threadWatch = null;  // 负责监听客户端连接请求的 线程；
        Socket socketWatch = null;
        Dictionary<string, Socket> dict = new Dictionary<string, Socket>();         // 存放套接字
        Dictionary<string, Thread> dictThread = new Dictionary<string, Thread>();   // 存放线程

        private int netConnectStatusIndex = 1;  // 网络连接标志
        private String ip = "";                 // 本机IP地址

        public NetworkForm()
        {
            IPAddress[] IP = Dns.GetHostAddresses(Dns.GetHostName());
            ip = IP[IP.Length - 1].ToString();  // 获取IP地址
            InitializeComponent();              // 容器初始化
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;   // 问题：线程间操作无效：从不是创建控件“textBox1”的线程访问它
        }

        /******radioButton选择改变*************************************************************************/

        private void raBtnUDP_CheckedChanged(object sender, EventArgs e)
        {
            lblMultiFunc.Text = "本地主机端口";
            textLocalhost.Text = this.ip;
        }

        private void rabtnClient_CheckedChanged(object sender, EventArgs e)
        {
            lblMultiFunc.Text = "远程主机地址";
            textLocalhost.Text = this.ip;

        }

        private void rabtnServer_CheckedChanged(object sender, EventArgs e)
        {
            lblMultiFunc.Text = "本地主机端口";
            textLocalhost.Text = this.ip;
        }


        /******有键按下*************************************************************************/
        private void NetworkForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }

        /******单击*************************************************************************/
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // textLocalhost.Enabled = !textLocalhost.Enabled;
            // textMultiFunc.Enabled = !textMultiFunc.Enabled;
            bool flag = NetworkForm_HostChecked();  // 主机地址检查
            if (flag == true)
            {
                NetworkForm_ChangeBtnConntec();     // 修改连接按扭状态
                NetworkForm_ServerOpen();
            }

        }

        private void NetworkForm_ServerOpen()
        {
            #region 属性设置
            // btnConnect.Enabled = false;
            // textLocalhost.Enabled = false;
            // textMultiFunc.Enabled = false;
            // textRecvRegion.Enabled = false;
            #endregion
            // 创建负责监听的套接字，注意其中的参数
            this.socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // 获得文本框中的IP对象
            IPAddress address = IPAddress.Parse(textLocalhost.Text.Trim());
            // 创建包含IP和端口号的网络节点对象
            IPEndPoint endPoint = new IPEndPoint(address, int.Parse(textMultiFunc.Text.Trim()));
            try
            {
                // 将负责监听的套接字绑定到唯一的IP和端口上
                socketWatch.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                socketWatch.Bind(endPoint);
            }
            catch(SocketException se)
            {
                MessageBox.Show("异常："+se.Message);
                return;
            }

            // 设置监听队列的长度
            socketWatch.Listen(10000);
            // 创建负责监听的线程
            threadWatch = new Thread(WatchConnecting);
            threadWatch.IsBackground = true;
            threadWatch.Start();
            ShowMsg("服务器启动监听成功");
        }

        private void WatchConnecting()
        {
            ShowMsg("新客户端连接成功！");
            while (true)
            {
                // 开始监听客户端连接请求，Accept()方法会阻断当前的线程
                Socket sokConnection = socketWatch.Accept();
                var ssss = sokConnection.RemoteEndPoint.ToString().Split(':');
                if (listBoxOnline.FindString(ssss[0]) >= 0)
                {
                    listBoxOnline.Items.Remove(sokConnection.RemoteEndPoint.ToString());
                }
                else
                {
                    listBoxOnline.Items.Add(sokConnection.RemoteEndPoint.ToString());
                }
                dict.Add(sokConnection.RemoteEndPoint.ToString(), sokConnection);
                Thread thread = new Thread(RecMsg);
                thread.IsBackground = true;
                thread.Start(sokConnection);
                dictThread.Add(sokConnection.RemoteEndPoint.ToString(), thread);
            }
        }

        private void RecMsg(object sokConnectionparn)
        {
            Socket sokClient = sokConnectionparn as Socket;
            while (true)
            {
                // 定义一个缓存区
                byte[] arrMsgRec = new byte[1024];
                byte[] tmp;
                // 将接收到的数据保存
                int length = -1;
                try
                {
                    length = sokClient.Receive(arrMsgRec);
                    if (length > 0)
                    {
                        tmp = new byte[length];
                        Array.Copy(arrMsgRec, tmp, length);
                        ShowMsg(MyTools.BytesToHexString(tmp));
                        sokClient.Send(Encoding.GetEncoding("GBK").GetBytes(textSendRegion.Text));
                    } else
                    {
                        // 从 通信套接字 集合中删除被中断连接的通信套接字;
                        dict.Remove(sokClient.RemoteEndPoint.ToString());
                        // 从通信线程集合中删除被中断连接的通信线程对象;
                        dictThread.Remove(sokClient.RemoteEndPoint.ToString());
                        // 从列表中移除被中断的连接IP
                        listBoxOnline.Items.Remove(sokClient.RemoteEndPoint.ToString());
                        ShowMsg("" + sokClient.RemoteEndPoint.ToString() + "断开连接\r\n");
                        
                        break;
                    }
                }
                catch (SocketException se)
                {
                    // 从通信套接字集合中删除被中断连接的通信套接字;
                    dict.Remove(sokClient.RemoteEndPoint.ToString());
                    // 从通信线程集合中删除被中断连接的通信线程对象;
                    dictThread.Remove(sokClient.RemoteEndPoint.ToString());
                    // 从列表中移除被中断的连接IP
                    listBoxOnline.Items.Remove(sokClient.RemoteEndPoint.ToString());
                    ShowMsg("" + sokClient.RemoteEndPoint.ToString() + "断开,异常消息：" + se.Message + "\r\n");
                    
                    break;
                }
                catch(Exception e)
                {
                    // 从 通信套接字 集合中删除被中断连接的通信套接字;
                    dict.Remove(sokClient.RemoteEndPoint.ToString());
                    // 从通信线程集合中删除被中断连接的通信线程对象;
                    dictThread.Remove(sokClient.RemoteEndPoint.ToString());
                    // 从列表中移除被中断的连接IP
                    listBoxOnline.Items.Remove(sokClient.RemoteEndPoint.ToString());
                    ShowMsg("异常消息：" + e.Message + "\r\n");

                    break;
                }
            }
        }

        private void ShowMsg(String str)
        {
            if (!ChangeByte(textRecvRegion.Text, 20000))
            {
                textRecvRegion.Text = "";
                string now = DateTime.Now.ToString();
                textRecvRegion.AppendText("【" + now.Substring(now.Length - 8) + "】" + str + "\r\n");
            }
            else
            {
                string now = DateTime.Now.ToString();
                textRecvRegion.AppendText("【" + now.Substring(now.Length - 8) + "】" + str + "\r\n");
            }
        }

        private bool ChangeByte(string str, int i)
        {
            byte[] b = Encoding.Default.GetBytes(str);
            int m = b.Length;
            if (m < i)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool NetworkForm_HostChecked()
        {
            if (raBtnUDP.Checked)
            {

            }
            else if (rabtnClient.Checked)
            {
                    
            }
            else if (rabtnServer.Checked)
            {
                if (!Regex.IsMatch(textLocalhost.Text, @"([0-9]{1,3}\.){3}[0-9]{1,3}"))
                {
                    MessageBox.Show("本机地址格式错误！", "错误");
                    return false;
                } else if (!Regex.IsMatch(textMultiFunc.Text, @"[0-9]{1,5}"))
                {
                    MessageBox.Show("端口号格式有误！", "错误");
                    return false;
                }
                else
                {
                    return true;    
                }
            }
            else
            {

            }

            return false;
        }

        private void NetworkForm_ChangeBtnConntec()
        {
            switch (netConnectStatusIndex)
            {
                case 0:
                    {
                        netConnectStatusIndex = 1;
                        Image image = BlueCentaurea.Properties.Resources.LightOff1;
                        this.lblConnectStatus.Image = image.Clone() as Image;
                        image.Dispose();
                        btnConnect.Text = "连接";
                        break;
                    }
                case 1:
                    {
                        netConnectStatusIndex = 0;
                        Image image = BlueCentaurea.Properties.Resources.LightOn;
                        this.lblConnectStatus.Image = image.Clone() as Image;
                        image.Dispose();
                        btnConnect.Text = "断开";
                        break;
                    }
                default:
                    netConnectStatusIndex = 0;
                    break;
            }
        }

        private void btnSendClr_Click(object sender, EventArgs e)
        {
            textSendRegion.Text = String.Empty;
        }

        private void btnRecvClr_Click(object sender, EventArgs e)
        {
            textRecvRegion.Text = String.Empty;
        }


    }
}
