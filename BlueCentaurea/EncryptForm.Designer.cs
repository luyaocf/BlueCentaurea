namespace BlueCentaurea
{
    partial class EncryptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrlEncrypt = new System.Windows.Forms.TabControl();
            this.tbpEncryptMD5 = new System.Windows.Forms.TabPage();
            this.raBtnHEX = new System.Windows.Forms.RadioButton();
            this.raBtnUTF8 = new System.Windows.Forms.RadioButton();
            this.btnEncryptMD52 = new System.Windows.Forms.Button();
            this.btnEncryptMD51 = new System.Windows.Forms.Button();
            this.lblEncryptMD54 = new System.Windows.Forms.Label();
            this.lblEncryptMD53 = new System.Windows.Forms.Label();
            this.textEncryptMD5Result = new System.Windows.Forms.TextBox();
            this.textEncryptMD5Data = new System.Windows.Forms.TextBox();
            this.lblEncryptMD52 = new System.Windows.Forms.Label();
            this.lblEncryptMD51 = new System.Windows.Forms.Label();
            this.tbpEncryptDES = new System.Windows.Forms.TabPage();
            this.lblEncryptDES6 = new System.Windows.Forms.Label();
            this.textEncryptDESResult = new System.Windows.Forms.TextBox();
            this.lblEncryptDES3 = new System.Windows.Forms.Label();
            this.btnEncryptDES2 = new System.Windows.Forms.Button();
            this.btnEncryptDES1 = new System.Windows.Forms.Button();
            this.lblEncryptDES5 = new System.Windows.Forms.Label();
            this.lblEncryptDES4 = new System.Windows.Forms.Label();
            this.textEncryptDESKey = new System.Windows.Forms.TextBox();
            this.textEncryptDESData = new System.Windows.Forms.TextBox();
            this.lblEncryptDES2 = new System.Windows.Forms.Label();
            this.lblEncryptDES1 = new System.Windows.Forms.Label();
            this.tbpEncryptTriDES = new System.Windows.Forms.TabPage();
            this.lblEncryptTriDES6 = new System.Windows.Forms.Label();
            this.textEncryptTriDESResult = new System.Windows.Forms.TextBox();
            this.lblEncryptTriDES3 = new System.Windows.Forms.Label();
            this.btmEncryptTriDES2 = new System.Windows.Forms.Button();
            this.btnEncryptTriDES1 = new System.Windows.Forms.Button();
            this.lblEncryptTriDES5 = new System.Windows.Forms.Label();
            this.lblEncryptTriDES4 = new System.Windows.Forms.Label();
            this.textEncryptTriDESKey = new System.Windows.Forms.TextBox();
            this.textEncryptTriDESData = new System.Windows.Forms.TextBox();
            this.lblEncryptTriDES2 = new System.Windows.Forms.Label();
            this.lblEncryptTriDES1 = new System.Windows.Forms.Label();
            this.tapEncryptTriMAC = new System.Windows.Forms.TabPage();
            this.lblEncryptTriMAC6 = new System.Windows.Forms.Label();
            this.textEncryptTriMACResult = new System.Windows.Forms.TextBox();
            this.lblEncryptTriMAC3 = new System.Windows.Forms.Label();
            this.btnEncryptTriMAC2 = new System.Windows.Forms.Button();
            this.btnEncryptTriMAC1 = new System.Windows.Forms.Button();
            this.lblEncryptTriMAC5 = new System.Windows.Forms.Label();
            this.lblEncryptTriMAC4 = new System.Windows.Forms.Label();
            this.textEncryptTriMACKey = new System.Windows.Forms.TextBox();
            this.textEncryptTriMACData = new System.Windows.Forms.TextBox();
            this.lblEncryptTriMAC2 = new System.Windows.Forms.Label();
            this.lblEncryptTriMAC1 = new System.Windows.Forms.Label();
            this.tabCtrlEncrypt.SuspendLayout();
            this.tbpEncryptMD5.SuspendLayout();
            this.tbpEncryptDES.SuspendLayout();
            this.tbpEncryptTriDES.SuspendLayout();
            this.tapEncryptTriMAC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlEncrypt
            // 
            this.tabCtrlEncrypt.Controls.Add(this.tbpEncryptMD5);
            this.tabCtrlEncrypt.Controls.Add(this.tbpEncryptDES);
            this.tabCtrlEncrypt.Controls.Add(this.tbpEncryptTriDES);
            this.tabCtrlEncrypt.Controls.Add(this.tapEncryptTriMAC);
            this.tabCtrlEncrypt.Location = new System.Drawing.Point(12, 3);
            this.tabCtrlEncrypt.Name = "tabCtrlEncrypt";
            this.tabCtrlEncrypt.SelectedIndex = 0;
            this.tabCtrlEncrypt.Size = new System.Drawing.Size(483, 285);
            this.tabCtrlEncrypt.TabIndex = 0;
            // 
            // tbpEncryptMD5
            // 
            this.tbpEncryptMD5.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpEncryptMD5.Controls.Add(this.raBtnHEX);
            this.tbpEncryptMD5.Controls.Add(this.raBtnUTF8);
            this.tbpEncryptMD5.Controls.Add(this.btnEncryptMD52);
            this.tbpEncryptMD5.Controls.Add(this.btnEncryptMD51);
            this.tbpEncryptMD5.Controls.Add(this.lblEncryptMD54);
            this.tbpEncryptMD5.Controls.Add(this.lblEncryptMD53);
            this.tbpEncryptMD5.Controls.Add(this.textEncryptMD5Result);
            this.tbpEncryptMD5.Controls.Add(this.textEncryptMD5Data);
            this.tbpEncryptMD5.Controls.Add(this.lblEncryptMD52);
            this.tbpEncryptMD5.Controls.Add(this.lblEncryptMD51);
            this.tbpEncryptMD5.Location = new System.Drawing.Point(4, 28);
            this.tbpEncryptMD5.Name = "tbpEncryptMD5";
            this.tbpEncryptMD5.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEncryptMD5.Size = new System.Drawing.Size(475, 253);
            this.tbpEncryptMD5.TabIndex = 0;
            this.tbpEncryptMD5.Text = "计算MD5";
            this.tbpEncryptMD5.Click += new System.EventHandler(this.MD5_Click);
            // 
            // raBtnHEX
            // 
            this.raBtnHEX.AutoSize = true;
            this.raBtnHEX.Checked = true;
            this.raBtnHEX.Location = new System.Drawing.Point(206, 13);
            this.raBtnHEX.Name = "raBtnHEX";
            this.raBtnHEX.Size = new System.Drawing.Size(54, 23);
            this.raBtnHEX.TabIndex = 17;
            this.raBtnHEX.TabStop = true;
            this.raBtnHEX.Text = "HEX";
            this.raBtnHEX.UseVisualStyleBackColor = true;
            // 
            // raBtnUTF8
            // 
            this.raBtnUTF8.AutoSize = true;
            this.raBtnUTF8.Location = new System.Drawing.Point(128, 13);
            this.raBtnUTF8.Name = "raBtnUTF8";
            this.raBtnUTF8.Size = new System.Drawing.Size(72, 23);
            this.raBtnUTF8.TabIndex = 16;
            this.raBtnUTF8.TabStop = true;
            this.raBtnUTF8.Text = "UTF-8";
            this.raBtnUTF8.UseVisualStyleBackColor = true;
            // 
            // btnEncryptMD52
            // 
            this.btnEncryptMD52.Location = new System.Drawing.Point(304, 185);
            this.btnEncryptMD52.Name = "btnEncryptMD52";
            this.btnEncryptMD52.Size = new System.Drawing.Size(75, 31);
            this.btnEncryptMD52.TabIndex = 15;
            this.btnEncryptMD52.Text = "计算";
            this.btnEncryptMD52.UseVisualStyleBackColor = true;
            this.btnEncryptMD52.Click += new System.EventHandler(this.btnEncryptMD52_Click);
            // 
            // btnEncryptMD51
            // 
            this.btnEncryptMD51.Location = new System.Drawing.Point(78, 185);
            this.btnEncryptMD51.Name = "btnEncryptMD51";
            this.btnEncryptMD51.Size = new System.Drawing.Size(75, 31);
            this.btnEncryptMD51.TabIndex = 14;
            this.btnEncryptMD51.Text = "清除";
            this.btnEncryptMD51.UseVisualStyleBackColor = true;
            this.btnEncryptMD51.Click += new System.EventHandler(this.btnEncryptMD51_Click);
            // 
            // lblEncryptMD54
            // 
            this.lblEncryptMD54.AutoSize = true;
            this.lblEncryptMD54.Location = new System.Drawing.Point(352, 107);
            this.lblEncryptMD54.Name = "lblEncryptMD54";
            this.lblEncryptMD54.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptMD54.TabIndex = 13;
            this.lblEncryptMD54.Text = "【0字节】";
            // 
            // lblEncryptMD53
            // 
            this.lblEncryptMD53.AutoSize = true;
            this.lblEncryptMD53.Location = new System.Drawing.Point(352, 45);
            this.lblEncryptMD53.Name = "lblEncryptMD53";
            this.lblEncryptMD53.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptMD53.TabIndex = 12;
            this.lblEncryptMD53.Text = "【0字节】";
            // 
            // textEncryptMD5Result
            // 
            this.textEncryptMD5Result.Location = new System.Drawing.Point(119, 104);
            this.textEncryptMD5Result.MaxLength = 327670;
            this.textEncryptMD5Result.Name = "textEncryptMD5Result";
            this.textEncryptMD5Result.Size = new System.Drawing.Size(227, 26);
            this.textEncryptMD5Result.TabIndex = 11;
            this.textEncryptMD5Result.TextChanged += new System.EventHandler(this.textEncryptMD5Result_TextChanged);
            // 
            // textEncryptMD5Data
            // 
            this.textEncryptMD5Data.Location = new System.Drawing.Point(119, 42);
            this.textEncryptMD5Data.MaxLength = 327670;
            this.textEncryptMD5Data.Name = "textEncryptMD5Data";
            this.textEncryptMD5Data.Size = new System.Drawing.Size(227, 26);
            this.textEncryptMD5Data.TabIndex = 10;
            this.textEncryptMD5Data.TextChanged += new System.EventHandler(this.textEncryptMD5Data_TextChanged);
            this.textEncryptMD5Data.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEncryptMD5Data_MouseDown);
            // 
            // lblEncryptMD52
            // 
            this.lblEncryptMD52.AutoSize = true;
            this.lblEncryptMD52.Location = new System.Drawing.Point(32, 107);
            this.lblEncryptMD52.Name = "lblEncryptMD52";
            this.lblEncryptMD52.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptMD52.TabIndex = 9;
            this.lblEncryptMD52.Text = "【结果】";
            // 
            // lblEncryptMD51
            // 
            this.lblEncryptMD51.AutoSize = true;
            this.lblEncryptMD51.Location = new System.Drawing.Point(32, 45);
            this.lblEncryptMD51.Name = "lblEncryptMD51";
            this.lblEncryptMD51.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptMD51.TabIndex = 8;
            this.lblEncryptMD51.Text = "【数据】";
            // 
            // tbpEncryptDES
            // 
            this.tbpEncryptDES.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpEncryptDES.Controls.Add(this.lblEncryptDES6);
            this.tbpEncryptDES.Controls.Add(this.textEncryptDESResult);
            this.tbpEncryptDES.Controls.Add(this.lblEncryptDES3);
            this.tbpEncryptDES.Controls.Add(this.btnEncryptDES2);
            this.tbpEncryptDES.Controls.Add(this.btnEncryptDES1);
            this.tbpEncryptDES.Controls.Add(this.lblEncryptDES5);
            this.tbpEncryptDES.Controls.Add(this.lblEncryptDES4);
            this.tbpEncryptDES.Controls.Add(this.textEncryptDESKey);
            this.tbpEncryptDES.Controls.Add(this.textEncryptDESData);
            this.tbpEncryptDES.Controls.Add(this.lblEncryptDES2);
            this.tbpEncryptDES.Controls.Add(this.lblEncryptDES1);
            this.tbpEncryptDES.Location = new System.Drawing.Point(4, 28);
            this.tbpEncryptDES.Name = "tbpEncryptDES";
            this.tbpEncryptDES.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEncryptDES.Size = new System.Drawing.Size(475, 253);
            this.tbpEncryptDES.TabIndex = 1;
            this.tbpEncryptDES.Text = "DES加密";
            this.tbpEncryptDES.Click += new System.EventHandler(this.DES_Click);
            // 
            // lblEncryptDES6
            // 
            this.lblEncryptDES6.AutoSize = true;
            this.lblEncryptDES6.Location = new System.Drawing.Point(349, 141);
            this.lblEncryptDES6.Name = "lblEncryptDES6";
            this.lblEncryptDES6.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptDES6.TabIndex = 18;
            this.lblEncryptDES6.Text = "【0字节】";
            // 
            // textEncryptDESResult
            // 
            this.textEncryptDESResult.Location = new System.Drawing.Point(116, 138);
            this.textEncryptDESResult.MaxLength = 327670;
            this.textEncryptDESResult.Multiline = true;
            this.textEncryptDESResult.Name = "textEncryptDESResult";
            this.textEncryptDESResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEncryptDESResult.Size = new System.Drawing.Size(227, 26);
            this.textEncryptDESResult.TabIndex = 17;
            this.textEncryptDESResult.TextChanged += new System.EventHandler(this.textEncryptDESResult_TextChanged);
            // 
            // lblEncryptDES3
            // 
            this.lblEncryptDES3.AutoSize = true;
            this.lblEncryptDES3.Location = new System.Drawing.Point(29, 141);
            this.lblEncryptDES3.Name = "lblEncryptDES3";
            this.lblEncryptDES3.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptDES3.TabIndex = 16;
            this.lblEncryptDES3.Text = "【结果】";
            // 
            // btnEncryptDES2
            // 
            this.btnEncryptDES2.Location = new System.Drawing.Point(301, 189);
            this.btnEncryptDES2.Name = "btnEncryptDES2";
            this.btnEncryptDES2.Size = new System.Drawing.Size(75, 31);
            this.btnEncryptDES2.TabIndex = 15;
            this.btnEncryptDES2.Text = "计算";
            this.btnEncryptDES2.UseVisualStyleBackColor = true;
            this.btnEncryptDES2.Click += new System.EventHandler(this.btnEncryptDES2_Click);
            // 
            // btnEncryptDES1
            // 
            this.btnEncryptDES1.Location = new System.Drawing.Point(75, 189);
            this.btnEncryptDES1.Name = "btnEncryptDES1";
            this.btnEncryptDES1.Size = new System.Drawing.Size(75, 31);
            this.btnEncryptDES1.TabIndex = 14;
            this.btnEncryptDES1.Text = "清除";
            this.btnEncryptDES1.UseVisualStyleBackColor = true;
            this.btnEncryptDES1.Click += new System.EventHandler(this.btnEncryptDES1_Click);
            // 
            // lblEncryptDES5
            // 
            this.lblEncryptDES5.AutoSize = true;
            this.lblEncryptDES5.Location = new System.Drawing.Point(349, 83);
            this.lblEncryptDES5.Name = "lblEncryptDES5";
            this.lblEncryptDES5.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptDES5.TabIndex = 13;
            this.lblEncryptDES5.Text = "【0字节】";
            // 
            // lblEncryptDES4
            // 
            this.lblEncryptDES4.AutoSize = true;
            this.lblEncryptDES4.Location = new System.Drawing.Point(349, 21);
            this.lblEncryptDES4.Name = "lblEncryptDES4";
            this.lblEncryptDES4.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptDES4.TabIndex = 12;
            this.lblEncryptDES4.Text = "【0字节】";
            // 
            // textEncryptDESKey
            // 
            this.textEncryptDESKey.Location = new System.Drawing.Point(116, 80);
            this.textEncryptDESKey.MaxLength = 16;
            this.textEncryptDESKey.Name = "textEncryptDESKey";
            this.textEncryptDESKey.Size = new System.Drawing.Size(227, 26);
            this.textEncryptDESKey.TabIndex = 11;
            this.textEncryptDESKey.TextChanged += new System.EventHandler(this.textEncryptDESKey_TextChanged);
            this.textEncryptDESKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEncryptDESKey_MouseDown);
            // 
            // textEncryptDESData
            // 
            this.textEncryptDESData.Location = new System.Drawing.Point(116, 18);
            this.textEncryptDESData.MaxLength = 327670;
            this.textEncryptDESData.Name = "textEncryptDESData";
            this.textEncryptDESData.Size = new System.Drawing.Size(227, 26);
            this.textEncryptDESData.TabIndex = 10;
            this.textEncryptDESData.TextChanged += new System.EventHandler(this.textEncryptDESData_TextChanged);
            this.textEncryptDESData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEncryptDESData_MouseDown);
            // 
            // lblEncryptDES2
            // 
            this.lblEncryptDES2.AutoSize = true;
            this.lblEncryptDES2.Location = new System.Drawing.Point(29, 83);
            this.lblEncryptDES2.Name = "lblEncryptDES2";
            this.lblEncryptDES2.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptDES2.TabIndex = 9;
            this.lblEncryptDES2.Text = "【密钥】";
            // 
            // lblEncryptDES1
            // 
            this.lblEncryptDES1.AutoSize = true;
            this.lblEncryptDES1.Location = new System.Drawing.Point(29, 21);
            this.lblEncryptDES1.Name = "lblEncryptDES1";
            this.lblEncryptDES1.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptDES1.TabIndex = 8;
            this.lblEncryptDES1.Text = "【数据】";
            // 
            // tbpEncryptTriDES
            // 
            this.tbpEncryptTriDES.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpEncryptTriDES.Controls.Add(this.lblEncryptTriDES6);
            this.tbpEncryptTriDES.Controls.Add(this.textEncryptTriDESResult);
            this.tbpEncryptTriDES.Controls.Add(this.lblEncryptTriDES3);
            this.tbpEncryptTriDES.Controls.Add(this.btmEncryptTriDES2);
            this.tbpEncryptTriDES.Controls.Add(this.btnEncryptTriDES1);
            this.tbpEncryptTriDES.Controls.Add(this.lblEncryptTriDES5);
            this.tbpEncryptTriDES.Controls.Add(this.lblEncryptTriDES4);
            this.tbpEncryptTriDES.Controls.Add(this.textEncryptTriDESKey);
            this.tbpEncryptTriDES.Controls.Add(this.textEncryptTriDESData);
            this.tbpEncryptTriDES.Controls.Add(this.lblEncryptTriDES2);
            this.tbpEncryptTriDES.Controls.Add(this.lblEncryptTriDES1);
            this.tbpEncryptTriDES.Location = new System.Drawing.Point(4, 28);
            this.tbpEncryptTriDES.Name = "tbpEncryptTriDES";
            this.tbpEncryptTriDES.Size = new System.Drawing.Size(475, 253);
            this.tbpEncryptTriDES.TabIndex = 2;
            this.tbpEncryptTriDES.Text = "3DES加密";
            this.tbpEncryptTriDES.Click += new System.EventHandler(this.TriDES_Click);
            // 
            // lblEncryptTriDES6
            // 
            this.lblEncryptTriDES6.AutoSize = true;
            this.lblEncryptTriDES6.Location = new System.Drawing.Point(350, 141);
            this.lblEncryptTriDES6.Name = "lblEncryptTriDES6";
            this.lblEncryptTriDES6.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptTriDES6.TabIndex = 29;
            this.lblEncryptTriDES6.Text = "【0字节】";
            // 
            // textEncryptTriDESResult
            // 
            this.textEncryptTriDESResult.Location = new System.Drawing.Point(117, 138);
            this.textEncryptTriDESResult.MaxLength = 327670;
            this.textEncryptTriDESResult.Multiline = true;
            this.textEncryptTriDESResult.Name = "textEncryptTriDESResult";
            this.textEncryptTriDESResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textEncryptTriDESResult.Size = new System.Drawing.Size(227, 26);
            this.textEncryptTriDESResult.TabIndex = 28;
            this.textEncryptTriDESResult.TextChanged += new System.EventHandler(this.textEncryptTriDESResult_TextChanged);
            // 
            // lblEncryptTriDES3
            // 
            this.lblEncryptTriDES3.AutoSize = true;
            this.lblEncryptTriDES3.Location = new System.Drawing.Point(30, 141);
            this.lblEncryptTriDES3.Name = "lblEncryptTriDES3";
            this.lblEncryptTriDES3.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptTriDES3.TabIndex = 27;
            this.lblEncryptTriDES3.Text = "【结果】";
            // 
            // btmEncryptTriDES2
            // 
            this.btmEncryptTriDES2.Location = new System.Drawing.Point(302, 189);
            this.btmEncryptTriDES2.Name = "btmEncryptTriDES2";
            this.btmEncryptTriDES2.Size = new System.Drawing.Size(75, 31);
            this.btmEncryptTriDES2.TabIndex = 26;
            this.btmEncryptTriDES2.Text = "计算";
            this.btmEncryptTriDES2.UseVisualStyleBackColor = true;
            this.btmEncryptTriDES2.Click += new System.EventHandler(this.btnEncryptTriDES2_Click);
            // 
            // btnEncryptTriDES1
            // 
            this.btnEncryptTriDES1.Location = new System.Drawing.Point(76, 189);
            this.btnEncryptTriDES1.Name = "btnEncryptTriDES1";
            this.btnEncryptTriDES1.Size = new System.Drawing.Size(75, 31);
            this.btnEncryptTriDES1.TabIndex = 25;
            this.btnEncryptTriDES1.Text = "清除";
            this.btnEncryptTriDES1.UseVisualStyleBackColor = true;
            this.btnEncryptTriDES1.Click += new System.EventHandler(this.btnEncryptTriDES1_Click);
            // 
            // lblEncryptTriDES5
            // 
            this.lblEncryptTriDES5.AutoSize = true;
            this.lblEncryptTriDES5.Location = new System.Drawing.Point(350, 83);
            this.lblEncryptTriDES5.Name = "lblEncryptTriDES5";
            this.lblEncryptTriDES5.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptTriDES5.TabIndex = 24;
            this.lblEncryptTriDES5.Text = "【0字节】";
            // 
            // lblEncryptTriDES4
            // 
            this.lblEncryptTriDES4.AutoSize = true;
            this.lblEncryptTriDES4.Location = new System.Drawing.Point(350, 21);
            this.lblEncryptTriDES4.Name = "lblEncryptTriDES4";
            this.lblEncryptTriDES4.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptTriDES4.TabIndex = 23;
            this.lblEncryptTriDES4.Text = "【0字节】";
            // 
            // textEncryptTriDESKey
            // 
            this.textEncryptTriDESKey.Location = new System.Drawing.Point(117, 80);
            this.textEncryptTriDESKey.MaxLength = 32;
            this.textEncryptTriDESKey.Name = "textEncryptTriDESKey";
            this.textEncryptTriDESKey.Size = new System.Drawing.Size(227, 26);
            this.textEncryptTriDESKey.TabIndex = 22;
            this.textEncryptTriDESKey.TextChanged += new System.EventHandler(this.textEncryptTriDESKey_TextChanged);
            this.textEncryptTriDESKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEncryptTriDESKey_MouseDown);
            // 
            // textEncryptTriDESData
            // 
            this.textEncryptTriDESData.Location = new System.Drawing.Point(117, 18);
            this.textEncryptTriDESData.MaxLength = 327670;
            this.textEncryptTriDESData.Name = "textEncryptTriDESData";
            this.textEncryptTriDESData.Size = new System.Drawing.Size(227, 26);
            this.textEncryptTriDESData.TabIndex = 21;
            this.textEncryptTriDESData.TextChanged += new System.EventHandler(this.textEncryptTriDESData_TextChanged);
            this.textEncryptTriDESData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEncryptTriDESData_MouseDown);
            // 
            // lblEncryptTriDES2
            // 
            this.lblEncryptTriDES2.AutoSize = true;
            this.lblEncryptTriDES2.Location = new System.Drawing.Point(30, 83);
            this.lblEncryptTriDES2.Name = "lblEncryptTriDES2";
            this.lblEncryptTriDES2.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptTriDES2.TabIndex = 20;
            this.lblEncryptTriDES2.Text = "【密钥】";
            // 
            // lblEncryptTriDES1
            // 
            this.lblEncryptTriDES1.AutoSize = true;
            this.lblEncryptTriDES1.Location = new System.Drawing.Point(30, 21);
            this.lblEncryptTriDES1.Name = "lblEncryptTriDES1";
            this.lblEncryptTriDES1.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptTriDES1.TabIndex = 19;
            this.lblEncryptTriDES1.Text = "【数据】";
            // 
            // tapEncryptTriMAC
            // 
            this.tapEncryptTriMAC.BackColor = System.Drawing.Color.SkyBlue;
            this.tapEncryptTriMAC.Controls.Add(this.lblEncryptTriMAC6);
            this.tapEncryptTriMAC.Controls.Add(this.textEncryptTriMACResult);
            this.tapEncryptTriMAC.Controls.Add(this.lblEncryptTriMAC3);
            this.tapEncryptTriMAC.Controls.Add(this.btnEncryptTriMAC2);
            this.tapEncryptTriMAC.Controls.Add(this.btnEncryptTriMAC1);
            this.tapEncryptTriMAC.Controls.Add(this.lblEncryptTriMAC5);
            this.tapEncryptTriMAC.Controls.Add(this.lblEncryptTriMAC4);
            this.tapEncryptTriMAC.Controls.Add(this.textEncryptTriMACKey);
            this.tapEncryptTriMAC.Controls.Add(this.textEncryptTriMACData);
            this.tapEncryptTriMAC.Controls.Add(this.lblEncryptTriMAC2);
            this.tapEncryptTriMAC.Controls.Add(this.lblEncryptTriMAC1);
            this.tapEncryptTriMAC.Location = new System.Drawing.Point(4, 28);
            this.tapEncryptTriMAC.Name = "tapEncryptTriMAC";
            this.tapEncryptTriMAC.Size = new System.Drawing.Size(475, 253);
            this.tapEncryptTriMAC.TabIndex = 3;
            this.tapEncryptTriMAC.Text = "计算3MAC";
            this.tapEncryptTriMAC.Click += new System.EventHandler(this.TriMAC_Click);
            // 
            // lblEncryptTriMAC6
            // 
            this.lblEncryptTriMAC6.AutoSize = true;
            this.lblEncryptTriMAC6.Location = new System.Drawing.Point(352, 141);
            this.lblEncryptTriMAC6.Name = "lblEncryptTriMAC6";
            this.lblEncryptTriMAC6.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptTriMAC6.TabIndex = 29;
            this.lblEncryptTriMAC6.Text = "【0字节】";
            // 
            // textEncryptTriMACResult
            // 
            this.textEncryptTriMACResult.Location = new System.Drawing.Point(119, 138);
            this.textEncryptTriMACResult.MaxLength = 327670;
            this.textEncryptTriMACResult.Name = "textEncryptTriMACResult";
            this.textEncryptTriMACResult.Size = new System.Drawing.Size(227, 26);
            this.textEncryptTriMACResult.TabIndex = 28;
            this.textEncryptTriMACResult.TextChanged += new System.EventHandler(this.textEncryptTriMACResult_TextChanged);
            // 
            // lblEncryptTriMAC3
            // 
            this.lblEncryptTriMAC3.AutoSize = true;
            this.lblEncryptTriMAC3.Location = new System.Drawing.Point(32, 141);
            this.lblEncryptTriMAC3.Name = "lblEncryptTriMAC3";
            this.lblEncryptTriMAC3.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptTriMAC3.TabIndex = 27;
            this.lblEncryptTriMAC3.Text = "【结果】";
            // 
            // btnEncryptTriMAC2
            // 
            this.btnEncryptTriMAC2.Location = new System.Drawing.Point(304, 189);
            this.btnEncryptTriMAC2.Name = "btnEncryptTriMAC2";
            this.btnEncryptTriMAC2.Size = new System.Drawing.Size(75, 31);
            this.btnEncryptTriMAC2.TabIndex = 26;
            this.btnEncryptTriMAC2.Text = "计算";
            this.btnEncryptTriMAC2.UseVisualStyleBackColor = true;
            this.btnEncryptTriMAC2.Click += new System.EventHandler(this.btnEncryptTriMAC2_Click);
            // 
            // btnEncryptTriMAC1
            // 
            this.btnEncryptTriMAC1.Location = new System.Drawing.Point(78, 189);
            this.btnEncryptTriMAC1.Name = "btnEncryptTriMAC1";
            this.btnEncryptTriMAC1.Size = new System.Drawing.Size(75, 31);
            this.btnEncryptTriMAC1.TabIndex = 25;
            this.btnEncryptTriMAC1.Text = "清除";
            this.btnEncryptTriMAC1.UseVisualStyleBackColor = true;
            this.btnEncryptTriMAC1.Click += new System.EventHandler(this.btnEncryptTriMAC1_Click);
            // 
            // lblEncryptTriMAC5
            // 
            this.lblEncryptTriMAC5.AutoSize = true;
            this.lblEncryptTriMAC5.Location = new System.Drawing.Point(352, 83);
            this.lblEncryptTriMAC5.Name = "lblEncryptTriMAC5";
            this.lblEncryptTriMAC5.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptTriMAC5.TabIndex = 24;
            this.lblEncryptTriMAC5.Text = "【0字节】";
            // 
            // lblEncryptTriMAC4
            // 
            this.lblEncryptTriMAC4.AutoSize = true;
            this.lblEncryptTriMAC4.Location = new System.Drawing.Point(352, 21);
            this.lblEncryptTriMAC4.Name = "lblEncryptTriMAC4";
            this.lblEncryptTriMAC4.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptTriMAC4.TabIndex = 23;
            this.lblEncryptTriMAC4.Text = "【0字节】";
            // 
            // textEncryptTriMACKey
            // 
            this.textEncryptTriMACKey.Location = new System.Drawing.Point(119, 80);
            this.textEncryptTriMACKey.MaxLength = 32;
            this.textEncryptTriMACKey.Name = "textEncryptTriMACKey";
            this.textEncryptTriMACKey.Size = new System.Drawing.Size(227, 26);
            this.textEncryptTriMACKey.TabIndex = 22;
            this.textEncryptTriMACKey.TextChanged += new System.EventHandler(this.textEncryptTriMACKey_TextChanged);
            this.textEncryptTriMACKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEncryptTriMACKey_MouseDown);
            // 
            // textEncryptTriMACData
            // 
            this.textEncryptTriMACData.Location = new System.Drawing.Point(119, 18);
            this.textEncryptTriMACData.MaxLength = 327670;
            this.textEncryptTriMACData.Name = "textEncryptTriMACData";
            this.textEncryptTriMACData.Size = new System.Drawing.Size(227, 26);
            this.textEncryptTriMACData.TabIndex = 21;
            this.textEncryptTriMACData.TextChanged += new System.EventHandler(this.textEncryptTriMACData_TextChanged);
            this.textEncryptTriMACData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEncryptTriMACData_MouseDown);
            // 
            // lblEncryptTriMAC2
            // 
            this.lblEncryptTriMAC2.AutoSize = true;
            this.lblEncryptTriMAC2.Location = new System.Drawing.Point(32, 83);
            this.lblEncryptTriMAC2.Name = "lblEncryptTriMAC2";
            this.lblEncryptTriMAC2.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptTriMAC2.TabIndex = 20;
            this.lblEncryptTriMAC2.Text = "【密钥】";
            // 
            // lblEncryptTriMAC1
            // 
            this.lblEncryptTriMAC1.AutoSize = true;
            this.lblEncryptTriMAC1.Location = new System.Drawing.Point(32, 21);
            this.lblEncryptTriMAC1.Name = "lblEncryptTriMAC1";
            this.lblEncryptTriMAC1.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptTriMAC1.TabIndex = 19;
            this.lblEncryptTriMAC1.Text = "【数据】";
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 300);
            this.Controls.Add(this.tabCtrlEncrypt);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EncryptForm";
            this.Text = "加密";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabCtrlEncrypt.ResumeLayout(false);
            this.tbpEncryptMD5.ResumeLayout(false);
            this.tbpEncryptMD5.PerformLayout();
            this.tbpEncryptDES.ResumeLayout(false);
            this.tbpEncryptDES.PerformLayout();
            this.tbpEncryptTriDES.ResumeLayout(false);
            this.tbpEncryptTriDES.PerformLayout();
            this.tapEncryptTriMAC.ResumeLayout(false);
            this.tapEncryptTriMAC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlEncrypt;
        private System.Windows.Forms.TabPage tbpEncryptMD5;
        private System.Windows.Forms.TabPage tbpEncryptDES;
        private System.Windows.Forms.TabPage tbpEncryptTriDES;
        private System.Windows.Forms.TabPage tapEncryptTriMAC;
        private System.Windows.Forms.Label lblEncryptDES6;
        private System.Windows.Forms.TextBox textEncryptDESResult;
        private System.Windows.Forms.Label lblEncryptDES3;
        private System.Windows.Forms.Button btnEncryptDES2;
        private System.Windows.Forms.Button btnEncryptDES1;
        private System.Windows.Forms.Label lblEncryptDES5;
        private System.Windows.Forms.Label lblEncryptDES4;
        private System.Windows.Forms.TextBox textEncryptDESKey;
        private System.Windows.Forms.TextBox textEncryptDESData;
        private System.Windows.Forms.Label lblEncryptDES2;
        private System.Windows.Forms.Label lblEncryptDES1;
        private System.Windows.Forms.Button btnEncryptMD52;
        private System.Windows.Forms.Button btnEncryptMD51;
        private System.Windows.Forms.Label lblEncryptMD54;
        private System.Windows.Forms.Label lblEncryptMD53;
        private System.Windows.Forms.TextBox textEncryptMD5Result;
        private System.Windows.Forms.TextBox textEncryptMD5Data;
        private System.Windows.Forms.Label lblEncryptMD52;
        private System.Windows.Forms.Label lblEncryptMD51;
        private System.Windows.Forms.Label lblEncryptTriDES6;
        private System.Windows.Forms.TextBox textEncryptTriDESResult;
        private System.Windows.Forms.Label lblEncryptTriDES3;
        private System.Windows.Forms.Button btmEncryptTriDES2;
        private System.Windows.Forms.Button btnEncryptTriDES1;
        private System.Windows.Forms.Label lblEncryptTriDES5;
        private System.Windows.Forms.Label lblEncryptTriDES4;
        private System.Windows.Forms.TextBox textEncryptTriDESKey;
        private System.Windows.Forms.TextBox textEncryptTriDESData;
        private System.Windows.Forms.Label lblEncryptTriDES2;
        private System.Windows.Forms.Label lblEncryptTriDES1;
        private System.Windows.Forms.Label lblEncryptTriMAC6;
        private System.Windows.Forms.TextBox textEncryptTriMACResult;
        private System.Windows.Forms.Label lblEncryptTriMAC3;
        private System.Windows.Forms.Button btnEncryptTriMAC2;
        private System.Windows.Forms.Button btnEncryptTriMAC1;
        private System.Windows.Forms.Label lblEncryptTriMAC5;
        private System.Windows.Forms.Label lblEncryptTriMAC4;
        private System.Windows.Forms.TextBox textEncryptTriMACKey;
        private System.Windows.Forms.TextBox textEncryptTriMACData;
        private System.Windows.Forms.Label lblEncryptTriMAC2;
        private System.Windows.Forms.Label lblEncryptTriMAC1;
        private System.Windows.Forms.RadioButton raBtnHEX;
        private System.Windows.Forms.RadioButton raBtnUTF8;
    }
}