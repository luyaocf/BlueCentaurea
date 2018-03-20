namespace BlueCentaurea
{
    partial class CheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForm));
            this.tbpCheckSHA1 = new System.Windows.Forms.TabPage();
            this.txtBoxCheckResultSHA1 = new System.Windows.Forms.TextBox();
            this.txtBoxCheckSelectSHA1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckSelectSHA1 = new System.Windows.Forms.Button();
            this.btnCheckResultSHA1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpCheckMD5 = new System.Windows.Forms.TabPage();
            this.textBoxCheckResultMD5 = new System.Windows.Forms.TextBox();
            this.txtBoxCheckSelectMD5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckSelectMD5 = new System.Windows.Forms.Button();
            this.btnCheckResultMD5 = new System.Windows.Forms.Button();
            this.lblEncryptMD52 = new System.Windows.Forms.Label();
            this.tabCtrlCheck = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbpCalcStrLen = new System.Windows.Forms.TabPage();
            this.textBoxUTF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGB2312 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGBK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUnicode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelUtf = new System.Windows.Forms.Label();
            this.labelGB2312 = new System.Windows.Forms.Label();
            this.labelGBK = new System.Windows.Forms.Label();
            this.labelUnicode = new System.Windows.Forms.Label();
            this.tbpCheckSHA1.SuspendLayout();
            this.tbpCheckMD5.SuspendLayout();
            this.tabCtrlCheck.SuspendLayout();
            this.tbpCalcStrLen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpCheckSHA1
            // 
            this.tbpCheckSHA1.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpCheckSHA1.Controls.Add(this.txtBoxCheckResultSHA1);
            this.tbpCheckSHA1.Controls.Add(this.txtBoxCheckSelectSHA1);
            this.tbpCheckSHA1.Controls.Add(this.label2);
            this.tbpCheckSHA1.Controls.Add(this.btnCheckSelectSHA1);
            this.tbpCheckSHA1.Controls.Add(this.btnCheckResultSHA1);
            this.tbpCheckSHA1.Controls.Add(this.label3);
            this.tbpCheckSHA1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCheckSHA1.Location = new System.Drawing.Point(4, 28);
            this.tbpCheckSHA1.Name = "tbpCheckSHA1";
            this.tbpCheckSHA1.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckSHA1.Size = new System.Drawing.Size(500, 245);
            this.tbpCheckSHA1.TabIndex = 1;
            this.tbpCheckSHA1.Text = "校验SHA1";
            // 
            // txtBoxCheckResultSHA1
            // 
            this.txtBoxCheckResultSHA1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCheckResultSHA1.Location = new System.Drawing.Point(125, 139);
            this.txtBoxCheckResultSHA1.MaxLength = 327670;
            this.txtBoxCheckResultSHA1.Name = "txtBoxCheckResultSHA1";
            this.txtBoxCheckResultSHA1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCheckResultSHA1.Size = new System.Drawing.Size(214, 26);
            this.txtBoxCheckResultSHA1.TabIndex = 26;
            // 
            // txtBoxCheckSelectSHA1
            // 
            this.txtBoxCheckSelectSHA1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCheckSelectSHA1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxCheckSelectSHA1.Location = new System.Drawing.Point(125, 47);
            this.txtBoxCheckSelectSHA1.MaxLength = 327670;
            this.txtBoxCheckSelectSHA1.Name = "txtBoxCheckSelectSHA1";
            this.txtBoxCheckSelectSHA1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCheckSelectSHA1.Size = new System.Drawing.Size(214, 26);
            this.txtBoxCheckSelectSHA1.TabIndex = 25;
            this.txtBoxCheckSelectSHA1.Text = "选择文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "【文件】";
            // 
            // btnCheckSelectSHA1
            // 
            this.btnCheckSelectSHA1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSelectSHA1.Location = new System.Drawing.Point(362, 46);
            this.btnCheckSelectSHA1.Name = "btnCheckSelectSHA1";
            this.btnCheckSelectSHA1.Size = new System.Drawing.Size(75, 31);
            this.btnCheckSelectSHA1.TabIndex = 23;
            this.btnCheckSelectSHA1.Text = "浏览";
            this.btnCheckSelectSHA1.UseVisualStyleBackColor = true;
            this.btnCheckSelectSHA1.Click += new System.EventHandler(this.btnCheckSelectSHA1_Click);
            // 
            // btnCheckResultSHA1
            // 
            this.btnCheckResultSHA1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckResultSHA1.Location = new System.Drawing.Point(362, 138);
            this.btnCheckResultSHA1.Name = "btnCheckResultSHA1";
            this.btnCheckResultSHA1.Size = new System.Drawing.Size(75, 31);
            this.btnCheckResultSHA1.TabIndex = 21;
            this.btnCheckResultSHA1.Text = "计算";
            this.btnCheckResultSHA1.UseVisualStyleBackColor = true;
            this.btnCheckResultSHA1.Click += new System.EventHandler(this.btnCheckResultSHA1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "【结果】";
            // 
            // tbpCheckMD5
            // 
            this.tbpCheckMD5.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpCheckMD5.Controls.Add(this.textBoxCheckResultMD5);
            this.tbpCheckMD5.Controls.Add(this.txtBoxCheckSelectMD5);
            this.tbpCheckMD5.Controls.Add(this.label1);
            this.tbpCheckMD5.Controls.Add(this.btnCheckSelectMD5);
            this.tbpCheckMD5.Controls.Add(this.btnCheckResultMD5);
            this.tbpCheckMD5.Controls.Add(this.lblEncryptMD52);
            this.tbpCheckMD5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCheckMD5.Location = new System.Drawing.Point(4, 28);
            this.tbpCheckMD5.Name = "tbpCheckMD5";
            this.tbpCheckMD5.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckMD5.Size = new System.Drawing.Size(500, 245);
            this.tbpCheckMD5.TabIndex = 0;
            this.tbpCheckMD5.Text = "校验MD5";
            // 
            // textBoxCheckResultMD5
            // 
            this.textBoxCheckResultMD5.Location = new System.Drawing.Point(130, 127);
            this.textBoxCheckResultMD5.MaxLength = 327670;
            this.textBoxCheckResultMD5.Multiline = true;
            this.textBoxCheckResultMD5.Name = "textBoxCheckResultMD5";
            this.textBoxCheckResultMD5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCheckResultMD5.Size = new System.Drawing.Size(199, 47);
            this.textBoxCheckResultMD5.TabIndex = 20;
            // 
            // txtBoxCheckSelectMD5
            // 
            this.txtBoxCheckSelectMD5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxCheckSelectMD5.Location = new System.Drawing.Point(130, 49);
            this.txtBoxCheckSelectMD5.MaxLength = 327670;
            this.txtBoxCheckSelectMD5.Name = "txtBoxCheckSelectMD5";
            this.txtBoxCheckSelectMD5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCheckSelectMD5.Size = new System.Drawing.Size(199, 26);
            this.txtBoxCheckSelectMD5.TabIndex = 19;
            this.txtBoxCheckSelectMD5.Text = "选择文件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "【文件】";
            // 
            // btnCheckSelectMD5
            // 
            this.btnCheckSelectMD5.Location = new System.Drawing.Point(357, 46);
            this.btnCheckSelectMD5.Name = "btnCheckSelectMD5";
            this.btnCheckSelectMD5.Size = new System.Drawing.Size(75, 31);
            this.btnCheckSelectMD5.TabIndex = 16;
            this.btnCheckSelectMD5.Text = "浏览";
            this.btnCheckSelectMD5.UseVisualStyleBackColor = true;
            this.btnCheckSelectMD5.Click += new System.EventHandler(this.btnCheckSelect_Click);
            // 
            // btnCheckResultMD5
            // 
            this.btnCheckResultMD5.Location = new System.Drawing.Point(357, 136);
            this.btnCheckResultMD5.Name = "btnCheckResultMD5";
            this.btnCheckResultMD5.Size = new System.Drawing.Size(75, 31);
            this.btnCheckResultMD5.TabIndex = 4;
            this.btnCheckResultMD5.Text = "计算";
            this.btnCheckResultMD5.UseVisualStyleBackColor = true;
            this.btnCheckResultMD5.Click += new System.EventHandler(this.btnCheckMD5_Click);
            // 
            // lblEncryptMD52
            // 
            this.lblEncryptMD52.AutoSize = true;
            this.lblEncryptMD52.Location = new System.Drawing.Point(33, 142);
            this.lblEncryptMD52.Name = "lblEncryptMD52";
            this.lblEncryptMD52.Size = new System.Drawing.Size(81, 19);
            this.lblEncryptMD52.TabIndex = 9;
            this.lblEncryptMD52.Text = "【结果】";
            // 
            // tabCtrlCheck
            // 
            this.tabCtrlCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlCheck.Controls.Add(this.tbpCheckMD5);
            this.tabCtrlCheck.Controls.Add(this.tbpCheckSHA1);
            this.tabCtrlCheck.Controls.Add(this.tbpCalcStrLen);
            this.tabCtrlCheck.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlCheck.Location = new System.Drawing.Point(12, 3);
            this.tabCtrlCheck.Name = "tabCtrlCheck";
            this.tabCtrlCheck.SelectedIndex = 0;
            this.tabCtrlCheck.Size = new System.Drawing.Size(508, 277);
            this.tabCtrlCheck.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // tbpCalcStrLen
            // 
            this.tbpCalcStrLen.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpCalcStrLen.Controls.Add(this.labelUnicode);
            this.tbpCalcStrLen.Controls.Add(this.labelGBK);
            this.tbpCalcStrLen.Controls.Add(this.labelGB2312);
            this.tbpCalcStrLen.Controls.Add(this.labelUtf);
            this.tbpCalcStrLen.Controls.Add(this.textBoxUnicode);
            this.tbpCalcStrLen.Controls.Add(this.label7);
            this.tbpCalcStrLen.Controls.Add(this.textBoxGBK);
            this.tbpCalcStrLen.Controls.Add(this.label6);
            this.tbpCalcStrLen.Controls.Add(this.textBoxGB2312);
            this.tbpCalcStrLen.Controls.Add(this.label5);
            this.tbpCalcStrLen.Controls.Add(this.textBoxUTF);
            this.tbpCalcStrLen.Controls.Add(this.label4);
            this.tbpCalcStrLen.Location = new System.Drawing.Point(4, 28);
            this.tbpCalcStrLen.Name = "tbpCalcStrLen";
            this.tbpCalcStrLen.Size = new System.Drawing.Size(500, 245);
            this.tbpCalcStrLen.TabIndex = 2;
            this.tbpCalcStrLen.Text = "长度计算";
            this.tbpCalcStrLen.Click += new System.EventHandler(this.tbpCalcStrLen_Click);
            // 
            // textBoxUTF
            // 
            this.textBoxUTF.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUTF.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUTF.Location = new System.Drawing.Point(132, 21);
            this.textBoxUTF.MaxLength = 327670;
            this.textBoxUTF.Name = "textBoxUTF";
            this.textBoxUTF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUTF.Size = new System.Drawing.Size(214, 26);
            this.textBoxUTF.TabIndex = 27;
            this.textBoxUTF.TextChanged += new System.EventHandler(this.textBoxUTF_TextChanged);
            this.textBoxUTF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxUTF_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "【 UTF-8 】";
            // 
            // textBoxGB2312
            // 
            this.textBoxGB2312.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGB2312.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxGB2312.Location = new System.Drawing.Point(132, 63);
            this.textBoxGB2312.MaxLength = 327670;
            this.textBoxGB2312.Name = "textBoxGB2312";
            this.textBoxGB2312.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGB2312.Size = new System.Drawing.Size(214, 26);
            this.textBoxGB2312.TabIndex = 29;
            this.textBoxGB2312.TextChanged += new System.EventHandler(this.textBoxGB2312_TextChanged);
            this.textBoxGB2312.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxGB2312_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "【 GB2312】";
            // 
            // textBoxGBK
            // 
            this.textBoxGBK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGBK.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxGBK.Location = new System.Drawing.Point(132, 105);
            this.textBoxGBK.MaxLength = 327670;
            this.textBoxGBK.Name = "textBoxGBK";
            this.textBoxGBK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGBK.Size = new System.Drawing.Size(214, 26);
            this.textBoxGBK.TabIndex = 31;
            this.textBoxGBK.TextChanged += new System.EventHandler(this.textBoxGBK_TextChanged);
            this.textBoxGBK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxGBK_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "【  GBK  】";
            // 
            // textBoxUnicode
            // 
            this.textBoxUnicode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnicode.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxUnicode.Location = new System.Drawing.Point(132, 145);
            this.textBoxUnicode.MaxLength = 327670;
            this.textBoxUnicode.Name = "textBoxUnicode";
            this.textBoxUnicode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxUnicode.Size = new System.Drawing.Size(214, 26);
            this.textBoxUnicode.TabIndex = 33;
            this.textBoxUnicode.TextChanged += new System.EventHandler(this.textBoxUnicode_TextChanged);
            this.textBoxUnicode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxUnicode_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "【Unicode】";
            // 
            // labelUtf
            // 
            this.labelUtf.AutoSize = true;
            this.labelUtf.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtf.Location = new System.Drawing.Point(352, 24);
            this.labelUtf.Name = "labelUtf";
            this.labelUtf.Size = new System.Drawing.Size(90, 19);
            this.labelUtf.TabIndex = 34;
            this.labelUtf.Text = "【0字节】";
            // 
            // labelGB2312
            // 
            this.labelGB2312.AutoSize = true;
            this.labelGB2312.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGB2312.Location = new System.Drawing.Point(352, 66);
            this.labelGB2312.Name = "labelGB2312";
            this.labelGB2312.Size = new System.Drawing.Size(90, 19);
            this.labelGB2312.TabIndex = 35;
            this.labelGB2312.Text = "【0字节】";
            // 
            // labelGBK
            // 
            this.labelGBK.AutoSize = true;
            this.labelGBK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGBK.Location = new System.Drawing.Point(352, 108);
            this.labelGBK.Name = "labelGBK";
            this.labelGBK.Size = new System.Drawing.Size(90, 19);
            this.labelGBK.TabIndex = 36;
            this.labelGBK.Text = "【0字节】";
            // 
            // labelUnicode
            // 
            this.labelUnicode.AutoSize = true;
            this.labelUnicode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnicode.Location = new System.Drawing.Point(352, 148);
            this.labelUnicode.Name = "labelUnicode";
            this.labelUnicode.Size = new System.Drawing.Size(90, 19);
            this.labelUnicode.TabIndex = 37;
            this.labelUnicode.Text = "【0字节】";
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 292);
            this.Controls.Add(this.tabCtrlCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CheckForm";
            this.Text = "文件校验";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckForm_KeyPress);
            this.tbpCheckSHA1.ResumeLayout(false);
            this.tbpCheckSHA1.PerformLayout();
            this.tbpCheckMD5.ResumeLayout(false);
            this.tbpCheckMD5.PerformLayout();
            this.tabCtrlCheck.ResumeLayout(false);
            this.tbpCalcStrLen.ResumeLayout(false);
            this.tbpCalcStrLen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpCheckSHA1;
        private System.Windows.Forms.TabPage tbpCheckMD5;
        private System.Windows.Forms.Button btnCheckResultMD5;
        private System.Windows.Forms.Label lblEncryptMD52;
        private System.Windows.Forms.TabControl tabCtrlCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckSelectMD5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxCheckResultMD5;
        private System.Windows.Forms.TextBox txtBoxCheckSelectMD5;
        private System.Windows.Forms.TextBox txtBoxCheckResultSHA1;
        private System.Windows.Forms.TextBox txtBoxCheckSelectSHA1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckSelectSHA1;
        private System.Windows.Forms.Button btnCheckResultSHA1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbpCalcStrLen;
        private System.Windows.Forms.TextBox textBoxUnicode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGBK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGB2312;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUTF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUnicode;
        private System.Windows.Forms.Label labelGBK;
        private System.Windows.Forms.Label labelGB2312;
        private System.Windows.Forms.Label labelUtf;
    }
}