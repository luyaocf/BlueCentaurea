namespace BlueCentaurea
{
    partial class HTTPForm
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
            this.label27 = new System.Windows.Forms.Label();
            this.textSendRegion1 = new System.Windows.Forms.RichTextBox();
            this.textSendRegion2 = new System.Windows.Forms.RichTextBox();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSendRegion2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.combBPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBoxServerRecv = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonServerStart = new System.Windows.Forms.Button();
            this.richTextBoxServerSend = new System.Windows.Forms.RichTextBox();
            this.richTextBoxServerAddress = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(566, 153);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 15);
            this.label27.TabIndex = 2;
            this.label27.Text = "l";
            // 
            // textSendRegion1
            // 
            this.textSendRegion1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textSendRegion1.Location = new System.Drawing.Point(168, 18);
            this.textSendRegion1.Name = "textSendRegion1";
            this.textSendRegion1.Size = new System.Drawing.Size(534, 24);
            this.textSendRegion1.TabIndex = 3;
            this.textSendRegion1.Text = "";
            // 
            // textSendRegion2
            // 
            this.textSendRegion2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSendRegion2.Location = new System.Drawing.Point(75, 48);
            this.textSendRegion2.Name = "textSendRegion2";
            this.textSendRegion2.Size = new System.Drawing.Size(627, 181);
            this.textSendRegion2.TabIndex = 4;
            this.textSendRegion2.Text = "";
            // 
            // btnSend1
            // 
            this.btnSend1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSend1.ForeColor = System.Drawing.Color.Green;
            this.btnSend1.Location = new System.Drawing.Point(708, 17);
            this.btnSend1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(46, 22);
            this.btnSend1.TabIndex = 12;
            this.btnSend1.Text = "发送";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // btnSendRegion2
            // 
            this.btnSendRegion2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSendRegion2.ForeColor = System.Drawing.Color.Red;
            this.btnSendRegion2.Location = new System.Drawing.Point(708, 65);
            this.btnSendRegion2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendRegion2.Name = "btnSendRegion2";
            this.btnSendRegion2.Size = new System.Drawing.Size(46, 22);
            this.btnSendRegion2.TabIndex = 16;
            this.btnSendRegion2.Text = "清空";
            this.btnSendRegion2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.combBPortName);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btnSendRegion2);
            this.groupBox5.Controls.Add(this.btnSend1);
            this.groupBox5.Controls.Add(this.textSendRegion2);
            this.groupBox5.Controls.Add(this.textSendRegion1);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 13);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(760, 236);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HTTP模拟浏览器";
            // 
            // combBPortName
            // 
            this.combBPortName.DropDownWidth = 106;
            this.combBPortName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combBPortName.FormattingEnabled = true;
            this.combBPortName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combBPortName.IntegralHeight = false;
            this.combBPortName.ItemHeight = 15;
            this.combBPortName.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.combBPortName.Location = new System.Drawing.Point(75, 18);
            this.combBPortName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combBPortName.MaxDropDownItems = 20;
            this.combBPortName.Name = "combBPortName";
            this.combBPortName.Size = new System.Drawing.Size(74, 23);
            this.combBPortName.TabIndex = 19;
            this.combBPortName.Text = "GET";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "【回复】";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "【请求】";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.richTextBoxServerRecv);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.buttonServerStart);
            this.groupBox3.Controls.Add(this.richTextBoxServerSend);
            this.groupBox3.Controls.Add(this.richTextBoxServerAddress);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 257);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(760, 225);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HTTP模拟服务器";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "【接收】";
            // 
            // richTextBoxServerRecv
            // 
            this.richTextBoxServerRecv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxServerRecv.Location = new System.Drawing.Point(75, 78);
            this.richTextBoxServerRecv.Name = "richTextBoxServerRecv";
            this.richTextBoxServerRecv.Size = new System.Drawing.Size(627, 139);
            this.richTextBoxServerRecv.TabIndex = 19;
            this.richTextBoxServerRecv.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "【回复】";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "【地址】";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(708, 146);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 22);
            this.button5.TabIndex = 16;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonServerStart
            // 
            this.buttonServerStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServerStart.ForeColor = System.Drawing.Color.Green;
            this.buttonServerStart.Location = new System.Drawing.Point(708, 17);
            this.buttonServerStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonServerStart.Name = "buttonServerStart";
            this.buttonServerStart.Size = new System.Drawing.Size(46, 22);
            this.buttonServerStart.TabIndex = 12;
            this.buttonServerStart.Text = "启动";
            this.buttonServerStart.UseVisualStyleBackColor = true;
            this.buttonServerStart.Click += new System.EventHandler(this.buttonServerStart_Click);
            // 
            // richTextBoxServerSend
            // 
            this.richTextBoxServerSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxServerSend.Location = new System.Drawing.Point(75, 48);
            this.richTextBoxServerSend.Name = "richTextBoxServerSend";
            this.richTextBoxServerSend.Size = new System.Drawing.Size(627, 24);
            this.richTextBoxServerSend.TabIndex = 4;
            this.richTextBoxServerSend.Text = "";
            // 
            // richTextBoxServerAddress
            // 
            this.richTextBoxServerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxServerAddress.Location = new System.Drawing.Point(75, 18);
            this.richTextBoxServerAddress.Name = "richTextBoxServerAddress";
            this.richTextBoxServerAddress.Size = new System.Drawing.Size(627, 24);
            this.richTextBoxServerAddress.TabIndex = 3;
            this.richTextBoxServerAddress.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(566, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "l";
            // 
            // HTTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HTTPForm";
            this.Text = "HTTPForm";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label27;
        internal System.Windows.Forms.RichTextBox textSendRegion1;
        internal System.Windows.Forms.RichTextBox textSendRegion2;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSendRegion2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combBPortName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonServerStart;
        internal System.Windows.Forms.RichTextBox richTextBoxServerSend;
        internal System.Windows.Forms.RichTextBox richTextBoxServerAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.RichTextBox richTextBoxServerRecv;
    }
}