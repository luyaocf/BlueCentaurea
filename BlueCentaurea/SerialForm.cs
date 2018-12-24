using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueCentaurea
{
    public partial class SerialForm : Form
    {
        private long sendFrames = 0;        // 发送帧数
        private long sendBytes = 0;         // 发送字节数
        private long recvFrames = 0;        // 接收帧数 
        private long recvBytes = 0;         // 接收字节数

        private SerialPort serialPort;      // 串口

        public SerialForm()
        {
            InitializeComponent();

            // 初始化串口
            serialPort = new SerialPort();
            // 数据接收事件绑定
            serialPort.DataReceived += new SerialDataReceivedEventHandler(ComDataReceived);
        }

        private Boolean OpenComm()
        {
            // 端口
            serialPort.PortName = combBPortName.Text;
            // 波特率
            serialPort.BaudRate = int.Parse(combBBaudRate.Text);
            // 数据位
            serialPort.DataBits = int.Parse(combBDataBits.Text);
            // 校验位
            switch (combBParity.Text)
            {
                case "无":
                    serialPort.Parity = System.IO.Ports.Parity.None;
                    break;
                case "奇校验":
                    serialPort.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case "偶校验":
                    serialPort.Parity = System.IO.Ports.Parity.Even;
                    break;
            }
            // 停止位
            switch (combBStopBits.Text)
            {
                case "1":
                    serialPort.StopBits = System.IO.Ports.StopBits.One;
                    break;
                case "1.5":
                    serialPort.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    break;
                case "2":
                    serialPort.StopBits = System.IO.Ports.StopBits.Two;
                    break;
                default:
                    serialPort.StopBits = System.IO.Ports.StopBits.None;
                    break;
            }
            // 读写超时时间
            serialPort.ReadTimeout = 100;
            serialPort.WriteTimeout = -1;

            try
            {
                // 打开串口
                serialPort.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnOpenCloseSerial_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                if (this.OpenComm())
                {
                    // 打开串口
                    Image image = BlueCentaurea.Properties.Resources.LightOn;
                    this.lblSerialStatus.Image = image.Clone() as Image;
                    image.Dispose();
                    btnOpenCloseSerial.Text = "关闭串口";
                }
            }
            else
            {
                try
                {
                    Image image = BlueCentaurea.Properties.Resources.LightOff1;
                    this.lblSerialStatus.Image = image.Clone() as Image;
                    image.Dispose();
                    btnOpenCloseSerial.Text = "打开串口";
                    // 关闭串口
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**************************【数据发送和接收】************************************************/
        /** 发送数据 */
        public bool SendData(byte[] data)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write(data, 0, data.Length);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("请先打开串口！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        /** 数据接收事件执行方法 */
        private void ComDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] readBuffer = new byte[serialPort.BytesToRead];
            serialPort.Read(readBuffer, 0, readBuffer.Length);

            this.recvFrames++;
            this.recvBytes += serialPort.BytesToRead;

            this.ShowReadData(readBuffer);
        }

        /** 显示数据 */
        private void ShowReadData(byte[] data)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                LightOn(lblRecvStatus);
                RecvRegionShow(MyTools.BytesToHexString(data), true);
                SetDataNum();
                LightOff(lblRecvStatus);
            }));
        }

        /**************************【数据发送和接收】************************************************/



        /******************【发送区1】操作************************************************************/
        /** 发送指示灯1亮 */
        private void btnManualSend1_MouseDown(object sender, MouseEventArgs e)
        {
            LightOn(this.lblSendStatus);
        }


        /** 发送指示灯1灭 */
        private void btnManualSend1_MouseUp(object sender, MouseEventArgs e)
        {
            LightOff(this.lblSendStatus);
        }


        /** 发送区1发送 */
        private void btnManualSend1_Click(object sender, EventArgs e)
        {
            if (this.textSendRegionHex01.Checked)
            {
                this.SendData(MyTools.HexStringToBytes(this.textSendRegion1.Text.Replace(" ", "")));
            }
            else
            {
                this.SendData(System.Text.Encoding.Default.GetBytes(this.textSendRegion1.Text.Replace(" ", "")));
            }

            this.sendFrames++;
            this.sendBytes += textSendRegion1.Text.Replace(" ", "").Length / 2;
            SetDataNum();
            RecvRegionShow(textSendRegion1.Text, false);// 滚动到控件光标处
        }

        private void RecvRegionShow(String data, bool isRecv)
        {
            // 判断是否自动清除接收区
            if (chkbAutoClear.Checked)
            {
                if (textRecvRegion.Lines.Length > 13)
                {
                    this.textRecvRegion.Text = "";
                }
            }

            if(isRecv)
            {
                string now = DateTime.Now.ToString();
                this.textRecvRegion.SelectionColor = Color.Green;
                this.textRecvRegion.AppendText(now.Substring(now.Length - 8) + "【接收】");
                this.textRecvRegion.SelectionColor = Color.Red;
                this.textRecvRegion.AppendText(data + "\r\n");
            }
            else
            {
                // 判断是否显示发送
                if (chkbShowTime.Checked)
                {
                    string now = DateTime.Now.ToString();
                    this.textRecvRegion.SelectionColor = Color.Blue;
                    this.textRecvRegion.AppendText(now.Substring(now.Length - 8) + "【发送】");
                    this.textRecvRegion.SelectionColor = Color.Black;
                    this.textRecvRegion.AppendText(data + "\r\n");
                }
            }

            this.textRecvRegion.Focus();                                    // 让文本框获取焦点
            this.textRecvRegion.Select(this.textRecvRegion.TextLength, 0);  // 设置光标的位置到末尾
            this.textRecvRegion.ScrollToCaret();
        }

        /** 发送区1清空 */
        private void btnSendRegionClear1_Click(object sender, EventArgs e)
        {
            textSendRegion1.Text = string.Empty;
        }
        /******************【发送区1】操作************************************************************/



        private void lblSendBytes_TextChanged(object sender, EventArgs e)
        {
            if (this.sendBytes >= 999999)
            {
                MessageBox.Show("发送数据太多，空间不足！", "消息提示框");
            }
        }


        private void btnSendRegionClear2_Click(object sender, EventArgs e)
        {
            textSendRegion2.Text = string.Empty;
        }

        private void btnSendRegionClear3_Click(object sender, EventArgs e)
        {
            textSendRegion3.Text = string.Empty;
        }

        private void btnClearCount_Click(object sender, EventArgs e)
        {
            this.sendFrames = 0;
            this.sendBytes = 0;
            this.recvFrames = 0;
            this.recvBytes = 0;
            SetDataNum();
        }

        /***********自定义方法区********************************************************************/

        private void SetDataNum()
        {
            lblSendFrames.Text = "【" + String.Format("{0, 6}", this.sendFrames) + "   帧】";       // 补空格
            lblSendBytes.Text = "【" + String.Format("{0, 6}", this.sendBytes) + " 字节】";
            lblRecvFrames.Text = "【" + String.Format("{0, 6}", this.recvFrames) + "   帧】";
            lblRecvBytes.Text = "【" + String.Format("{0, 6}", this.recvBytes) + " 字节】";
        }

        private void LightOn(Label label)
        {
            Image image = BlueCentaurea.Properties.Resources.DataRSStatusOn1;
            label.Image = image.Clone() as Image;
            image.Dispose();
        }

        private void LightOff(Label label)
        {
            Image image = BlueCentaurea.Properties.Resources.DataRSStatusOff1;
            label.Image = image.Clone() as Image;
            image.Dispose();
        }

        private void SerialForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                try
                {
                    this.Close();
                    this.serialPort.Close();
                    return;
                }
                catch
                {

                }
            }
        }




    }




}
