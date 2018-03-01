using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;

namespace BlueCentaurea
{
    public partial class TransForm : Form
    {
        public TransForm()
        {
            InitializeComponent();
            MyTools.SetDefaultText(textTransData1, ConstValue.TEXT_TRANS_DATA_1);
            MyTools.SetDefaultText(textTransData2, ConstValue.TEXT_TRANS_DATA_2);
            MyTools.SetDefaultText(textTransData3, ConstValue.TEXT_TRANS_DATA_3);
            MyTools.SetDefaultText(textTransData4, ConstValue.TEXT_TRANS_DATA_4);
            MyTools.SetDefaultText(textTransData5, ConstValue.TEXT_TRANS_DATA_5);
            MyTools.SetDefaultText(textTransData6, ConstValue.TEXT_TRANS_DATA_6);
        }

        public void SelectTabPages(int index)
        {
            this.tabCtrlTrans.SelectedIndex = index;
            this.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        /******************16进制转换为GB2312*****************************************************************/
        /*private void textTransData1_Enter(object sender, EventArgs e)
        {
            textTransData1.Text = string.Empty;
            textTransData1.ForeColor = Color.Black;
        }*/
        private void textTransData1_MouseDown(object sender, EventArgs e)
        {
            if (this.textTransData1.Text == ConstValue.TEXT_TRANS_DATA_1)
            {
                textTransData1.Text = string.Empty;
                textTransData1.ForeColor = Color.Black;
            }
        }
        private void textTransData1_TextChanged(object sender, EventArgs e)
        {
            lblTransData1.Text = "【" + textTransData1.TextLength + "字节】";
        }
        private void textTransResult1_TextChanged(object sender, EventArgs e)
        {
            lblTransResult1.Text = "【" + textTransResult1.TextLength + "字节】";
        }
        private void Hex2GB2312_Click(object sender, EventArgs e)
        {
            MyTools.SetDefaultText(textTransData1, ConstValue.TEXT_TRANS_DATA_1);
        }
        private string HexToGB2312_Method(string text)
        {
            byte[] bs = MyTools.HexStringToBytes(Regex.Replace(text, @"\s", ""));
            if (bs == null)
            {
                return "数据不合法，请参照提示重新输入！";
            }
            return Encoding.GetEncoding("GBK").GetString(bs);
        }
        private void btnTransClear1_Click(object sender, EventArgs e)
        {
            textTransData1.Text = string.Empty;
            textTransResult1.Text = string.Empty;
        }
        private void btnTrans1_Click(object sender, EventArgs e)
        {
            textTransResult1.Text = HexToGB2312_Method(textTransData1.Text);
        }

        /******************GB2312转换为16进制*****************************************************************/
        private void textTransData2_MouseDown(object sender, EventArgs e)
        {
            if (this.textTransData2.Text == ConstValue.TEXT_TRANS_DATA_2)
            {
                textTransData2.Text = string.Empty;
                textTransData2.ForeColor = Color.Black;
            }
        }
        private void textTransData2_TextChanged(object sender, EventArgs e)
        {
            lblTransData2.Text = "【" + textTransData2.TextLength + "字节】";
        }
        private void textTransResult2_TextChanged(object sender, EventArgs e)
        {
            lblTransResult2.Text = "【" + textTransResult2.TextLength + "字节】";
        }
        private void GB2312ToHex_Click(object sender, EventArgs e)
        {
            MyTools.SetDefaultText(textTransData2, ConstValue.TEXT_TRANS_DATA_2);
        }
        private string GB2312ToHex_Method(string str)
        {
            byte[] gb = Encoding.GetEncoding("GBK").GetBytes(str);
            return MyTools.BytesToHexString(gb);
        }
        private void btnTransClear2_Click(object sender, EventArgs e)
        {
            textTransData2.Text = string.Empty;
            textTransResult2.Text = string.Empty;
        }
        private void btnTrans2_Click(object sender, EventArgs e)
        {
            textTransResult2.Text = GB2312ToHex_Method(textTransData2.Text);
        }


        /******************Hex2ASCII*****************************************************************/
        private void textTransData3_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textTransData3.Text == ConstValue.TEXT_TRANS_DATA_3)
            {
                textTransData3.Text = string.Empty;
                textTransData3.ForeColor = Color.Black;
            }
        }
        private void textTransData3_TextChanged(object sender, EventArgs e)
        {
            lblTransData3.Text = "【" + textTransData3.TextLength + "字节】";
        }
        private void textTransResult3_TextChanged(object sender, EventArgs e)
        {
            lblTransResult2.Text = "【" + textTransResult2.TextLength + "字节】";
        }
        private void Hex2ASC_Click(object sender, EventArgs e)
        {
            MyTools.SetDefaultText(textTransData3, ConstValue.TEXT_TRANS_DATA_3);
        }
        private void btnTransClear3_Click(object sender, EventArgs e)
        {
            textTransData3.Text = string.Empty;
            textTransResult3.Text = string.Empty;
        }
        private void btnTrans3_Click(object sender, EventArgs e)
        {
            if (raBtnTransHex2ASC1.Checked)
            {
                textTransResult3.Text = MyTools.Hex2ASCII(textTransData3.Text, 1);
            }
            else if (raBtnTransHex2ASC2.Checked)
            {
                textTransResult3.Text = MyTools.Hex2ASCII(textTransData3.Text, 0);
            }
            else
            {
                MessageBox.Show("请选择是否追加空格！", "消息提示框");
            }
        }


        /******************ASCII2ASC*****************************************************************/
        private void textTransData4_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textTransData4.Text == ConstValue.TEXT_TRANS_DATA_4)
            {
                textTransData4.Text = string.Empty;
                textTransData4.ForeColor = Color.Black;
            }
        }
        private void textTransData4_TextChanged(object sender, EventArgs e)
        {
            lblTransData4.Text = "【" + textTransData4.TextLength + "字节】";
        }
        private void textTransResult4_TextChanged(object sender, EventArgs e)
        {
            lblTransResult4.Text = "【" + textTransResult4.TextLength + "字节】";
        }
        private void ASC2Hex_Click(object sender, EventArgs e)
        {
            MyTools.SetDefaultText(textTransData4, ConstValue.TEXT_TRANS_DATA_4);
        }
        private void btnTransClear4_Click(object sender, EventArgs e)
        {
            textTransData4.Text = string.Empty;
            textTransResult4.Text = string.Empty;
        }
        private void btnTrans4_Click(object sender, EventArgs e)
        {
            if (raBtnTransASC2Hex1.Checked)
            {
                textTransResult4.Text = MyTools.ASCII2Hex(textTransData4.Text, 1);
            }
            else if (raBtnTransASC2Hex2.Checked)
            {
                textTransResult4.Text = MyTools.ASCII2Hex(textTransData4.Text, 0);
            }
            else
            {
                MessageBox.Show("请选择是否追加空格！", "消息提示框");
            }
        }


        /******************按钮_Hex2UTF-8*****************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /******************按钮_UTF-82Hex*****************************************************************/
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void TransForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }
    }
}

