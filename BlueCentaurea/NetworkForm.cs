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
        public static NetworkForm network;
        public static MyUDP myUDP = null;
        public static MyClient myClient = null;
        public static MyServer myServer = null;
        private static int ProtocolFlag = -1;
        private int netConnectStatusIndex = 1;  // 网络连接标志
        
        public NetworkForm()
        {
            InitializeComponent();              // 容器初始化
            network = this;
            NetworkForm_SetLocalHost();         // 设置获取到的本机IP
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;   // 问题：线程间操作无效：从不是创建控件“textBox1”的线程访问它
        }
        private void NetworkForm_SetLocalHost()
        {
            IPAddress[] IP = Dns.GetHostAddresses(Dns.GetHostName());
            Dictionary<int, string> kvDictonary = new Dictionary<int, string>();
            int j = 0;
            kvDictonary.Add(j++, "127.0.0.1");
            for (int i=0; i < IP.Length; i++)
            {
                if (Regex.IsMatch(IP[i].ToString(), @"^(\d{1,3}\.){3}\d{1,3}$"))
                {
                    kvDictonary.Add(j++, IP[i].ToString());
                }
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = kvDictonary;
            this.combBLocalhost.DataSource = bs;
            this.combBLocalhost.ValueMember = "Key";
            this.combBLocalhost.DisplayMember = "Value";
        }

        /******radioButton选择改变*************************************************************************/

        private void raBtnUDP_CheckedChanged(object sender, EventArgs e)
        {
            lblMultiFunc.Text = "本地主机端口";
        }

        private void rabtnClient_CheckedChanged(object sender, EventArgs e)
        {
            lblMultiFunc.Text = "远程主机地址";
        }

        private void rabtnServer_CheckedChanged(object sender, EventArgs e)
        {
            lblMultiFunc.Text = "本地主机端口";
        }


        /******有键按下*************************************************************************/
        private void NetworkForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                if ("断开".Equals(btnConnect.Text))
                {
                    switch (ProtocolFlag)
                    {
                        case 0:
                            myUDP.NetworkForm_UDPClose();          // UDP关闭
                            break;
                        case 1:
                            myClient.NetworkForm_ClientClose();       // 客户端关闭
                            break;
                        case 2:
                            myServer.NetworkForm_ServerClose();       // 服务器关闭
                            break;
                    }
                }
                this.Close();
                return;
            }
        }   



        private bool NetworkForm_HostChecked()
        {
            if (raBtnUDP.Checked)
            {
                if (!Regex.IsMatch(textMultiFunc.Text, @"^\d{1,5}$"))
                {
                    MessageBox.Show("【端口号】格式有误！", "错误");
                    return false;
                }
                else
                {
                    ProtocolFlag = 0;
                    return true;
                }
            }
            else if (rabtnClient.Checked)
            {
                if (!Regex.IsMatch(textMultiFunc.Text, @"^(\d{1,3}\.){3}\d{1,3}\:\d{1,5}$"))
                {
                    MessageBox.Show("【远程主机地址】格式有误！", "错误");
                    return false;
                }
                else
                {
                    ProtocolFlag = 1;
                    return true;
                }
            }
            else if (rabtnServer.Checked)
            {
                if (!Regex.IsMatch(textMultiFunc.Text, @"^\d{1,5}$"))
                {
                    MessageBox.Show("【端口号】格式有误！", "错误");
                    return false;
                }
                else
                {
                    ProtocolFlag = 2;
                    return true;    
                }
            }
            else
            { }

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
                        btnConnect.ForeColor = Color.Black;
                        btnConnect.Text = "连接";
                        break;
                    }
                case 1:
                    {
                        netConnectStatusIndex = 0;
                        Image image = BlueCentaurea.Properties.Resources.LightOn;
                        this.lblConnectStatus.Image = image.Clone() as Image;
                        image.Dispose();
                        btnConnect.ForeColor = Color.Red;
                        btnConnect.Text = "断开";
                        break;
                    }
                default:
                    netConnectStatusIndex = 0;
                    break;
            }
        }

        /******单击*************************************************************************/
        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool flag = NetworkForm_HostChecked();  // 主机地址检查
            if (flag == true)
            {
                this.textMultiFunc.Enabled = !this.textMultiFunc.Enabled;
                this.raBtnUDP.Enabled = !this.raBtnUDP.Enabled;
                this.rabtnClient.Enabled = !this.rabtnClient.Enabled;
                this.rabtnServer.Enabled = !this.rabtnServer.Enabled;
                this.combBLocalhost.Enabled = !this.combBLocalhost.Enabled;

                NetworkForm_ChangeBtnConntec();     // 修改连接按扭状态
                if (!"断开".Equals(btnConnect.Text))
                {
                    switch (ProtocolFlag)
                    {
                        case 0:
                            myUDP.NetworkForm_UDPClose();          // UDP关闭
                            break;
                        case 1:
                            myClient.NetworkForm_ClientClose();       // 客户端关闭
                            break;
                        case 2:
                            myServer.NetworkForm_ServerClose();       // 服务器关闭
                            break;
                    }
                }
                else
                {
                    switch (ProtocolFlag)
                    {
                        case 0:
                            myUDP = new MyUDP();
                            myUDP.NetworkForm_UDPOpen();          // UDP打开
                            break;
                        case 1:
                            myClient = new MyClient();
                            myClient.NetworkForm_ClientOpen();       // 客户端打开
                            break;
                        case 2:
                            myServer = new MyServer();
                            myServer.NetworkForm_ServerOpen();                            
                            break;
                    }
                }
            }
        }

        private void btnSendClr_Click(object sender, EventArgs e)
        {
            textSendRegion1.Text = String.Empty;
        }

        private void btnRecvClr_Click(object sender, EventArgs e)
        {
            textRecvRegion.Text = String.Empty;
        }

        private void btnSendRegion1_Click(object sender, EventArgs e)
        {
            this.textSendRegion1.Text = string.Empty;
        }

        private void btnSendRegion2_Click(object sender, EventArgs e)
        {
            this.textSendRegion2.Text = string.Empty;
        }

        private void btnSendRegion3_Click(object sender, EventArgs e)
        {
            this.textSendRegion3.Text = string.Empty;
        }

        private void NetworkForm_Load(object sender, EventArgs e)
        {
            this.richTextBoxTips.Text = "小心谨慎，虚心学习，专心做事不是为了感动别人，而是为了感动自己。";
            this.richTextBoxTips.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxRecvBytes.Text = "0";
            this.textBoxSendBytes.Text = "0";
        }

        private void NetworkForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ("断开".Equals(btnConnect.Text))
            {
                switch (ProtocolFlag)
                {
                    case 0:
                        myUDP.NetworkForm_UDPClose();          // UDP关闭
                        break;
                    case 1:
                        myClient.NetworkForm_ClientClose();       // 客户端关闭
                        break;
                    case 2:
                        myServer.NetworkForm_ServerClose();       // 服务器关闭
                        break;
                }
            }
        }

        /******公共方法*************************************************************************/
        public void ShowMsg(String str)
        {
            if (!ChangeByte(this.textRecvRegion.Text, 200000))
            {
                this.textRecvRegion.Text = "";
            }

            string now = DateTime.Now.ToString();
            this.textRecvRegion.SelectionColor = Color.Blue;
            this.textRecvRegion.AppendText("【" + now.Substring(now.Length - 8) + "】");
            this.textRecvRegion.SelectionColor = Color.Black;
            this.textRecvRegion.AppendText(str + "\r\n");
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

        private void btnSend1_Click(object sender, EventArgs e)
        {
            if (ProtocolFlag == 2 && myServer != null)
            {
                myServer.SendMsg(1);
            }
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            if (ProtocolFlag == 2 && myServer != null)
            {
                myServer.SendMsg(2);
            }
        }

        private void btnSend3_Click(object sender, EventArgs e)
        {
            if (ProtocolFlag == 2 && myServer != null)
            {
                myServer.SendMsg(3);
            }
        }

        private void btnSendLoop_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(MyServerSendMsg);
            thread.IsBackground = true;
            thread.Start();
        }

        private void MyServerSendMsg()
        {
            if (ProtocolFlag == 2)
            {
                if (myServer != null)
                {
                    this.btnSendLoop.ForeColor = Color.Red;
                    
                    // bool stopFlag = true;
                    string waitTime = this.textSendInterval.Text == string.Empty ? "0" : this.textSendInterval.Text;

                    // while (stopFlag)
                    {
                        if (this.checkBoxSend1.Checked && myServer != null)
                        {
                            myServer.SendMsg(1);
                        }
                        Thread.Sleep(int.Parse(waitTime));
                        if (this.checkBoxSend2.Checked && myServer != null)
                        {
                            myServer.SendMsg(2);
                        }
                        Thread.Sleep(int.Parse(this.textSendInterval.Text));
                        if (this.checkBoxSend3.Checked && myServer != null)
                        {
                            myServer.SendMsg(3);
                        }
                        Thread.Sleep(int.Parse(this.textSendInterval.Text));
                    }
                    this.btnSendLoop.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("服务器已关闭！", "消息提示框");
                }
            }
        }

        private void chboxDisplaySend_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.chboxDisplaySend.Checked)
            {
                this.radioBtnHEXSendYes.Enabled = false;
                this.radioBtnHEXSendNo.Enabled = false;
            }
            else
            {
                this.radioBtnHEXSendYes.Enabled = true;
                this.radioBtnHEXSendNo.Enabled = true;
            }
        }

        private void chkbHEX_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.chkbHEX.Checked)
            {
                this.radioButtonUtf8.Enabled = false;
                this.radioButtonBbk.Enabled = false;
            }
            else
            {
                this.radioButtonUtf8.Enabled = true;
                this.radioButtonBbk.Enabled = true;
            }
        }
    }



    public class MyUDP
    {
        public void NetworkForm_UDPClose()
        {
            ShowMsg("【UDP】关闭！");
        }

        public void NetworkForm_UDPOpen()
        {
            ShowMsg("【UDP】开始启动！");

        }
        private void ShowMsg(string msg)
        {
            NetworkForm.network.ShowMsg(msg);
        }
    }

    public class MyClient
    {
        public void NetworkForm_ClientOpen()
        {
            string[] tmp = Regex.Split(NetworkForm.network.textMultiFunc.Text, ":");
            IPAddress ip = IPAddress.Parse(tmp[0]);
            int port = int.Parse(tmp[1]);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(new IPEndPoint(ip, port));
                ShowMsg("【客户端】连接成功！");
            }
            catch
            {
                ShowMsg("【客户端】连接失败！");
            }
        }

        public void NetworkForm_ClientClose()
        {
            ShowMsg("【客户端】已关闭！");
        }

        private void ShowMsg(string msg)
        {
            NetworkForm.network.ShowMsg(msg);
        }
    }

    public class MyServer
    {
        private bool ServerFlag = true;
        Thread threadWatch = null;  // 负责监听客户端连接请求的 线程；
        Socket socketWatch = null;
        Dictionary<string, Socket> dictServerSocketConn = new Dictionary<string, Socket>();     // 存放套接字
        Dictionary<string, Thread> dictServerSocketThread = new Dictionary<string, Thread>();   // 存放线程

        public void NetworkForm_ServerClose()
        {
            ServerFlag = false;
            // 从 通信套接字 集合中删除被中断连接的通信套接字;
            foreach (var item in dictServerSocketConn)
            {
                try
                {
                    item.Value.Shutdown(SocketShutdown.Both);
                    item.Value.Close();
                }
                catch (Exception se)
                {
                    ShowMsg("【关闭】Socket异常！");
                }
            }
            dictServerSocketConn.Clear();

            // 从通信线程集合中删除被中断连接的通信线程对象;
            foreach (var item in dictServerSocketThread)
            {
                item.Value.Abort();
            }
            dictServerSocketThread.Clear();

            // 从列表中移除被中断的连接IP
            NetworkForm.network.listBoxOnline.Items.Clear();

            // 关闭服务器端Socket
            // this.socketWatch.Shutdown(SocketShutdown.Both);
            if (this.socketWatch != null)
            {
                this.socketWatch.Close();
            }
            ShowMsg("【服务器】已关闭！\r\n");
        }

        public void NetworkForm_ServerOpen()
        {
            this.ShowMsg("【服务器】开始启动！");

            string localhost = NetworkForm.network.combBLocalhost.Text;
            string port = NetworkForm.network.textMultiFunc.Text;
            // 创建负责监听的套接字，注意其中的参数
            this.socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // 获得文本框中的IP对象
            IPAddress address = IPAddress.Parse(localhost);
            // 创建包含IP和端口号的网络节点对象
            IPEndPoint endPoint = new IPEndPoint(address, int.Parse(port));
            try
            {
                // 将负责监听的套接字绑定到唯一的IP和端口上
                this.socketWatch.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                this.socketWatch.Bind(endPoint);
            }
            catch (SocketException se)
            {
                MessageBox.Show("异常：" + se.Message);
                return;
            }

            // 设置监听队列的长度
            socketWatch.Listen(10000);
            // 创建负责监听的线程
            // WatchConnecting();
            threadWatch = new Thread(WatchConnecting);
            ServerFlag = true;
            threadWatch.IsBackground = true;
            threadWatch.Start();
            ShowMsg("【服务器】启动监听成功！");
        }

        private void WatchConnecting()
        {
            while (ServerFlag)
            {
                // 开始监听客户端连接请求，Accept()方法会阻断当前的线程
                Socket sokConnection = null;
                try
                {
                    sokConnection = socketWatch.Accept();
                }
                catch (Exception e)
                {

                    break;
                }

                var ssss = sokConnection.RemoteEndPoint.ToString();
                if (NetworkForm.network.listBoxOnline.FindString(ssss) >= 0)
                {
                    NetworkForm.network.listBoxOnline.Items.Remove(sokConnection.RemoteEndPoint.ToString());
                }
                else
                {
                    NetworkForm.network.listBoxOnline.Items.Add(sokConnection.RemoteEndPoint.ToString());
                }
                dictServerSocketConn.Add(sokConnection.RemoteEndPoint.ToString(), sokConnection);
                Thread thread = new Thread(RecMsg);
                thread.IsBackground = true;
                thread.Start(sokConnection);
                dictServerSocketThread.Add(sokConnection.RemoteEndPoint.ToString(), thread);
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
                        NetworkForm.network.textBoxRecvBytes.Text = (int.Parse(NetworkForm.network.textBoxRecvBytes.Text) + length).ToString();
                        Array.Copy(arrMsgRec, tmp, length);
                        if (NetworkForm.network.chkbHEX.Checked)
                        {
                            ShowMsg("【" + sokClient.RemoteEndPoint.ToString() + "】" + MyTools.BytesToHexString(tmp, true).Trim());
                        }
                        else
                        {
                            if (NetworkForm.network.radioButtonUtf8.Checked)
                            {
                                ShowMsg("【" + sokClient.RemoteEndPoint.ToString() + "】" + Encoding.GetEncoding("UTF-8").GetString(tmp));
                            }
                            else
                            {
                                ShowMsg("【" + sokClient.RemoteEndPoint.ToString() + "】" + Encoding.GetEncoding("GBK").GetString(tmp));
                            }
                        }
                        //if (NetworkForm.network.textSendRegion1.Text != null && NetworkForm.network.textSendRegion1.Text != string.Empty && NetworkForm.network.checkBoxSend1.Checked)
                        //{
                        //    if (NetworkForm.network.textSendInterval.Text != string.Empty)
                        //    {
                        //        int sleep = int.Parse(NetworkForm.network.textSendInterval.Text);
                        //        Thread.Sleep(sleep);
                        //    }
                        //    byte[] bytes = Encoding.GetEncoding("GBK").GetBytes(NetworkForm.network.textSendRegion1.Text);
                        //    sokClient.Send(bytes);
                        //    NetworkForm.network.textBoxSendBytes.Text = (int.Parse(NetworkForm.network.textBoxSendBytes.Text) + bytes.Length).ToString();
                        //}
                        //if (NetworkForm.network.textSendRegion2.Text != null && NetworkForm.network.textSendRegion2.Text != string.Empty && NetworkForm.network.checkBoxSend2.Checked)
                        //{
                        //    if (NetworkForm.network.textSendInterval.Text != string.Empty)
                        //    {
                        //        int sleep = int.Parse(NetworkForm.network.textSendInterval.Text);
                        //        Thread.Sleep(sleep);
                        //    }
                        //    byte[] bytes = Encoding.GetEncoding("GBK").GetBytes(NetworkForm.network.textSendRegion2.Text);
                        //    sokClient.Send(bytes);
                        //    NetworkForm.network.textBoxSendBytes.Text = (int.Parse(NetworkForm.network.textBoxSendBytes.Text) + bytes.Length).ToString();
                        //}
                        //if (NetworkForm.network.textSendRegion3.Text != null && NetworkForm.network.textSendRegion3.Text != string.Empty && NetworkForm.network.checkBoxSend3.Checked)
                        //{
                        //    if (NetworkForm.network.textSendInterval.Text != string.Empty)
                        //    {
                        //        int sleep = int.Parse(NetworkForm.network.textSendInterval.Text);
                        //        Thread.Sleep(sleep);
                        //    }
                        //    byte[] bytes = Encoding.GetEncoding("GBK").GetBytes(NetworkForm.network.textSendRegion3.Text);
                        //    sokClient.Send(bytes);
                        //    NetworkForm.network.textBoxSendBytes.Text = (int.Parse(NetworkForm.network.textBoxSendBytes.Text) + bytes.Length).ToString();
                        //}
                    }
                    else
                    {
                        // 从 通信套接字 集合中删除被中断连接的通信套接字;
                        dictServerSocketConn.Remove(sokClient.RemoteEndPoint.ToString());
                        // 从通信线程集合中删除被中断连接的通信线程对象;
                        dictServerSocketThread.Remove(sokClient.RemoteEndPoint.ToString());
                        // 从列表中移除被中断的连接IP
                        NetworkForm.network.listBoxOnline.Items.Remove(sokClient.RemoteEndPoint.ToString());
                        ShowMsg("【" + sokClient.RemoteEndPoint.ToString() + "】" + "断开连接\r\n");

                        break;
                    }
                }
                catch (SocketException se)
                {
                    if (ServerFlag)
                    {
                        // 从通信套接字集合中删除被中断连接的通信套接字;
                        dictServerSocketConn.Remove(sokClient.RemoteEndPoint.ToString());
                        // 从通信线程集合中删除被中断连接的通信线程对象;
                        dictServerSocketThread.Remove(sokClient.RemoteEndPoint.ToString());
                        // 从列表中移除被中断的连接IP
                        NetworkForm.network.listBoxOnline.Items.Remove(sokClient.RemoteEndPoint.ToString());
                        ShowMsg("【异常消息】：" + se.Message + "\r\n");
                    }

                    break;
                }
                catch (Exception se)
                {
                    if (ServerFlag)
                    {
                        // 从 通信套接字 集合中删除被中断连接的通信套接字;
                        dictServerSocketConn.Remove(sokClient.RemoteEndPoint.ToString());
                        // 从通信线程集合中删除被中断连接的通信线程对象;
                        dictServerSocketThread.Remove(sokClient.RemoteEndPoint.ToString());
                        // 从列表中移除被中断的连接IP
                        NetworkForm.network.listBoxOnline.Items.Remove(sokClient.RemoteEndPoint.ToString());
                        ShowMsg("【异常消息】：" + se.Message + "\r\n");
                    }
                    break;
                }
            }
        }

        /**
         * 
         * */
        public void SendMsg(int flag)
        {
            switch (flag)
            {
                case 1:
                    // 发送区1
                    this.SendMsg(NetworkForm.network.textSendRegion1.Text);
                    break;
                case 2:
                    // 发送区2
                    this.SendMsg(NetworkForm.network.textSendRegion2.Text);
                    break;
                case 3:
                    // 发送区3
                    this.SendMsg(NetworkForm.network.textSendRegion3.Text);
                    break;

            }
        }
        
        public void SendMsg(string msg)
        {
            if (msg == string.Empty)
            {
                MessageBox.Show("发送区内容为空！", "警告");
            }
            else
            {
                if (NetworkForm.network.listBoxOnline.SelectedItems.Count == 0)
                {
                    // this.ShowMsg("【未选择客户端】则发送给所有的客户端！");
                    foreach (var item in NetworkForm.network.listBoxOnline.Items)
                    {
                        Socket client = null;
                        if (dictServerSocketConn.TryGetValue(item.ToString(), out client))
                        {
                            byte[] bytes = null;
                            if (NetworkForm.network.radioBtnSendGBK.Checked)
                            {
                                bytes = Encoding.GetEncoding("GBK").GetBytes(msg);
                                if (NetworkForm.network.chboxDisplaySend.Checked && NetworkForm.network.radioBtnHEXSendYes.Checked)
                                {
                                    this.ShowMsg("【发送到：" + item.ToString() + "】"+MyTools.BytesToHexString(bytes, true));
                                }
                                else if (NetworkForm.network.chboxDisplaySend.Checked && NetworkForm.network.radioBtnHEXSendNo.Checked)
                                {
                                    this.ShowMsg("【发送到：" + item.ToString() + "】" + msg);
                                }
                                else
                                { }
                            }
                            else
                            {
                                bytes = Encoding.GetEncoding("UTF-8").GetBytes(msg);
                                if (NetworkForm.network.chboxDisplaySend.Checked && NetworkForm.network.radioBtnHEXSendYes.Checked)
                                {
                                    this.ShowMsg("【发送到：" + item.ToString() + "】" + MyTools.BytesToHexString(bytes, true));
                                }
                                else if (NetworkForm.network.chboxDisplaySend.Checked && NetworkForm.network.radioBtnHEXSendNo.Checked)
                                {
                                    this.ShowMsg("【发送到：" + item.ToString() + "】" + msg);
                                }
                                else
                                { }
                            }
                            client.Send(bytes);
                            NetworkForm.network.textBoxSendBytes.Text = (int.Parse(NetworkForm.network.textBoxSendBytes.Text) + bytes.Length).ToString();
                        }
                    }
                }
                else
                {
                    foreach (var item in NetworkForm.network.listBoxOnline.SelectedItems)
                    {
                        Socket client = null;
                        if (dictServerSocketConn.TryGetValue(item.ToString(), out client))
                        {
                            byte[] bytes = null;
                            if (NetworkForm.network.radioBtnSendGBK.Checked)
                            {
                                bytes = Encoding.GetEncoding("GBK").GetBytes(msg);
                            }
                            else
                            {
                                bytes = Encoding.GetEncoding("UTF-8").GetBytes(msg);
                            }
                            client.Send(bytes);
                            NetworkForm.network.textBoxSendBytes.Text = (int.Parse(NetworkForm.network.textBoxSendBytes.Text) + bytes.Length).ToString();
                        }
                    }
                }
            }
        }
        private void ShowMsg(string msg)
        {
            NetworkForm.network.ShowMsg(msg);
        }

    }
}
