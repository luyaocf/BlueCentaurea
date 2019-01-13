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
using System.Text.RegularExpressions;

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

        /** 打开串口方法 */
        private Boolean OpenComm()
        {
            // 端口
            serialPort.PortName = combBPortName.Text.Split('(')[0];
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
        /** 打开串口事件触发 */
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
                    // 串口打开成功后，锁定串口参数配置
                    combBPortName.Enabled = false;
                    combBBaudRate.Enabled = false;
                    combBDataBits.Enabled = false;
                    combBParity.Enabled = false;
                    combBStopBits.Enabled = false;
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
                    combBPortName.Enabled = true;
                    combBBaudRate.Enabled = true;
                    combBDataBits.Enabled = true;
                    combBParity.Enabled = true;
                    combBStopBits.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**************************【数据发送和接收】【START】************************************************/
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
            LightOn(lblRecvStatus);

            // 延时30秒，防止拆包接收
            Thread.Sleep(30);

            byte[] readBuffer = new byte[serialPort.BytesToRead];
            serialPort.Read(readBuffer, 0, readBuffer.Length);

            // 接收帧数
            this.recvFrames++;
            // 接收字节数
            this.recvBytes += readBuffer.Length;

            // 显示到接收区
            this.ShowReadData(readBuffer);

            LightOff(lblRecvStatus);
        }
        /** 显示数据 */
        private void ShowReadData(byte[] data)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {

                RecvRegionShow(MyTools.BytesToHexString(data), true);
                DataCountShow();

            }));
        }

        /** 清空接收区 */
        private void btnClearRecvRegion_Click(object sender, EventArgs e)
        {
            this.textRecvRegion.Text = string.Empty;
        }

        /**************************【数据发送和接收】【END】************************************************/



        /******************【发送区1操作】【START】************************************************************/
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
                this.SendData(System.Text.Encoding.Default.GetBytes(this.textSendRegion1.Text));
            }

            this.sendFrames++;
            this.sendBytes += textSendRegion1.Text.Replace(" ", "").Length / 2;
            DataCountShow();
            // 滚动到控件光标处
            RecvRegionShow(textSendRegion1.Text, false);
        }
        /** 发送区1清空 */
        private void btnSendRegionClear1_Click(object sender, EventArgs e)
        {
            textSendRegion1.Text = string.Empty;
        }
        /******************【发送区1操作】【END】************************************************************/

        /******************【发送区2操作】【START】************************************************************/
        /** 发送指示灯1亮 */
        private void btnManualSend2_MouseDown(object sender, MouseEventArgs e)
        {
            LightOn(this.lblSendStatus);
        }
        /** 发送指示灯1灭 */
        private void btnManualSend2_MouseUp(object sender, MouseEventArgs e)
        {
            LightOff(this.lblSendStatus);
        }
        /** 发送区1发送 */
        private void btnManualSend2_Click(object sender, EventArgs e)
        {
            if (this.textSendRegionHex02.Checked)
            {
                this.SendData(MyTools.HexStringToBytes(this.textSendRegion2.Text.Replace(" ", "")));
            }
            else
            {
                this.SendData(System.Text.Encoding.Default.GetBytes(this.textSendRegion2.Text));
            }

            this.sendFrames++;
            this.sendBytes += textSendRegion2.Text.Replace(" ", "").Length / 2;
            DataCountShow();
            // 滚动到控件光标处
            RecvRegionShow(textSendRegion2.Text, false);
        }
        /** 发送区2清零 */
        private void btnSendRegionClear2_Click(object sender, EventArgs e)
        {
            textSendRegion2.Text = string.Empty;
        }
        /******************【发送区2操作】【END】************************************************************/



        /******************【发送区3操作】【START】************************************************************/
        /** 发送指示灯1亮 */
        private void btnManualSend3_MouseDown(object sender, MouseEventArgs e)
        {
            LightOn(this.lblSendStatus);
        }
        /** 发送指示灯1灭 */
        private void btnManualSend3_MouseUp(object sender, MouseEventArgs e)
        {
            LightOff(this.lblSendStatus);
        }
        /** 发送区1发送 */
        private void btnManualSend3_Click(object sender, EventArgs e)
        {
            if (this.textSendRegionHex03.Checked)
            {
                this.SendData(MyTools.HexStringToBytes(this.textSendRegion3.Text.Replace(" ", "")));
            }
            else
            {
                this.SendData(System.Text.Encoding.Default.GetBytes(this.textSendRegion3.Text));
            }

            this.sendFrames++;
            this.sendBytes += textSendRegion3.Text.Replace(" ", "").Length / 2;
            DataCountShow();
            // 滚动到控件光标处
            RecvRegionShow(textSendRegion3.Text, false);
        }
        /** 发送区3清零 */
        private void btnSendRegionClear3_Click(object sender, EventArgs e)
        {
            textSendRegion3.Text = string.Empty;
        }
        /******************【发送区3操作】【END】************************************************************/


        /** 判断发送字节数 */
        private void lblSendBytes_TextChanged(object sender, EventArgs e)
        {
            if (this.sendBytes >= 999999)
            {
                MessageBox.Show("发送数据太多，空间不足！", "消息提示框");
            }
        }

        /** 清零计数 */
        private void btnClearCount_Click(object sender, EventArgs e)
        {
            this.sendFrames = 0;
            this.sendBytes = 0;
            this.recvFrames = 0;
            this.recvBytes = 0;
            DataCountShow();
        }

        /***********【公共方法区】********************************************************************/
        /** 数据接收区显示 */
        private void RecvRegionShow(String data, bool isRecv)
        {
            // 判断是否自动清除接收区
            if (this.chkbAutoClear.Checked)
            {
                long allowLines = 20;
                if (Regex.IsMatch(this.textAllowLines.Text, @"^[0-9]{1,100}$"))
                {
                    // 获取指定清除的行数
                    allowLines = System.Convert.ToInt64(this.textAllowLines.Text, 10);
                }
                if (this.textRecvRegion.Lines.Length > allowLines)
                {
                    this.textRecvRegion.Text = "";
                }
            }

            if (isRecv)
            {
                this.textRecvRegion.SelectionColor = Color.Green;
                // 判断是否显示时间
                if (this.chkbShowTime.Checked)
                {
                    string now = DateTime.Now.ToString();
                    this.textRecvRegion.AppendText(now.Substring(now.Length - 8));
                }
                this.textRecvRegion.AppendText("【接收】");
                this.textRecvRegion.SelectionColor = Color.Red;
                this.textRecvRegion.SelectionFont = new Font("Consolas", 11, FontStyle.Regular);
                this.textRecvRegion.AppendText(data + "\r\n");
            }
            else
            {
                // 判断是否显示发送
                if (this.chkbShowSend.Checked)
                {
                    this.textRecvRegion.SelectionColor = Color.Blue;
                    // 判断是否显示时间
                    if (this.chkbShowTime.Checked)
                    {
                        string now = DateTime.Now.ToString();
                        this.textRecvRegion.AppendText(now.Substring(now.Length - 8));
                    }
                    this.textRecvRegion.AppendText("【发送】");
                    this.textRecvRegion.SelectionColor = Color.Black;
                    this.textRecvRegion.SelectionFont = new Font("Consolas", 11, FontStyle.Regular);
                    this.textRecvRegion.AppendText(data + "\r\n");
                }
            }
            // 让文本框获取焦点
            this.textRecvRegion.Focus();
            // 设置光标的位置到末尾
            this.textRecvRegion.Select(this.textRecvRegion.TextLength, 0);
            this.textRecvRegion.ScrollToCaret();
        }
        /** 收发数据数量统计 */
        private void DataCountShow()
        {
            if (this.chkbShowCount.Checked)
            {
                lblSendFrames.Text = "【" + String.Format("{0, 6}", this.sendFrames) + "   帧】";       // 补空格
                lblSendBytes.Text = "【" + String.Format("{0, 6}", this.sendBytes) + " 字节】";
                lblRecvFrames.Text = "【" + String.Format("{0, 6}", this.recvFrames) + "   帧】";
                lblRecvBytes.Text = "【" + String.Format("{0, 6}", this.recvBytes) + " 字节】";
            }
        }

        /** 指示灯亮 */
        private void LightOn(Label label)
        {
            Image image = BlueCentaurea.Properties.Resources.DataRSStatusOn1;
            label.Image = image.Clone() as Image;
            image.Dispose();
        }
        /** 指示灯灭 */
        private void LightOff(Label label)
        {
            Image image = BlueCentaurea.Properties.Resources.DataRSStatusOff1;
            label.Image = image.Clone() as Image;
            image.Dispose();
        }

        /** 初始化可用端口 */
        private void combBPortName_Click(object sender, EventArgs e)
        {
            // 在端口断开时恢复显示
            for (int i = 0; i < combBPortName.Items.Count; i++)
            {
                combBPortName.Items[i] = combBPortName.Items[i].ToString().Split('(')[0];
            }

            // 为可用的端口添加标志
            string[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string port in portList)
            {
                int index = combBPortName.FindString(port);
                combBPortName.Items[index] = port + "(已就绪)";
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            CRCCheckForm form = new CRCCheckForm();
            //form.Width = 270;
            //form.Height = 330;
            //form.TopLevel = false;
            //form.Dock = DockStyle.Right;
            //form.Parent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            //form.BringToFront();
            form.Show();

        }
    }




}
