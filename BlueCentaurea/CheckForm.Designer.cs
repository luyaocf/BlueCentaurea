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
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxCheckResultSHA1 = new System.Windows.Forms.TextBox();
            this.txtBoxCheckSelectSHA1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckSelectSHA1 = new System.Windows.Forms.Button();
            this.btnCheckResultSHA1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpCheckMD5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMD5Path01 = new System.Windows.Forms.TextBox();
            this.textMD5Result01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckMD5Execute01 = new System.Windows.Forms.Button();
            this.lblEncryptMD52 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textMD5Path02 = new System.Windows.Forms.TextBox();
            this.textMD5Result02 = new System.Windows.Forms.TextBox();
            this.btnCheckMD5Execute02 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabCtrlCheck = new System.Windows.Forms.TabControl();
            this.tbpCalcSHA2 = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbpCheckSHA1.SuspendLayout();
            this.tbpCheckMD5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabCtrlCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpCheckSHA1
            // 
            this.tbpCheckSHA1.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpCheckSHA1.Controls.Add(this.label10);
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
            this.tbpCheckSHA1.Size = new System.Drawing.Size(607, 342);
            this.tbpCheckSHA1.TabIndex = 1;
            this.tbpCheckSHA1.Text = "校验SHA1";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(3, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(351, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "注意：大文件计算会很慢(3G大约需要30秒)";
            // 
            // txtBoxCheckResultSHA1
            // 
            this.txtBoxCheckResultSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCheckResultSHA1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCheckResultSHA1.Location = new System.Drawing.Point(113, 194);
            this.txtBoxCheckResultSHA1.MaxLength = 327670;
            this.txtBoxCheckResultSHA1.Name = "txtBoxCheckResultSHA1";
            this.txtBoxCheckResultSHA1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCheckResultSHA1.Size = new System.Drawing.Size(355, 26);
            this.txtBoxCheckResultSHA1.TabIndex = 26;
            // 
            // txtBoxCheckSelectSHA1
            // 
            this.txtBoxCheckSelectSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCheckSelectSHA1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCheckSelectSHA1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxCheckSelectSHA1.Location = new System.Drawing.Point(113, 92);
            this.txtBoxCheckSelectSHA1.MaxLength = 327670;
            this.txtBoxCheckSelectSHA1.Name = "txtBoxCheckSelectSHA1";
            this.txtBoxCheckSelectSHA1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxCheckSelectSHA1.Size = new System.Drawing.Size(355, 26);
            this.txtBoxCheckSelectSHA1.TabIndex = 25;
            this.txtBoxCheckSelectSHA1.Text = "选择文件";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "【文件】";
            // 
            // btnCheckSelectSHA1
            // 
            this.btnCheckSelectSHA1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCheckSelectSHA1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSelectSHA1.Location = new System.Drawing.Point(491, 90);
            this.btnCheckSelectSHA1.Name = "btnCheckSelectSHA1";
            this.btnCheckSelectSHA1.Size = new System.Drawing.Size(75, 31);
            this.btnCheckSelectSHA1.TabIndex = 23;
            this.btnCheckSelectSHA1.Text = "浏览";
            this.btnCheckSelectSHA1.UseVisualStyleBackColor = true;
            this.btnCheckSelectSHA1.Click += new System.EventHandler(this.btnCheckSelectSHA1_Click);
            // 
            // btnCheckResultSHA1
            // 
            this.btnCheckResultSHA1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCheckResultSHA1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckResultSHA1.Location = new System.Drawing.Point(491, 192);
            this.btnCheckResultSHA1.Name = "btnCheckResultSHA1";
            this.btnCheckResultSHA1.Size = new System.Drawing.Size(75, 31);
            this.btnCheckResultSHA1.TabIndex = 21;
            this.btnCheckResultSHA1.Text = "计算";
            this.btnCheckResultSHA1.UseVisualStyleBackColor = true;
            this.btnCheckResultSHA1.Click += new System.EventHandler(this.btnCheckResultSHA1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "【结果】";
            // 
            // tbpCheckMD5
            // 
            this.tbpCheckMD5.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpCheckMD5.Controls.Add(this.groupBox1);
            this.tbpCheckMD5.Controls.Add(this.groupBox2);
            this.tbpCheckMD5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCheckMD5.Location = new System.Drawing.Point(4, 28);
            this.tbpCheckMD5.Name = "tbpCheckMD5";
            this.tbpCheckMD5.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCheckMD5.Size = new System.Drawing.Size(607, 342);
            this.tbpCheckMD5.TabIndex = 0;
            this.tbpCheckMD5.Text = "校验MD5";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textMD5Path01);
            this.groupBox1.Controls.Add(this.textMD5Result01);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCheckMD5Execute01);
            this.groupBox1.Controls.Add(this.lblEncryptMD52);
            this.groupBox1.Location = new System.Drawing.Point(25, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 106);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算区1";
            // 
            // textMD5Path01
            // 
            this.textMD5Path01.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMD5Path01.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textMD5Path01.Location = new System.Drawing.Point(104, 25);
            this.textMD5Path01.Name = "textMD5Path01";
            this.textMD5Path01.Size = new System.Drawing.Size(358, 26);
            this.textMD5Path01.TabIndex = 25;
            this.textMD5Path01.Text = "浏览文件. . .";
            this.textMD5Path01.Click += new System.EventHandler(this.textMD5Path01_Click);
            // 
            // textMD5Result01
            // 
            this.textMD5Result01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textMD5Result01.Location = new System.Drawing.Point(104, 63);
            this.textMD5Result01.Name = "textMD5Result01";
            this.textMD5Result01.Size = new System.Drawing.Size(358, 26);
            this.textMD5Result01.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "【文件1】";
            // 
            // btnCheckMD5Execute01
            // 
            this.btnCheckMD5Execute01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckMD5Execute01.Location = new System.Drawing.Point(479, 47);
            this.btnCheckMD5Execute01.Name = "btnCheckMD5Execute01";
            this.btnCheckMD5Execute01.Size = new System.Drawing.Size(75, 31);
            this.btnCheckMD5Execute01.TabIndex = 4;
            this.btnCheckMD5Execute01.Text = "计算";
            this.btnCheckMD5Execute01.UseVisualStyleBackColor = true;
            this.btnCheckMD5Execute01.Click += new System.EventHandler(this.btnCheckMD5Execute01_Click);
            // 
            // lblEncryptMD52
            // 
            this.lblEncryptMD52.AutoSize = true;
            this.lblEncryptMD52.Location = new System.Drawing.Point(8, 66);
            this.lblEncryptMD52.Name = "lblEncryptMD52";
            this.lblEncryptMD52.Size = new System.Drawing.Size(90, 19);
            this.lblEncryptMD52.TabIndex = 9;
            this.lblEncryptMD52.Text = "【结果1】";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textMD5Path02);
            this.groupBox2.Controls.Add(this.textMD5Result02);
            this.groupBox2.Controls.Add(this.btnCheckMD5Execute02);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(25, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 101);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "计算区2";
            // 
            // textMD5Path02
            // 
            this.textMD5Path02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textMD5Path02.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textMD5Path02.Location = new System.Drawing.Point(104, 19);
            this.textMD5Path02.Name = "textMD5Path02";
            this.textMD5Path02.Size = new System.Drawing.Size(358, 26);
            this.textMD5Path02.TabIndex = 25;
            this.textMD5Path02.Text = "浏览文件. . .";
            this.textMD5Path02.Click += new System.EventHandler(this.textMD5Path02_Click);
            // 
            // textMD5Result02
            // 
            this.textMD5Result02.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMD5Result02.Location = new System.Drawing.Point(104, 63);
            this.textMD5Result02.Name = "textMD5Result02";
            this.textMD5Result02.Size = new System.Drawing.Size(358, 26);
            this.textMD5Result02.TabIndex = 25;
            // 
            // btnCheckMD5Execute02
            // 
            this.btnCheckMD5Execute02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckMD5Execute02.Location = new System.Drawing.Point(479, 32);
            this.btnCheckMD5Execute02.Name = "btnCheckMD5Execute02";
            this.btnCheckMD5Execute02.Size = new System.Drawing.Size(75, 31);
            this.btnCheckMD5Execute02.TabIndex = 23;
            this.btnCheckMD5Execute02.Text = "计算";
            this.btnCheckMD5Execute02.UseVisualStyleBackColor = true;
            this.btnCheckMD5Execute02.Click += new System.EventHandler(this.btnCheckMD5Execute02_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "【结果2】";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "【文件2】";
            // 
            // tabCtrlCheck
            // 
            this.tabCtrlCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlCheck.Controls.Add(this.tbpCheckMD5);
            this.tabCtrlCheck.Controls.Add(this.tbpCheckSHA1);
            this.tabCtrlCheck.Controls.Add(this.tbpCalcSHA2);
            this.tabCtrlCheck.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlCheck.Location = new System.Drawing.Point(12, 3);
            this.tabCtrlCheck.Name = "tabCtrlCheck";
            this.tabCtrlCheck.SelectedIndex = 0;
            this.tabCtrlCheck.Size = new System.Drawing.Size(615, 374);
            this.tabCtrlCheck.TabIndex = 1;
            // 
            // tbpCalcSHA2
            // 
            this.tbpCalcSHA2.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpCalcSHA2.Location = new System.Drawing.Point(4, 28);
            this.tbpCalcSHA2.Name = "tbpCalcSHA2";
            this.tbpCalcSHA2.Size = new System.Drawing.Size(607, 342);
            this.tbpCalcSHA2.TabIndex = 2;
            this.tbpCalcSHA2.Text = "待开发";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.InitialDirectory = "C:\\";
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 389);
            this.Controls.Add(this.tabCtrlCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckForm";
            this.Text = "文件校验";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckForm_KeyPress);
            this.tbpCheckSHA1.ResumeLayout(false);
            this.tbpCheckSHA1.PerformLayout();
            this.tbpCheckMD5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabCtrlCheck.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpCheckSHA1;
        private System.Windows.Forms.TabPage tbpCheckMD5;
        private System.Windows.Forms.TabControl tabCtrlCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtBoxCheckResultSHA1;
        private System.Windows.Forms.TextBox txtBoxCheckSelectSHA1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckSelectSHA1;
        private System.Windows.Forms.Button btnCheckResultSHA1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbpCalcSHA2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckMD5Execute01;
        private System.Windows.Forms.Label lblEncryptMD52;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCheckMD5Execute02;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMD5Result01;
        private System.Windows.Forms.TextBox textMD5Result02;
        private System.Windows.Forms.TextBox textMD5Path01;
        private System.Windows.Forms.TextBox textMD5Path02;
        private System.Windows.Forms.Label label10;
    }
}