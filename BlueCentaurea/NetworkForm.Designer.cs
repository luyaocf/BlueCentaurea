namespace BlueCentaurea
{
    partial class NetworkForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabtnServer = new System.Windows.Forms.RadioButton();
            this.rabtnClient = new System.Windows.Forms.RadioButton();
            this.raBtnUDP = new System.Windows.Forms.RadioButton();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textMultiFunc = new System.Windows.Forms.TextBox();
            this.textLocalhost = new System.Windows.Forms.TextBox();
            this.lblMultiFunc = new System.Windows.Forms.Label();
            this.lblLocalhost = new System.Windows.Forms.Label();
            this.lblProtocol = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRecvClr = new System.Windows.Forms.Button();
            this.chkbPause = new System.Windows.Forms.CheckBox();
            this.chkbRecvTime = new System.Windows.Forms.CheckBox();
            this.chkbHEX = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSendClr = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textSendInterval = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkbSendLoop = new System.Windows.Forms.CheckBox();
            this.chkbSendHEX = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textRecvRegion = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textSendRegion = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxOnline = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabtnServer);
            this.groupBox1.Controls.Add(this.rabtnClient);
            this.groupBox1.Controls.Add(this.raBtnUDP);
            this.groupBox1.Controls.Add(this.lblConnectStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.textMultiFunc);
            this.groupBox1.Controls.Add(this.textLocalhost);
            this.groupBox1.Controls.Add(this.lblMultiFunc);
            this.groupBox1.Controls.Add(this.lblLocalhost);
            this.groupBox1.Controls.Add(this.lblProtocol);
            this.groupBox1.Location = new System.Drawing.Point(4, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "网络设置";
            // 
            // rabtnServer
            // 
            this.rabtnServer.AutoSize = true;
            this.rabtnServer.Checked = true;
            this.rabtnServer.Location = new System.Drawing.Point(243, 21);
            this.rabtnServer.Name = "rabtnServer";
            this.rabtnServer.Size = new System.Drawing.Size(81, 23);
            this.rabtnServer.TabIndex = 19;
            this.rabtnServer.TabStop = true;
            this.rabtnServer.Text = "Server";
            this.rabtnServer.UseVisualStyleBackColor = true;
            this.rabtnServer.CheckedChanged += new System.EventHandler(this.rabtnServer_CheckedChanged);
            // 
            // rabtnClient
            // 
            this.rabtnClient.AutoSize = true;
            this.rabtnClient.Location = new System.Drawing.Point(151, 21);
            this.rabtnClient.Name = "rabtnClient";
            this.rabtnClient.Size = new System.Drawing.Size(81, 23);
            this.rabtnClient.TabIndex = 18;
            this.rabtnClient.Text = "Client";
            this.rabtnClient.UseVisualStyleBackColor = true;
            this.rabtnClient.CheckedChanged += new System.EventHandler(this.rabtnClient_CheckedChanged);
            // 
            // raBtnUDP
            // 
            this.raBtnUDP.AutoSize = true;
            this.raBtnUDP.Location = new System.Drawing.Point(83, 21);
            this.raBtnUDP.Name = "raBtnUDP";
            this.raBtnUDP.Size = new System.Drawing.Size(54, 23);
            this.raBtnUDP.TabIndex = 17;
            this.raBtnUDP.Text = "UDP";
            this.raBtnUDP.UseVisualStyleBackColor = true;
            this.raBtnUDP.CheckedChanged += new System.EventHandler(this.raBtnUDP_CheckedChanged);
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.AutoSize = true;
            this.lblConnectStatus.BackColor = System.Drawing.Color.SkyBlue;
            this.lblConnectStatus.Image = global::BlueCentaurea.Properties.Resources.LightOff;
            this.lblConnectStatus.Location = new System.Drawing.Point(257, 65);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(18, 19);
            this.lblConnectStatus.TabIndex = 14;
            this.lblConnectStatus.Text = " ";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(281, 55);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(55, 39);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textMultiFunc
            // 
            this.textMultiFunc.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMultiFunc.ForeColor = System.Drawing.Color.Red;
            this.textMultiFunc.Location = new System.Drawing.Point(104, 76);
            this.textMultiFunc.Multiline = true;
            this.textMultiFunc.Name = "textMultiFunc";
            this.textMultiFunc.Size = new System.Drawing.Size(143, 22);
            this.textMultiFunc.TabIndex = 3;
            // 
            // textLocalhost
            // 
            this.textLocalhost.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLocalhost.ForeColor = System.Drawing.Color.Red;
            this.textLocalhost.Location = new System.Drawing.Point(104, 50);
            this.textLocalhost.Multiline = true;
            this.textLocalhost.Name = "textLocalhost";
            this.textLocalhost.Size = new System.Drawing.Size(143, 21);
            this.textLocalhost.TabIndex = 3;
            // 
            // lblMultiFunc
            // 
            this.lblMultiFunc.AutoSize = true;
            this.lblMultiFunc.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblMultiFunc.Location = new System.Drawing.Point(7, 79);
            this.lblMultiFunc.Name = "lblMultiFunc";
            this.lblMultiFunc.Size = new System.Drawing.Size(91, 15);
            this.lblMultiFunc.TabIndex = 2;
            this.lblMultiFunc.Text = "本地主机端口";
            // 
            // lblLocalhost
            // 
            this.lblLocalhost.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblLocalhost.Location = new System.Drawing.Point(7, 51);
            this.lblLocalhost.Name = "lblLocalhost";
            this.lblLocalhost.Size = new System.Drawing.Size(95, 15);
            this.lblLocalhost.TabIndex = 1;
            this.lblLocalhost.Text = "本地主机地址";
            // 
            // lblProtocol
            // 
            this.lblProtocol.AutoSize = true;
            this.lblProtocol.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.lblProtocol.Location = new System.Drawing.Point(7, 26);
            this.lblProtocol.Name = "lblProtocol";
            this.lblProtocol.Size = new System.Drawing.Size(70, 15);
            this.lblProtocol.TabIndex = 0;
            this.lblProtocol.Text = "协议类型:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRecvClr);
            this.groupBox2.Controls.Add(this.chkbPause);
            this.groupBox2.Controls.Add(this.chkbRecvTime);
            this.groupBox2.Controls.Add(this.chkbHEX);
            this.groupBox2.Location = new System.Drawing.Point(352, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收区设置";
            // 
            // btnRecvClr
            // 
            this.btnRecvClr.ForeColor = System.Drawing.Color.Red;
            this.btnRecvClr.Location = new System.Drawing.Point(148, 37);
            this.btnRecvClr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecvClr.Name = "btnRecvClr";
            this.btnRecvClr.Size = new System.Drawing.Size(75, 29);
            this.btnRecvClr.TabIndex = 12;
            this.btnRecvClr.Text = "清空";
            this.btnRecvClr.UseVisualStyleBackColor = true;
            this.btnRecvClr.Click += new System.EventHandler(this.btnRecvClr_Click);
            // 
            // chkbPause
            // 
            this.chkbPause.AutoSize = true;
            this.chkbPause.Location = new System.Drawing.Point(6, 75);
            this.chkbPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbPause.Name = "chkbPause";
            this.chkbPause.Size = new System.Drawing.Size(136, 23);
            this.chkbPause.TabIndex = 3;
            this.chkbPause.Text = "暂停接收显示";
            this.chkbPause.UseVisualStyleBackColor = true;
            // 
            // chkbRecvTime
            // 
            this.chkbRecvTime.AutoSize = true;
            this.chkbRecvTime.Location = new System.Drawing.Point(6, 51);
            this.chkbRecvTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbRecvTime.Name = "chkbRecvTime";
            this.chkbRecvTime.Size = new System.Drawing.Size(136, 23);
            this.chkbRecvTime.TabIndex = 2;
            this.chkbRecvTime.Text = "显示接收时间";
            this.chkbRecvTime.UseVisualStyleBackColor = true;
            // 
            // chkbHEX
            // 
            this.chkbHEX.AutoSize = true;
            this.chkbHEX.Location = new System.Drawing.Point(6, 26);
            this.chkbHEX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbHEX.Name = "chkbHEX";
            this.chkbHEX.Size = new System.Drawing.Size(136, 23);
            this.chkbHEX.TabIndex = 1;
            this.chkbHEX.Text = "十六进制显示";
            this.chkbHEX.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSendClr);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textSendInterval);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.chkbSendLoop);
            this.groupBox3.Controls.Add(this.chkbSendHEX);
            this.groupBox3.Location = new System.Drawing.Point(589, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 102);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送区设置";
            // 
            // btnSendClr
            // 
            this.btnSendClr.ForeColor = System.Drawing.Color.Red;
            this.btnSendClr.Location = new System.Drawing.Point(157, 65);
            this.btnSendClr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendClr.Name = "btnSendClr";
            this.btnSendClr.Size = new System.Drawing.Size(75, 29);
            this.btnSendClr.TabIndex = 11;
            this.btnSendClr.Text = "清空";
            this.btnSendClr.UseVisualStyleBackColor = true;
            this.btnSendClr.Click += new System.EventHandler(this.btnSendClr_Click);
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.Color.Green;
            this.btnSend.Location = new System.Drawing.Point(157, 26);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 29);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F);
            this.label4.Location = new System.Drawing.Point(120, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "ms";
            // 
            // textSendInterval
            // 
            this.textSendInterval.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textSendInterval.Location = new System.Drawing.Point(47, 66);
            this.textSendInterval.Multiline = true;
            this.textSendInterval.Name = "textSendInterval";
            this.textSendInterval.Size = new System.Drawing.Size(67, 22);
            this.textSendInterval.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9F);
            this.label12.Location = new System.Drawing.Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 14);
            this.label12.TabIndex = 4;
            this.label12.Text = "间隔";
            // 
            // chkbSendLoop
            // 
            this.chkbSendLoop.AutoSize = true;
            this.chkbSendLoop.Location = new System.Drawing.Point(9, 40);
            this.chkbSendLoop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbSendLoop.Name = "chkbSendLoop";
            this.chkbSendLoop.Size = new System.Drawing.Size(100, 23);
            this.chkbSendLoop.TabIndex = 3;
            this.chkbSendLoop.Text = "循环发送";
            this.chkbSendLoop.UseVisualStyleBackColor = true;
            // 
            // chkbSendHEX
            // 
            this.chkbSendHEX.AutoSize = true;
            this.chkbSendHEX.Location = new System.Drawing.Point(9, 18);
            this.chkbSendHEX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkbSendHEX.Name = "chkbSendHEX";
            this.chkbSendHEX.Size = new System.Drawing.Size(118, 23);
            this.chkbSendHEX.TabIndex = 2;
            this.chkbSendHEX.Text = "16进制发送";
            this.chkbSendHEX.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textRecvRegion);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(655, 198);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // textRecvRegion
            // 
            this.textRecvRegion.Location = new System.Drawing.Point(7, 18);
            this.textRecvRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textRecvRegion.MaxLength = 327670;
            this.textRecvRegion.Multiline = true;
            this.textRecvRegion.Name = "textRecvRegion";
            this.textRecvRegion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRecvRegion.Size = new System.Drawing.Size(640, 172);
            this.textRecvRegion.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.textSendRegion);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 208);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(655, 99);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
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
            // textSendRegion
            // 
            this.textSendRegion.Location = new System.Drawing.Point(6, 24);
            this.textSendRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSendRegion.MaxLength = 327670;
            this.textSendRegion.Multiline = true;
            this.textSendRegion.Name = "textSendRegion";
            this.textSendRegion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSendRegion.Size = new System.Drawing.Size(640, 67);
            this.textSendRegion.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBoxOnline);
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(664, 2);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(167, 305);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "在线列表";
            // 
            // listBoxOnline
            // 
            this.listBoxOnline.FormattingEnabled = true;
            this.listBoxOnline.ItemHeight = 15;
            this.listBoxOnline.Location = new System.Drawing.Point(6, 23);
            this.listBoxOnline.Name = "listBoxOnline";
            this.listBoxOnline.Size = new System.Drawing.Size(155, 274);
            this.listBoxOnline.TabIndex = 13;
            // 
            // NetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(843, 431);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NetworkForm";
            this.Text = "网络调试助手";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NetworkForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMultiFunc;
        private System.Windows.Forms.Label lblLocalhost;
        private System.Windows.Forms.Label lblProtocol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblConnectStatus;
        private System.Windows.Forms.Button btnSendClr;
        private System.Windows.Forms.Button btnRecvClr;
        private System.Windows.Forms.CheckBox chkbPause;
        private System.Windows.Forms.CheckBox chkbRecvTime;
        private System.Windows.Forms.CheckBox chkbHEX;
        private System.Windows.Forms.CheckBox chkbSendLoop;
        private System.Windows.Forms.CheckBox chkbSendHEX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSendInterval;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        internal System.Windows.Forms.RadioButton rabtnServer;
        internal System.Windows.Forms.RadioButton rabtnClient;
        internal System.Windows.Forms.RadioButton raBtnUDP;
        internal System.Windows.Forms.TextBox textLocalhost;
        internal System.Windows.Forms.TextBox textMultiFunc;
        internal System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.TextBox textRecvRegion;
        public System.Windows.Forms.TextBox textSendRegion;
        public System.Windows.Forms.ListBox listBoxOnline;


    }
}