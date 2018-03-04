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
    }
}
