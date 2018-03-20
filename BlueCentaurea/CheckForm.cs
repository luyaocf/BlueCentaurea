using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BlueCentaurea
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
            this.textBoxUTF.Text = "请输入字符串";
            this.textBoxGB2312.Text = "请输入字符串";
            this.textBoxGBK.Text = "请输入字符串";
            this.textBoxUnicode.Text = "请输入字符串";
        }

        public void SelectTabPages(int index)
        {
            this.tabCtrlCheck.SelectedIndex = index;
            this.Show();
        }

        private void btnCheckSelect_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtBoxCheckSelectMD5.Text = string.Empty;
                this.txtBoxCheckSelectMD5.AppendText(Path.GetDirectoryName(this.openFileDialog.FileName));
                this.txtBoxCheckSelectMD5.AppendText("\\");
                this.txtBoxCheckSelectMD5.AppendText(Path.GetFileName(this.openFileDialog.FileName));
                this.txtBoxCheckSelectMD5.Enabled = false;
            }
        }

        private void CheckForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }

        private void btnCheckMD5_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtBoxCheckSelectMD5.Text != null && !"".Equals(this.txtBoxCheckSelectMD5.Text))
                {
                    FileStream file = new FileStream(this.txtBoxCheckSelectMD5.Text, FileMode.Open);
                    System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    byte[] retVal = md5.ComputeHash(file);
                    file.Close();

                    this.textBoxCheckResultMD5.Text = MyTools.BytesToHexString(retVal);                           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("检查文件是否存在！", "错误");
            }
        }

        private void btnCheckSelectSHA1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtBoxCheckSelectSHA1.Text = string.Empty;
                this.txtBoxCheckSelectSHA1.AppendText(Path.GetDirectoryName(this.openFileDialog.FileName));
                this.txtBoxCheckSelectSHA1.AppendText("\\");
                this.txtBoxCheckSelectSHA1.AppendText(Path.GetFileName(this.openFileDialog.FileName));
                this.txtBoxCheckSelectSHA1.Enabled = false;
            }
        }

        private void btnCheckResultSHA1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtBoxCheckSelectSHA1.Text != null && !"".Equals(this.txtBoxCheckSelectSHA1.Text))
                {
                    FileStream file = new FileStream(this.txtBoxCheckSelectSHA1.Text, FileMode.Open);
                    SHA1 sha1 = new SHA1CryptoServiceProvider();
                    byte[] retVal = SHA1.Create().ComputeHash(file);
                    file.Close();

                    this.txtBoxCheckResultSHA1.Text = MyTools.BytesToHexString(retVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("检查文件是否存在！", "错误");
            }
        }

        private void textBoxUTF_TextChanged(object sender, EventArgs e)
        {
            int len = Encoding.GetEncoding("UTF-8").GetBytes(this.textBoxUTF.Text).Length;
            this.labelUtf.Text = "【" + len + "字节】";
        }

        private void textBoxUTF_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textBoxUTF.Text == "请输入字符串")
            {
                this.textBoxUTF.Text = string.Empty;
                this.textBoxUTF.ForeColor = Color.Black;
            }
        }

        private void textBoxGB2312_TextChanged(object sender, EventArgs e)
        {
            int len = Encoding.GetEncoding("GB2312").GetBytes(this.textBoxGB2312.Text).Length;
            this.labelGB2312.Text = "【" + len + "字节】";
        }

        private void textBoxGB2312_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textBoxGB2312.Text == "请输入字符串")
            {
                this.textBoxGB2312.Text = string.Empty;
                this.textBoxGB2312.ForeColor = Color.Black;
            }
        }

        private void textBoxGBK_TextChanged(object sender, EventArgs e)
        {
            int len = Encoding.GetEncoding("GBK").GetBytes(this.textBoxGBK.Text).Length;
            this.labelGBK.Text = "【" + len + "字节】";
        }

        private void textBoxGBK_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textBoxGBK.Text == "请输入字符串")
            {
                this.textBoxGBK.Text = string.Empty;
                this.textBoxGBK.ForeColor = Color.Black;
            }
        }

        private void textBoxUnicode_TextChanged(object sender, EventArgs e)
        {
            int len = Encoding.GetEncoding("Unicode").GetBytes(this.textBoxUnicode.Text).Length;
            this.labelUnicode.Text = "【" + len + "字节】";
        }

        private void textBoxUnicode_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.textBoxUnicode.Text == "请输入字符串")
            {
                this.textBoxUnicode.Text = string.Empty;
                this.textBoxUnicode.ForeColor = Color.Black;
            }
        }

        private void tbpCalcStrLen_Click(object sender, EventArgs e)
        {
            this.textBoxUTF.Text = "请输入字符串";
            this.textBoxUTF.ForeColor = Color.Gray;

            this.textBoxGB2312.Text = "请输入字符串";
            this.textBoxGB2312.ForeColor = Color.Gray;

            this.textBoxGBK.Text = "请输入字符串";
            this.textBoxGBK.ForeColor = Color.Gray;

            this.textBoxUnicode.Text = "请输入字符串";
            this.textBoxUnicode.ForeColor = Color.Gray;
        }
    }
}
