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
using System.Threading;

namespace BlueCentaurea
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }

        public void SelectTabPages(int index)
        {
            this.tabCtrlCheck.SelectedIndex = index;
            this.Show();
        }

        /****************************【1】【计算MD5】【start】*****************************************************/
        /** 浏览打开文件 */
        private void textMD5Path01_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textMD5Path01.Text = string.Empty;
                this.textMD5Path01.AppendText(Path.GetDirectoryName(this.openFileDialog.FileName));
                this.textMD5Path01.AppendText("\\");
                this.textMD5Path01.AppendText(Path.GetFileName(this.openFileDialog.FileName));
            }
        }
        /** 计算MD5 */
        private void btnCheckMD5Execute01_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textMD5Path01.Text != null && !"".Equals(this.textMD5Path01.Text))
                {
                    FileStream file = new FileStream(this.textMD5Path01.Text, FileMode.Open);
                    System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    byte[] retVal = md5.ComputeHash(file);
                    file.Close();

                    this.textMD5Result01.Text = MyTools.BytesToHexString(retVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("检查文件是否存在！" + ex.Message, "错误");
            }
        }

        /** 浏览打开文件 */
        private void textMD5Path02_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textMD5Path02.Text = string.Empty;
                this.textMD5Path02.AppendText(Path.GetDirectoryName(this.openFileDialog.FileName));
                this.textMD5Path02.AppendText("\\");
                this.textMD5Path02.AppendText(Path.GetFileName(this.openFileDialog.FileName));
            }
        }
        /** 计算MD5 */
        private void btnCheckMD5Execute02_Click(object sender, EventArgs e)
        {
            try
            {
                this.textMD5Result02.Text = string.Empty;
                if (this.textMD5Path02.Text != string.Empty)
                {
                    FileStream file = new FileStream(this.textMD5Path02.Text, FileMode.Open);
                    System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    byte[] retVal = md5.ComputeHash(file);
                    file.Close();

                    this.textMD5Result02.Text = MyTools.BytesToHexString(retVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("检查文件是否存在！" + ex.Message, "错误");
            }
        }
        /****************************【1】【计算MD5】【end】*****************************************************/

        /****************************【2】【计算SHA】【start】*****************************************************/
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
                this.txtBoxCheckResultSHA1.Text = string.Empty;
                if (this.txtBoxCheckSelectSHA1.Text != null && !"".Equals(this.txtBoxCheckSelectSHA1.Text))
                {
                    FileStream file = new FileStream(this.txtBoxCheckSelectSHA1.Text, FileMode.Open);
                    byte[] retVal;
                    if (this.radioButtonSHA512.Checked)
                    {
                        SHA512 sha512 = new SHA512Managed();
                        retVal = sha512.ComputeHash(file);
                        sha512.Clear();
                    }
                    else if (this.radioButtonSHA384.Checked)
                    {
                        SHA384 sha384 = new SHA384Managed();
                        retVal = sha384.ComputeHash(file);
                        sha384.Clear();
                    }
                    else if (this.radioButtonSHA256.Checked)
                    {
                        SHA256 sha256 = new SHA256Managed();
                        retVal = sha256.ComputeHash(file);
                        sha256.Clear();
                    }
                    else
                    {
                        SHA1 sha1 = new SHA1CryptoServiceProvider();
                        retVal = SHA1.Create().ComputeHash(file);
                        sha1.Clear();
                    }
                    file.Close();

                    this.txtBoxCheckResultSHA1.Text = MyTools.BytesToHexString(retVal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("检查文件是否存在！" + ex.Message, "错误");
            }
        }

        /****************************【2】【计算SHA】【end】*****************************************************/

        private void CheckForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }
    }
}
