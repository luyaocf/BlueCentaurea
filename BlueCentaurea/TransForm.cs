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
        }

        public void SelectTabPages(int index)
        {
            this.tabCtrlTrans.SelectedIndex = index;
            this.Show();
        }

        private void TransForm_Load(object sender, EventArgs e)
        {
            textTransData01.ForeColor = Color.Gray;
            textTransData01.Text = ConstValue.TEXT_TRANS_DATA_1;
            textTransData02.ForeColor = Color.Gray;
            textTransData02.Text = ConstValue.TEXT_TRANS_DATA_2;
            textTransData03.ForeColor = Color.Gray;
            textTransData03.Text = ConstValue.TEXT_TRANS_DATA_3;
            textTransData04.ForeColor = Color.Gray;
            textTransData04.Text = ConstValue.TEXT_TRANS_DATA_4;
            textTransData05.ForeColor = Color.Gray;
            textTransData05.Text = ConstValue.TEXT_TRANS_DATA_5;
        }


        /******************【01】【16进制字符串转换为汉字】**************************************************************/
        /** 第一次进入清空输入框 */
        private void textTransData01_Enter(object sender, EventArgs e)
        {
            if (textTransData01.ForeColor == Color.Gray)
            {
                textTransData01.Text = string.Empty;
                textTransData01.ForeColor = Color.Black;
            }
        }
        /** 鼠标按下清空输入框 */
        private void textTransData01_MouseDown(object sender, MouseEventArgs e)
        {
            if (textTransData01.ForeColor == Color.Gray)
            {
                textTransData01.Text = string.Empty;
                textTransData01.ForeColor = Color.Black;
            }
        }
        /** 鼠标按下清空步进框 */
        private void textBox01_01_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBox01_01.Text = string.Empty;
        }

        /** 输入文本改变 */
        private void textTransData01_TextChanged(object sender, EventArgs e)
        {
            lblTransData1.Text = "【" + textTransData01.TextLength + "字节】";
        }
        /** 结果输出改变 */
        private void textTransResult01_TextChanged(object sender, EventArgs e)
        {
            lblTransResult1.Text = "【" + textTransResult01.TextLength + "字节】";
        }

        /** 恢复默认 */
        private void Hex2ChineseChar_Click(object sender, EventArgs e)
        {
            textTransData01.ForeColor = Color.Gray;
            textTransData01.Text = ConstValue.TEXT_TRANS_DATA_1;
        }

        /** 清除按钮触发 */
        private void btnTransClear01_Click(object sender, EventArgs e)
        {
            textTransData01.Text = string.Empty;
            textTransResult01.Text = string.Empty;
        }
        /** 执行按钮触发 */
        private void btnTransExecute01_Click(object sender, EventArgs e)
        {
            textTransResult01.Text = Hex2ChineseChar_Method(textTransData01.Text);
        }
        /** 计算方法 */
        private string Hex2ChineseChar_Method(string text)
        {
            byte[] bs = MyTools.HexStringToBytes(Regex.Replace(text, @"\s", ""));
            if (bs == null)
            {
                return "数据不合法，请参照提示重新输入！";
            }
            if (this.radioButton01_01.Checked)
            {
                if (this.radioButton01_03.Checked)
                {
                    return MyTools.addBlank(Encoding.GetEncoding("GBK").GetString(bs), int.Parse(this.textBox01_01.Text), true);
                }
                else
                {
                    return Encoding.GetEncoding("GBK").GetString(bs);
                }
            }
            else
            {
                if (this.radioButton01_03.Checked)
                {
                    return MyTools.addBlank(Encoding.GetEncoding("UTF-8").GetString(bs), int.Parse(this.textBox01_01.Text), true);
                }
                else
                {
                    return Encoding.GetEncoding("UTF-8").GetString(bs);
                }
            }
        }

        /******************【02】【汉字转换为16进制】*****************************************************************/
        /** 第一次进入清空输入框 */
        private void textTransData02_Enter(object sender, EventArgs e)
        {
            if (textTransData02.ForeColor == Color.Gray)
            {
                textTransData02.Text = string.Empty;
                textTransData02.ForeColor = Color.Black;
            }
        }
        /** 鼠标按下清空输入框 */
        private void textTransData02_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textTransData02.ForeColor == Color.Gray)
            {
                textTransData02.Text = string.Empty;
                textTransData02.ForeColor = Color.Black;
            }
        }
        /** 鼠标按下清空步进框 */
        private void textBox02_01_MouseDown(object sender, MouseEventArgs e)
        {
            this.textBox02_01.Text = string.Empty;
        }

        /** 输入文本改变 */
        private void textTransData02_TextChanged(object sender, EventArgs e)
        {
            lblTransData2.Text = "【" + textTransData02.TextLength + "字节】";
        }
        /** 结果输出改变 */
        private void textTransResult02_TextChanged(object sender, EventArgs e)
        {
            lblTransResult2.Text = "【" + textTransResult02.TextLength + "字节】";
        }

        /** 恢复默认 */
        private void ChineseCharToHex_Click(object sender, EventArgs e)
        {
            textTransData02.ForeColor = Color.Gray;
            textTransData02.Text = ConstValue.TEXT_TRANS_DATA_2;
        }

        /** 清除按钮触发 */
        private void btnTransClear02_Click(object sender, EventArgs e)
        {
            textTransData02.Text = string.Empty;
            textTransResult02.Text = string.Empty;
        }
        /** 执行按钮触发 */
        private void btnTransExecute02_Click(object sender, EventArgs e)
        {
            textTransResult02.Text = ChineseCharToHex_Method(textTransData02.Text);
        }
        /** 计算方法 */
        private string ChineseCharToHex_Method(string str)
        {
            if (this.radioButton02_01.Checked)
            {
                byte[] bytes = Encoding.GetEncoding("GBK").GetBytes(str);
                if (this.radioButton02_03.Checked)
                {
                    return MyTools.addBlank(MyTools.BytesToHexString(bytes), int.Parse(this.textBox02_01.Text), false);
                }
                return MyTools.BytesToHexString(bytes);
            }
            else
            {
                byte[] bytes = Encoding.GetEncoding("UTF-8").GetBytes(str);
                if (this.radioButton02_03.Checked)
                {
                    return MyTools.addBlank(MyTools.BytesToHexString(bytes), int.Parse(this.textBox02_01.Text), false);
                }
                return MyTools.BytesToHexString(bytes);
            }
        }

        /******************【03】【Hex转换为ASCII】*****************************************************************/
        /** 第一次进入清空输入框 */
        private void textTransData03_Enter(object sender, EventArgs e)
        {
            if (textTransData03.ForeColor == Color.Gray)
            {
                textTransData03.Text = string.Empty;
                textTransData03.ForeColor = Color.Black;
            }
        }
        /** 鼠标按下清空输入框 */
        private void textTransData03_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textTransData03.ForeColor == Color.Gray)
            {
                textTransData03.Text = string.Empty;
                textTransData03.ForeColor = Color.Black;
            }
        }

        /** 输入文本改变 */
        private void textTransData03_TextChanged(object sender, EventArgs e)
        {
            lblTransData3.Text = "【" + textTransData03.TextLength + "字节】";
        }
        /** 结果输出改变 */
        private void textTransResult03_TextChanged(object sender, EventArgs e)
        {
            lblTransResult2.Text = "【" + textTransResult03.TextLength + "字节】";
        }

        /** 恢复默认 */
        private void Hex2ASC_Click(object sender, EventArgs e)
        {
            textTransData03.ForeColor = Color.Gray;
            textTransData03.Text = ConstValue.TEXT_TRANS_DATA_3;
        }

        /** 清除按钮触发 */
        private void btnTransClear03_Click(object sender, EventArgs e)
        {
            textTransData03.Text = string.Empty;
            textTransResult03.Text = string.Empty;
        }
        /** 执行按钮触发 */
        private void btnTransExecute03_Click(object sender, EventArgs e)
        {
            if (radioButton03_01.Checked)
            {
                textTransResult03.Text = MyTools.Hex2ASCII(textTransData03.Text, 1);
            }
            else if (radioButton03_02.Checked)
            {
                textTransResult03.Text = MyTools.Hex2ASCII(textTransData03.Text, 0);
            }
            else
            {
                MessageBox.Show("请选择是否追加空格！", "消息提示框");
            }
        }


        /******************【04】【ASCII转换为HEX】*****************************************************************/
        /** 第一次进入清空输入框 */
        private void textTransData04_Enter(object sender, EventArgs e)
        {
            if (textTransData04.ForeColor == Color.Gray)
            {
                textTransData04.Text = string.Empty;
                textTransData04.ForeColor = Color.Black;
            }
        }
        /** 鼠标按下清空输入框 */
        private void textTransData04_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textTransData04.ForeColor == Color.Gray)
            {
                textTransData04.Text = string.Empty;
                textTransData04.ForeColor = Color.Black;
            }
        }

        /** 输入文本改变 */
        private void textTransData04_TextChanged(object sender, EventArgs e)
        {
            lblTransData4.Text = "【" + textTransData04.TextLength + "字节】";
        }
        /** 结果输出改变 */
        private void textTransResult04_TextChanged(object sender, EventArgs e)
        {
            lblTransResult04.Text = "【" + textTransResult04.TextLength + "字节】";
        }

        /** 恢复默认 */
        private void ASC2Hex_Click(object sender, EventArgs e)
        {
            textTransData04.ForeColor = Color.Gray;
            textTransData04.Text = ConstValue.TEXT_TRANS_DATA_4;
        }

        /** 清除按钮触发 */
        private void btnTransClear04_Click(object sender, EventArgs e)
        {
            textTransData04.Text = string.Empty;
            textTransResult04.Text = string.Empty;
        }
        /** 执行按钮触发 */
        private void btnTransExecute04_Click(object sender, EventArgs e)
        {
            if (radioButton04_01.Checked)
            {
                textTransResult04.Text = MyTools.ASCII2Hex(textTransData04.Text, 1);
            }
            else if (radioButton04_02.Checked)
            {
                textTransResult04.Text = MyTools.ASCII2Hex(textTransData04.Text, 0);
            }
            else
            {
                MessageBox.Show("请选择是否追加空格！", "消息提示框");
            }
        }


        /******************【05】【操作空格】*****************************************************************/
        /** 第一次进入清空输入框 */
        private void textTransData05_Enter(object sender, EventArgs e)
        {
            if (textTransData05.ForeColor == Color.Gray)
            {
                textTransData05.Text = string.Empty;
                textTransData05.ForeColor = Color.Black;
            }
        }
        /** 鼠标按下清空输入框 */
        private void textTransData05_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textTransData05.ForeColor == Color.Gray)
            {
                textTransData05.Text = string.Empty;
                textTransData05.ForeColor = Color.Black;
            }
        }

        /** 输入文本改变 */
        private void textTransData05_TextChanged(object sender, EventArgs e)
        {
            lblTransData05.Text = "【" + textTransData05.TextLength + "字节】";
        }
        /** 结果输出改变 */
        private void textTransResult05_TextChanged(object sender, EventArgs e)
        {
            lblTransResult05.Text = "【" + textTransResult05.TextLength + "字节】";
        }

        /** 恢复默认 */
        private void OperatorBlank_Click(object sender, EventArgs e)
        {
            textTransData05.ForeColor = Color.Gray;
            textTransData05.Text = ConstValue.TEXT_TRANS_DATA_5;
        }

        /** 清除按钮触发 */
        private void btnTransClear05_Click(object sender, EventArgs e)
        {
            textTransData05.Text = string.Empty;
            textTransResult05.Text = string.Empty;
        }
        /** 执行按钮触发 */
        private void btnTransExecute05_Click(object sender, EventArgs e)
        {
            if (radioButton05_01.Checked)
            {
                textTransResult05.Text = MyTools.addBlank(textTransData05.Text, int.Parse(this.textBox05_01.Text), false);
            }
            else
            {
                textTransResult05.Text = Regex.Replace(textTransData05.Text, @"\s", "");
            }
        }

        /******************【06】【进制转换】*****************************************************************/
        /** 关闭Text_Changed事件 */
        private void Close_TextChanged()
        {
            richTextBox06_02.TextChanged -= new EventHandler(richTextBox06_02_TextChanged);
            richTextBox06_08.TextChanged -= new EventHandler(richTextBox06_08_TextChanged);
            richTextBox06_10.TextChanged -= new EventHandler(richTextBox06_10_TextChanged);
            richTextBox06_16.TextChanged -= new EventHandler(richTextBox06_16_TextChanged);
        }
        /** 打开Text_Changed事件 */
        private void Open_TextChanged()
        {
            richTextBox06_02.TextChanged += new EventHandler(richTextBox06_02_TextChanged);
            richTextBox06_08.TextChanged += new EventHandler(richTextBox06_08_TextChanged);
            richTextBox06_10.TextChanged += new EventHandler(richTextBox06_10_TextChanged);
            richTextBox06_16.TextChanged += new EventHandler(richTextBox06_16_TextChanged);
        }
        private void richTextBox06_02_TextChanged(object sender, EventArgs e)
        {
            Close_TextChanged();
            if (Regex.IsMatch(richTextBox06_02.Text, @"^[0-1]{1,64}$"))
            {
                long radix = System.Convert.ToInt64(richTextBox06_02.Text, 2);
                richTextBox06_08.Text = System.Convert.ToString(radix, 8);
                richTextBox06_10.Text = System.Convert.ToString(radix, 10);
                richTextBox06_16.Text = System.Convert.ToString(radix, 16).ToUpper();
            }
            Open_TextChanged();
        }
        private void richTextBox06_08_TextChanged(object sender, EventArgs e)
        {
            Close_TextChanged();
            if (Regex.IsMatch(richTextBox06_08.Text, @"^[0-7]{1,22}$"))
            {
                long radix = System.Convert.ToInt64(richTextBox06_08.Text, 8);
                richTextBox06_02.Text = System.Convert.ToString(radix, 2);
                richTextBox06_10.Text = System.Convert.ToString(radix, 10);
                richTextBox06_16.Text = System.Convert.ToString(radix, 16).ToUpper();
            }
            Open_TextChanged();
        }
        private void richTextBox06_10_TextChanged(object sender, EventArgs e)
        {
            Close_TextChanged();
            if (Regex.IsMatch(richTextBox06_10.Text, @"^\d{1,19}$"))
            {
                long radix = System.Convert.ToInt64(richTextBox06_10.Text, 10);
                richTextBox06_02.Text = System.Convert.ToString(radix, 2);
                richTextBox06_08.Text = System.Convert.ToString(radix, 8);
                richTextBox06_16.Text = System.Convert.ToString(radix, 16).ToUpper();
            }
            Open_TextChanged();
        }
        private void richTextBox06_16_TextChanged(object sender, EventArgs e)
        {
            Close_TextChanged();
            if (Regex.IsMatch(richTextBox06_16.Text, @"^[0-9a-fA-F]{1,16}$"))
            {
                long radix = System.Convert.ToInt64(richTextBox06_16.Text, 16);
                richTextBox06_02.Text = System.Convert.ToString(radix, 2);
                richTextBox06_08.Text = System.Convert.ToString(radix, 8);
                richTextBox06_10.Text = System.Convert.ToString(radix, 10);
            }
            Open_TextChanged();
        }
        /** 清除内容 */
        private void radixTrans_Click(object sender, EventArgs e)
        {
            richTextBox06_02.Text = string.Empty;
            richTextBox06_08.Text = string.Empty;
            richTextBox06_10.Text = string.Empty;
            richTextBox06_16.Text = string.Empty;
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

