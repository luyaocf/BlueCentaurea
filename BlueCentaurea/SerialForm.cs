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
        private int serialStatusIndex = 0;  // 串口状态标志位
        private long sendFrames = 0;        // 发送帧数
        private long sendBytes = 0;         // 发送字节数
        private long recvFrames = 0;        // 接收帧数 
        private long recvBytes = 0;         // 接收字节数

        public SerialForm()
        {
            InitializeComponent();
        }

        private void RegisterComm()
        {
            Comm comm = new Comm();
            comm.serialPort.PortName = combBPortName.Text;
            comm.serialPort.BaudRate = int.Parse(combBBaudRate.Text);
            comm.serialPort.DataBits = int.Parse(combBDataBits.Text);

            switch (combBStopBits.Text)
            {
                case "1":
                    comm.serialPort.StopBits = System.IO.Ports.StopBits.One;
                    break;
                case "1.5":
                    comm.serialPort.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    break;
                case "2":
                    comm.serialPort.StopBits = System.IO.Ports.StopBits.Two;
                    break;
                default:
                    comm.serialPort.StopBits = System.IO.Ports.StopBits.None;
                    break;
            }
            switch (combBParity.Text)
            {
                case "无":
                    comm.serialPort.Parity = System.IO.Ports.Parity.None;
                    break;
                case "奇校验":
                    comm.serialPort.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case "偶校验":
                    comm.serialPort.Parity = System.IO.Ports.Parity.Even;
                    break;
            }

            comm.serialPort.ReadTimeout = 100;
            comm.serialPort.WriteTimeout = -1;

            comm.Open();
            if (comm.IsOpen())
            {
                textRecvRegion.AppendText(comm.serialPort.PortName + "\r\n");
                textRecvRegion.AppendText(comm.serialPort.BaudRate + "\r\n");
                textRecvRegion.AppendText(comm.serialPort.DataBits + "\r\n");
                textRecvRegion.AppendText(comm.serialPort.StopBits + "\r\n");
                textRecvRegion.AppendText(comm.serialPort.Parity + "\r\n");

                // comm.DataReceived += new Comm.EventHandle(comm_DataReceived);
                textSendRegion1.Text = textSendRegion1.Text.Replace(" ", "");
                byte[] bytes = MyTools.HexStringToBytes(textSendRegion1.Text);
                comm.WritePort(bytes, 0, bytes.Length);
                comm.DataReceived += new Comm.EventHandle(comm_DataReceived);
            }
            else
            {
                MessageBox.Show("串口打开失败！", "消息提示框");
            }
            
        }
        private void comm_DataReceived(byte[] readBuff)
        {
            textRecvRegion.Text = readBuff.Length.ToString();
            textRecvRegion.AppendText(MyTools.BytesToHexString(readBuff));
        }
        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            if (serialStatusIndex % 2 == 0)
            {
                // Image image = Image.FromFile(@"C:\Users\jason\Desktop\vs2015\BlueCentaurea\pictures\LightOn.png");
                Image image = BlueCentaurea.Properties.Resources.LightOn;
                this.lblSerialStatus.Image = image.Clone() as Image;
                image.Dispose();
                btnOpenSerial.Text = "关闭串口";
            }
            else if (serialStatusIndex % 2 == 1)
            {
                Image image = BlueCentaurea.Properties.Resources.LightOff1;
                this.lblSerialStatus.Image = image.Clone() as Image;
                image.Dispose();
                btnOpenSerial.Text = "打开串口";
            }
            serialStatusIndex++;

            this.RegisterComm();
        }

        private void btnManualSend1_MouseDown(object sender, MouseEventArgs e)
        {
            Image image = BlueCentaurea.Properties.Resources.DataRSStatusOn1;
            this.lblSendStatus.Image = image.Clone() as Image;
            image.Dispose();
        }

        private void btnManualSend1_MouseUp(object sender, MouseEventArgs e)
        {
            Image image = BlueCentaurea.Properties.Resources.DataRSStatusOff1;
            this.lblSendStatus.Image = image.Clone() as Image;
            image.Dispose();
        }

        private void btnManualSend1_Click(object sender, EventArgs e)
        {
            this.sendFrames++;
            this.sendBytes += textSendRegion1.Text.Replace(" ", "").Length / 2;
            SetDataNum();

            if (chkbAutoClear.Checked)  // 判断是否自动清除接收区
            {
                if (textRecvRegion.Lines.Length > 13)
                {
                    this.textRecvRegion.Text = "";
                }
            }
            if (chkbShowSend.Checked)
            {
                if (chkbShowTime.Checked)
                {
                    string now = DateTime.Now.ToString();
                    this.textRecvRegion.SelectionColor = Color.Blue;
                    this.textRecvRegion.AppendText(now.Substring(now.Length - 8) + "【发送】");
                    this.textRecvRegion.SelectionColor = Color.Black;
                    this.textRecvRegion.AppendText(textSendRegion1.Text + "\r\n");
                }
                else
                {
                    this.textRecvRegion.Text += "【发送】" + textSendRegion1.Text + "\r\n";
                }

            }

            this.textRecvRegion.Focus();                                    // 让文本框获取焦点
            this.textRecvRegion.Select(this.textRecvRegion.TextLength, 0);  // 设置光标的位置到末尾
            this.textRecvRegion.ScrollToCaret();                            // 滚动到控件光标处
        }

        private void lblSendBytes_TextChanged(object sender, EventArgs e)
        {
            if (this.sendBytes >= 999999)
            {
                MessageBox.Show("发送数据太多，空间不足！", "消息提示框");
            }
        }

        private void btnSendRegionClear1_Click(object sender, EventArgs e)
        {
            textSendRegion1.Text = string.Empty;
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
    }

    public class Comm
    {
        public delegate void EventHandle(byte[] readBuffer);
        public event EventHandle DataReceived;
        public SerialPort serialPort;
        Thread thread;
        volatile bool _keepReading;

        public Comm()
        {
            serialPort = new SerialPort();
            thread = null;
            _keepReading = false;
        }

        public bool IsOpen()
        {
            return serialPort.IsOpen;
        }
        private void StartReading()
        {
            if (!_keepReading)
            {
                _keepReading = true;
                thread = new Thread(new ThreadStart(ReadPort));
                thread.Start();
            }
        }
        private void StopReading()
        {
            if (_keepReading)
            {
                _keepReading = false;
                thread.Join();
                thread = null;
            }
        }
        private void ReadPort()
        {
            while (_keepReading)
            {
                if (serialPort.IsOpen)
                {
                    int count = serialPort.BytesToRead;
                    if (count > 0)
                    {
                        byte[] readBuffer = new byte[count];
                        try
                        {
                            Application.DoEvents();
                            serialPort.Read(readBuffer, 0, count);
                            DataReceived?.Invoke(readBuffer);
                            Thread.Sleep(100);
                        }
                        catch (TimeoutException)
                        {
                            MessageBox.Show("超时", "消息提示框");
                        }
                    }
                }
            }
        }

        public void Open()
        {
            Close();
            serialPort.Open();
            if (serialPort.IsOpen)
            {
                StartReading();
            }
            else
            {
                MessageBox.Show("串口打开失败！");
            }
        }

        public void Close()
        {
            StopReading();
            serialPort.Close();
        }

        public void WritePort(byte[] send, int offSet, int count)
        {
            if (this.IsOpen())
            {
                serialPort.Write(send, offSet, count);
            }
        }
    }
}
