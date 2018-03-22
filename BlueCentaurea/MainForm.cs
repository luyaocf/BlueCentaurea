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

namespace BlueCentaurea
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Hex2GB2312ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransForm transForm = new TransForm();
            transForm.StartPosition = FormStartPosition.CenterScreen;
            transForm.SelectTabPages(0);
        }
        private void GB2312ToHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransForm transForm = new TransForm();
            transForm.StartPosition = FormStartPosition.CenterScreen;
            transForm.SelectTabPages(1);
        }
        private void Hex2ASCII_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransForm transForm = new TransForm();
            transForm.StartPosition = FormStartPosition.CenterScreen;
            transForm.SelectTabPages(2);
        }
        private void ASCII2Hex_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransForm transForm = new TransForm();
            transForm.StartPosition = FormStartPosition.CenterScreen;
            transForm.SelectTabPages(3);
        }
        private void hex2UTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransForm transForm = new TransForm();
            transForm.StartPosition = FormStartPosition.CenterScreen;
            transForm.SelectTabPages(4);
        }
        private void uTF82HexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransForm transForm = new TransForm();
            transForm.StartPosition = FormStartPosition.CenterScreen;
            transForm.SelectTabPages(5);
        }
        private void Serial_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialForm serialForm = new SerialForm();
            serialForm.StartPosition = FormStartPosition.CenterScreen;
            serialForm.Show();
        }
        /********************************************************************************************/

        private void MD5_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm();
            encryptForm.StartPosition = FormStartPosition.CenterScreen;
            encryptForm.SelectTabPages(0);
        }
        private void DES_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm();
            encryptForm.StartPosition = FormStartPosition.CenterScreen;
            encryptForm.SelectTabPages(1);
        }
        private void TriDES_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm();
            encryptForm.StartPosition = FormStartPosition.CenterScreen;
            encryptForm.SelectTabPages(2);
        }
        private void TriMac_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm();
            encryptForm.StartPosition = FormStartPosition.CenterScreen;
            encryptForm.SelectTabPages(3);
        }

        /********************************************************************************************/
        private void Network_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkForm networkForm = new NetworkForm();
            NetworkForm.network.StartPosition = FormStartPosition.CenterParent;
            NetworkForm.network.Show();
        }

        /********************************************************************************************/

        private void watchHelp_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("注意输入文本框的提示内容！", "帮助");
        }
        private void contectUs_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("邮箱:861317026@qq.com", "联系我们");
        }
        private void aboutBlueCentaurea_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我承认，我盗了chrome浏览器的图！侵删", "关于 BlueCentaurea V2.0");
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2017-06-14\r   1 编码转换功能实现\r" +
                "   2 加(解)密功能实现\r" +
                "2018-02-27\r   1 编码转换时，HEX格式的字符串自动去掉空格\r" +
                "2018-02-28\r   1 使用ESC快捷键关闭窗口\r"
                , "更新日志");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Check_ToolStripMenuItem_Clic(object sender, EventArgs e)
        {
            
        }

        private void calcStrLenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForm checkForm = new CheckForm();
            checkForm.StartPosition = FormStartPosition.CenterParent;
            checkForm.SelectTabPages(2);
        }

        private void mD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForm checkForm = new CheckForm();
            checkForm.StartPosition = FormStartPosition.CenterParent;
            checkForm.SelectTabPages(0);
        }

        private void sHA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForm checkForm = new CheckForm();
            checkForm.StartPosition = FormStartPosition.CenterParent;
            checkForm.SelectTabPages(1);
        }

        private void QQOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckForm checkForm = new CheckForm();
            checkForm.StartPosition = FormStartPosition.CenterParent;
            checkForm.SelectTabPages(3);
        }

        private void qqOnlineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.StartPosition = FormStartPosition.CenterScreen;
            queryForm.SelectTabPages(0);
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.StartPosition = FormStartPosition.CenterScreen;
            queryForm.SelectTabPages(1);
        }

        private void airportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.StartPosition = FormStartPosition.CenterScreen;
            queryForm.SelectTabPages(2);
        }
    }

    public class ConstValue
    {
        public static string TEXT_TRANS_DATA_1 = "请输入16进制字符串！";
        public static string TEXT_TRANS_DATA_2 = "请输入汉字！";
        public static string TEXT_TRANS_DATA_3 = "请输入16进制字符串！";
        public static string TEXT_TRANS_DATA_4 = "请输入ASCII码！";
        public static string TEXT_TRANS_DATA_5 = "请输入16进制字符串！";
        public static string TEXT_TRANS_DATA_6 = "请输入汉字！";

        public static string TEXT_MD5_DATA = "请输入数据！";
        public static string TEXT_DES_DATA = "请输入需要加密的数据！";
        public static string TEXT_DES_KEY = "D1D2D3D4D5D6D7D8";
        public static string TEXT_TRIDES_DATA = "请输入需要加密的数据！";
        public static string TEXT_TRIDES_KEY = "D1D2D3D4D5D6D7D8E1E2E3E4E5E6E7E8";
        public static string TEXT_TRIMAC_DATA = "请输入需要计算3MAC的数据";
        public static string TEXT_TRIMAC_KEY = "D1D2D3D4D5D6D7D8E1E2E3E4E5E6E7E8";


    }


    public class MyTools
    {
        public static String BytesToHexString(byte[] bys)
        {
            if (bys == null)
            {
                return null;
            }
            StringBuilder returnStr = new StringBuilder();
            for (int i = 0; i < bys.Length; i++)
            {
                returnStr.Append(bys[i].ToString("X2"));
            }

            return returnStr.ToString();
        }

        public static String BytesToHexString(byte[] bys, bool flag = true)
        {
            if (bys == null)
            {
                return null;
            }
            StringBuilder returnStr = new StringBuilder();
            if (flag != true)
            {
                for (int i = 0; i < bys.Length; i++)
                {
                    returnStr.Append(bys[i].ToString("X2"));
                }
            }
            else
            {
                for (int i = 0; i < bys.Length; i++)
                {
                    returnStr.Append(bys[i].ToString("X2") + " ");
                }
            }

            return returnStr.ToString();
        }

        public static byte[] HexStringToBytes(String strSrc)
        {
            try
            {
                if (strSrc == string.Empty)             // 字符串为空退出
                    return null;

                int srcLen = strSrc.Length;     // 获取源字符串长度
                if (srcLen % 2 != 0)            // 长度不为偶数退出
                {
                    MessageBox.Show("您输入的数据格式不正确！", "消息提示框");
                    return null;
                }
                for (int i = 0; i < strSrc.Length; i++) // 输入的字符串包含汉字退出
                {
                    if (strSrc[i] > 127)
                        return null;
                }
                byte[] bys = new byte[srcLen / 2];
                String aa = "";
                for (int i = 0; i < srcLen / 2; i++)
                {
                    aa = strSrc.Substring(i * 2, 2);
                    bys[i] = byte.Parse(aa, System.Globalization.NumberStyles.AllowHexSpecifier);
                }
                return bys;
            }
            catch (Exception e)
            {
                MessageBox.Show("您输入的数据格式不正确！", "消息提示框");
            }

            return null;
        }

        public static void SetDefaultText(TextBox txt, String value)
        {
            txt.ForeColor = Color.Gray;
            txt.Text = value;
        }

        public static String Hex2ASCII(string hex, int index)
        {
            try
            {
                byte[] bys = MyTools.HexStringToBytes(Regex.Replace(hex, @"\s", ""));
                if (bys == null)
                {
                    return null;
                }
                StringBuilder stringBuilder = new StringBuilder();
                if (index == 0)
                {
                    for (int i = 0; i < bys.Length; i++)
                    {
                        stringBuilder.Append(((char)bys[i]).ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < bys.Length; i++)
                    {
                        stringBuilder.Append(((char)bys[i]).ToString() + " ");
                    }
                }

                return stringBuilder.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "消息提示框");
            }

            return null;
        }

        public static string ASCII2Hex(string asc, int index)
        {
            try
            {
                // byte[] byts = System.Text.ASCIIEncoding.Default.GetBytes(asc);
                byte[] byts = Encoding.UTF8.GetBytes(asc);
                StringBuilder stringBuilder = new StringBuilder();
                if (index == 0)
                {
                    foreach (byte byt in byts)
                    {
                        stringBuilder.Append(byt.ToString("x"));
                    }
                }
                else
                {
                    foreach (byte byt in byts)
                    {
                        stringBuilder.Append(byt.ToString("x") + " ");
                    }
                }
                return stringBuilder.ToString().ToUpper();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "消息提示框");
            }

            return null;
        }
    }
}
