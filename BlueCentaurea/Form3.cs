using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueCentaurea
{
    public partial class EncryptForm : Form
    {

        public EncryptForm()
        {
            InitializeComponent();
            // 为MD5文本框设置默认值
            MyTools.SetDefaultText(textEncryptMD5Data, ConstValue.TEXT_MD5_DATA);
            // 为DES文本框设置默认值
            MyTools.SetDefaultText(textEncryptDESData, ConstValue.TEXT_DES_DATA);
            MyTools.SetDefaultText(textEncryptDESKey, ConstValue.TEXT_DES_KEY);
            // 为3DES文本框设置默认值
            MyTools.SetDefaultText(textEncryptTriDESData, ConstValue.TEXT_TRIDES_DATA);
            MyTools.SetDefaultText(textEncryptTriDESKey, ConstValue.TEXT_TRIDES_KEY);
            // 为3MAC文本框设置默认值
            MyTools.SetDefaultText(textEncryptTriMACData, ConstValue.TEXT_TRIMAC_DATA);
            MyTools.SetDefaultText(textEncryptTriMACKey, ConstValue.TEXT_TRIMAC_KEY);
        }

        public void SelectTabPages(int index)
        {
            this.tabCtrlEncrypt.SelectedIndex = index;
            this.Show();
        }

        private void EncryptForm_KeyDown(object sender, KeyEventArgs e)
        {
            // e.Handled = true;
            // if (e.KeyCode == Keys.Escape) 
            if (e.KeyCode == Keys.Escape)
            {
                textEncryptMD5Data.Text = "ESC";
                // this.Close();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        /**********MD5****************************************************************/
        private void textEncryptMD5Data_MouseDown(object sender, EventArgs e)
        {
            if (this.textEncryptMD5Data.Text == ConstValue.TEXT_MD5_DATA)
            {
                textEncryptMD5Data.Text = string.Empty;
                textEncryptMD5Data.ForeColor = Color.Black;
            }
        }
        private void textEncryptMD5Data_TextChanged(object sender, EventArgs e)
        {
            lblEncryptMD53.Text = "【" + textEncryptMD5Data.TextLength + "字节】";
        }
        private void textEncryptMD5Result_TextChanged(object sender, EventArgs e)
        {
            lblEncryptMD54.Text = "【" + textEncryptMD5Result.TextLength + "字节】";
        }
        private void MD5_Click(object sender, EventArgs e)
        {
            MyTools.SetDefaultText(textEncryptMD5Data, ConstValue.TEXT_MD5_DATA);
        }
        private void btnEncryptMD51_Click(object sender, EventArgs e)
        {
            textEncryptMD5Data.Text = string.Empty;
            textEncryptMD5Result.Text = string.Empty;
        }
        private void btnEncryptMD52_Click(object sender, EventArgs e)
        {
            if (raBtnUTF8.Checked)
            {
                textEncryptMD5Result.Text = MyEnctypt.GetMD5(textEncryptMD5Data.Text, 1);
            }
            else if (raBtnHEX.Checked)
            {
                textEncryptMD5Result.Text = MyEnctypt.GetMD5(textEncryptMD5Data.Text, 2);
            }
        }

        /**********DES****************************************************************/
        private void textEncryptDESData_MouseDown(object sender, EventArgs e)
        {
            if (this.textEncryptDESData.Text == ConstValue.TEXT_DES_DATA)
            {
                textEncryptDESData.Text = string.Empty;
                textEncryptDESData.ForeColor = Color.Black;
            }
        }
        private void textEncryptDESKey_MouseDown(object sender, EventArgs e)
        {
            if (this.textEncryptDESKey.Text == ConstValue.TEXT_DES_KEY)
            {
                textEncryptDESKey.Text = string.Empty;
                textEncryptDESKey.ForeColor = Color.Black;
            }
        }
        private void textEncryptDESData_TextChanged(object sender, EventArgs e)
        {
            lblEncryptDES4.Text = "【" + textEncryptDESData.TextLength + "字节】";
        }
        private void textEncryptDESKey_TextChanged(object sender, EventArgs e)
        {
            lblEncryptDES5.Text = "【" + textEncryptDESKey.TextLength / 2 + "字节】";
        }
        private void textEncryptDESResult_TextChanged(object sender, EventArgs e)
        {
            lblEncryptDES6.Text = "【" + textEncryptDESResult.TextLength + "字节】";
        }
        private void DES_Click(object sender, EventArgs e)
        {
            MyTools.SetDefaultText(textEncryptDESData, ConstValue.TEXT_DES_DATA);
            MyTools.SetDefaultText(textEncryptDESKey, ConstValue.TEXT_DES_KEY);
        }
        private void btnEncryptDES1_Click(object sender, EventArgs e)
        {
            textEncryptDESData.Text = string.Empty;
            textEncryptDESKey.Text = string.Empty;
            textEncryptDESResult.Text = string.Empty;
        }
        private void btnEncryptDES2_Click(object sender, EventArgs e)
        {
            byte[] bys = Encoding.UTF8.GetBytes(textEncryptDESData.Text);
            byte[] result = MyEnctypt.Encrypt(bys, textEncryptDESKey.Text);
            textEncryptDESResult.Text = MyTools.BytesToHexString(result);
        }

        /**********3DES****************************************************************/
        private void textEncryptTriDESData_MouseDown(object sender, EventArgs e)
        {
            if (this.textEncryptTriDESData.Text == ConstValue.TEXT_TRIDES_DATA)
            {
                textEncryptTriDESData.Text = string.Empty;
                textEncryptTriDESData.ForeColor = Color.Black;
            }
        }
        private void textEncryptTriDESKey_MouseDown(object sender, EventArgs e)
        {
            if (this.textEncryptTriDESKey.Text == ConstValue.TEXT_TRIDES_KEY)
            {
                textEncryptTriDESKey.Text = string.Empty;
                textEncryptTriDESKey.ForeColor = Color.Black;
            }
        }
        private void textEncryptTriDESData_TextChanged(object sender, EventArgs e)
        {
            lblEncryptTriDES4.Text = "【" + textEncryptTriDESData.TextLength + "字节】";
        }
        private void textEncryptTriDESKey_TextChanged(object sender, EventArgs e)
        {
            lblEncryptTriDES5.Text = "【" + textEncryptTriDESKey.TextLength / 2 + "字节】";
        }
        private void textEncryptTriDESResult_TextChanged(object sender, EventArgs e)
        {
            lblEncryptTriDES6.Text = "【" + textEncryptTriDESResult.TextLength + "字节】";
        }
        private void TriDES_Click(object sender, EventArgs e)
        {
            MyTools.SetDefaultText(textEncryptTriDESData, ConstValue.TEXT_TRIDES_DATA);
            MyTools.SetDefaultText(textEncryptTriDESKey, ConstValue.TEXT_TRIDES_KEY);
        }
        private void btnEncryptTriDES1_Click(object sender, EventArgs e)
        {
            textEncryptTriDESData.Text = string.Empty;
            textEncryptTriDESKey.Text = string.Empty;
            textEncryptTriDESResult.Text = string.Empty;
        }
        private void btnEncryptTriDES2_Click(object sender, EventArgs e)
        {
            textEncryptTriDESResult.Text = MyEnctypt.Get3DES(textEncryptTriDESData.Text, textEncryptTriDESKey.Text);
        }

        /**********3MAC****************************************************************/
        private void textEncryptTriMACData_MouseDown(object sender, EventArgs e)
        {
            if (this.textEncryptTriMACData.Text == ConstValue.TEXT_TRIMAC_DATA)
            {
                textEncryptTriMACData.Text = string.Empty;
                textEncryptTriMACData.ForeColor = Color.Black;
            }
        }
        private void textEncryptTriMACKey_MouseDown(object sender, EventArgs e)
        {
            if (this.textEncryptTriMACKey.Text == ConstValue.TEXT_TRIMAC_KEY)
            {
                textEncryptTriMACKey.Text = string.Empty;
                textEncryptTriMACKey.ForeColor = Color.Black;
            }
        }
        private void textEncryptTriMACData_TextChanged(object sender, EventArgs e)
        {
            lblEncryptTriMAC4.Text = "【" + textEncryptTriMACData.TextLength + "字节】";
        }
        private void textEncryptTriMACKey_TextChanged(object sender, EventArgs e)
        {
            lblEncryptTriMAC5.Text = "【" + textEncryptTriMACKey.TextLength / 2 + "字节】";
        }
        private void textEncryptTriMACResult_TextChanged(object sender, EventArgs e)
        {
            lblEncryptTriMAC6.Text = "【" + textEncryptTriMACResult.TextLength + "字节】";
        }
        private void TriMAC_Click(object sender, EventArgs e)
        {
            MyTools.SetDefaultText(textEncryptTriMACData, ConstValue.TEXT_TRIMAC_DATA);
            MyTools.SetDefaultText(textEncryptTriMACKey, ConstValue.TEXT_TRIMAC_KEY);
        }
        private void btnEncryptTriMAC1_Click(object sender, EventArgs e)
        {
            textEncryptTriMACData.Text = string.Empty;
            textEncryptTriMACKey.Text = string.Empty;
            textEncryptTriMACResult.Text = string.Empty;
        }
        private void btnEncryptTriMAC2_Click(object sender, EventArgs e)
        {
            textEncryptTriMACResult.Text = MyEnctypt.Get3Mac(textEncryptTriMACData.Text, textEncryptTriMACKey.Text);
        }

        private void EncryptForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
                return;
            }
        }
    }

    public class MyEnctypt
    {
        public static String Get3Mac(String srcStr, string key)
        {
            try
            {
                // 获取密钥
                string lKey = key.Substring(0, 16);
                string rKey = key.Substring(16, 16);

                // 初始值
                byte[] btIV = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                // 获取3DES加密后的结果
                // byte[] bys = MyTools.HexStringToBytes(srcStr);
                String strTemp = MyEnctypt.Get3DES(srcStr, key);// 该方法获取源数据UTF-8编码的byte,Hex编码的密钥,返回16进制字符串
                byte[] md5 = MyTools.HexStringToBytes(MyEnctypt.GetMD5(strTemp, 2));// 获取字符串的MD5值，1为UTF-8编码，2为Hex 

                byte[] bysTemp = new byte[8];                   // 临时数组
                byte[] bysTemp1 = new byte[8];                  // 临时数组

                Array.Copy(md5, 0, bysTemp, 0, 8);              // 将md5的前8个byte拷贝到bysTemp中
                byte[] bysTemp2 = DoXOR(bysTemp, btIV);         // 将前8个byte和初始值求异或

                for (int i = 1; i < md5.Length / 8; i++)        // 轮流DES加密、异或
                {
                    Array.Copy(Encrypt(bysTemp2, lKey), 0, bysTemp, 0, 8);      // 加密
                    Array.Copy(md5, i * 8, bysTemp1, 0, 8);                     // 获取下一组
                    Array.Copy(DoXOR(bysTemp, bysTemp1), 0, bysTemp2, 0, 8);    // 异或
                }

                byte[] tail = new byte[] { 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                Array.Copy(Encrypt(bysTemp2, lKey), 0, bysTemp, 0, 8);  // 加密
                Array.Copy(DoXOR(bysTemp, tail), 0, bysTemp2, 0, 8);    // 异或

                Array.Copy(Encrypt(bysTemp2, lKey), 0, bysTemp, 0, 8);  // 左8个字节密钥加密
                Array.Copy(Decrypt(bysTemp, rKey), 0, bysTemp2, 0, 8);  // 右8个字节密钥解密
                Array.Copy(Encrypt(bysTemp2, lKey), 0, bysTemp, 0, 8);  // 左8个字节密钥加密

                return MyTools.BytesToHexString(bysTemp);               // 返回16进制字符串
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "消息提示框");
            }

            return null;
        }

        public static byte[] Encrypt(byte[] inData, string key)
        {
            byte[] btKey = MyTools.HexStringToBytes(key);
            if (btKey == null)
                return null;
            // 初始向量
            byte[] btIV = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            try
            {
                // DES加密算法对象
                DES des = new DESCryptoServiceProvider();
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.None;
                des.BlockSize = 64;

                using (MemoryStream ms = new MemoryStream())
                {
                    // 获得报文的长度
                    int srcLen = inData.Length;
                    // 获得报文与8的倍数之差
                    int diff = 8 - srcLen % 8;
                    // 定义新报文的空间
                    byte[] bys = new byte[srcLen + diff];
                    Array.Copy(inData, bys, srcLen);
                    // 为报文的后面追加0x80、0x00
                    bys[srcLen] = 0x80;
                    for (int i = 0; i < diff - 1; i++)
                    {
                        bys[srcLen + i + 1] = 0x00;
                    }

                    try
                    {
                        using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(btKey, btIV), CryptoStreamMode.Write))
                        {
                            cs.Write(bys, 0, bys.Length);
                            cs.FlushFinalBlock();
                            cs.Close();
                        }
                        return ms.ToArray();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "消息提示框");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "消息提示框");
            }

            return null;
        }

        public static byte[] Decrypt(byte[] inData, string key)
        {
            // 密钥
            byte[] btKey = MyTools.HexStringToBytes(key);
            // 初始向量
            byte[] btIV = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            DES des = new DESCryptoServiceProvider();
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.None;
            des.BlockSize = 64;

            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(btKey, btIV), CryptoStreamMode.Write))
                    {
                        cs.Write(inData, 0, inData.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                    }
                    return ms.ToArray();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "消息提示框");
                }
            }
            return null;
        }

        // 获取源数据UTF-8编码的byte,Hex编码的密钥,返回16进制字符串
        public static String Get3DES(String strSrc, string key)
        {
            SymmetricAlgorithm tdes = new TripleDESCryptoServiceProvider();
            // 密钥
            tdes.Key = MyTools.HexStringToBytes(key);
            // 初始值
            tdes.IV = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            // 指定加密的运算模式
            tdes.Mode = System.Security.Cryptography.CipherMode.ECB;
            // 获取或设置加密算法的填充模式
            tdes.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            // 块大小
            tdes.BlockSize = 64;

            ICryptoTransform ct;
            System.IO.MemoryStream ms;
            CryptoStream cs;
            try
            {
                ct = tdes.CreateEncryptor(tdes.Key, tdes.IV);   // 创建加密对象

                byte[] byt = Encoding.UTF8.GetBytes(strSrc);     // 转换为byte数组
                int len = byt.Length;                           // 获取数组长度

                int diff = 8 - len % 8;                         // 距8的整数倍还差多少
                byte[] byt1 = new byte[len + diff];             // 定义大于byt的最小8的整数倍个空间

                Array.Copy(byt, 0, byt1, 0, byt.Length);        // 将与数据拷贝过去
                byt1[len] = 0x80;                               // 
                for (int j = 0; j < diff - 1; j++)
                {
                    byt1[len + j + 1] = 0x00;
                }

                ms = new System.IO.MemoryStream();
                cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
                cs.Write(byt1, 0, byt1.Length);
                cs.FlushFinalBlock();
                if (cs != null)
                {
                    cs.Close();
                }

                byte[] temp = ms.ToArray();
                byte[] result = new byte[temp.Length - 8];
                Array.Copy(temp, 0, result, 0, temp.Length - 8);

                return MyTools.BytesToHexString(result);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "消息提示框");
            }

            return null;
        }
        // 获取字符串的MD5值，1为UTF-8编码，2位Hex
        public static String GetMD5(String strSrc, int index)
        {
            try
            {
                if (strSrc == null)
                {
                    MessageBox.Show("输入数据不能为空！", "消息提示框");
                }

                byte[] byt = null;
                if (index == 1)
                {
                    byt = Encoding.UTF8.GetBytes(strSrc);
                }
                else if (index == 2)
                {
                    byt = MyTools.HexStringToBytes(strSrc);
                }

                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] result = md5.ComputeHash(byt);

                return MyTools.BytesToHexString(result);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "消息提示框");
            }

            return null;
        }

        private static byte[] DoXOR(byte[] bys1, byte[] bys2)
        {
            byte[] bys = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                bys[i] = (byte)(bys1[i] ^ bys2[i]);
            }

            return bys;
        }

    }
}

