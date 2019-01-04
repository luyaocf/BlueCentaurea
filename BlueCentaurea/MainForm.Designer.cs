namespace BlueCentaurea
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.transToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进制转换为GB2312ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gB2312转换为16进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进制转换为ASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCII转换为16进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delBlankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBlankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strLenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算MD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES加密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.计算MACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contectUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBlueCentaureaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.httpTest = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dES解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES解密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transToolStripMenuItem
            // 
            this.transToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进制转换为GB2312ToolStripMenuItem,
            this.gB2312转换为16进制ToolStripMenuItem,
            this.进制转换为ASCIIToolStripMenuItem,
            this.aSCII转换为16进制ToolStripMenuItem,
            this.delBlankToolStripMenuItem,
            this.addBlankToolStripMenuItem});
            this.transToolStripMenuItem.Name = "transToolStripMenuItem";
            this.transToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.transToolStripMenuItem.Text = "编码转换(&T)";
            // 
            // 进制转换为GB2312ToolStripMenuItem
            // 
            this.进制转换为GB2312ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.进制转换为GB2312ToolStripMenuItem.Name = "进制转换为GB2312ToolStripMenuItem";
            this.进制转换为GB2312ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.进制转换为GB2312ToolStripMenuItem.Text = "HEX --> 汉字(&H)";
            this.进制转换为GB2312ToolStripMenuItem.ToolTipText = "把【16进制】字符串转换为【GBK编码】的汉字";
            this.进制转换为GB2312ToolStripMenuItem.Click += new System.EventHandler(this.Hex2GB2312ToolStripMenuItem_Click);
            // 
            // gB2312转换为16进制ToolStripMenuItem
            // 
            this.gB2312转换为16进制ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.gB2312转换为16进制ToolStripMenuItem.Name = "gB2312转换为16进制ToolStripMenuItem";
            this.gB2312转换为16进制ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.gB2312转换为16进制ToolStripMenuItem.Text = "汉字 --> HEX(G)";
            this.gB2312转换为16进制ToolStripMenuItem.ToolTipText = "把【中文】转换为【16进制】字符串";
            this.gB2312转换为16进制ToolStripMenuItem.Click += new System.EventHandler(this.GB2312ToHexToolStripMenuItem_Click);
            // 
            // 进制转换为ASCIIToolStripMenuItem
            // 
            this.进制转换为ASCIIToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.进制转换为ASCIIToolStripMenuItem.Name = "进制转换为ASCIIToolStripMenuItem";
            this.进制转换为ASCIIToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.进制转换为ASCIIToolStripMenuItem.Text = "HEX --> ASC(&X)";
            this.进制转换为ASCIIToolStripMenuItem.ToolTipText = "把【16进制】字符串转换为【ASCII码】";
            this.进制转换为ASCIIToolStripMenuItem.Click += new System.EventHandler(this.Hex2ASCII_ToolStripMenuItem_Click);
            // 
            // aSCII转换为16进制ToolStripMenuItem
            // 
            this.aSCII转换为16进制ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.aSCII转换为16进制ToolStripMenuItem.Name = "aSCII转换为16进制ToolStripMenuItem";
            this.aSCII转换为16进制ToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.aSCII转换为16进制ToolStripMenuItem.Text = "ASC --> HEX(&A)";
            this.aSCII转换为16进制ToolStripMenuItem.ToolTipText = "把【ASCII码】转换为【16进制】字符串";
            this.aSCII转换为16进制ToolStripMenuItem.Click += new System.EventHandler(this.ASCII2Hex_ToolStripMenuItem_Click);
            // 
            // delBlankToolStripMenuItem
            // 
            this.delBlankToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.delBlankToolStripMenuItem.Name = "delBlankToolStripMenuItem";
            this.delBlankToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.delBlankToolStripMenuItem.Text = "增添空格(&B)";
            this.delBlankToolStripMenuItem.ToolTipText = "【删除】一段字符串中的空格";
            this.delBlankToolStripMenuItem.Click += new System.EventHandler(this.hex2UTF8ToolStripMenuItem_Click);
            // 
            // addBlankToolStripMenuItem
            // 
            this.addBlankToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.addBlankToolStripMenuItem.Name = "addBlankToolStripMenuItem";
            this.addBlankToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.addBlankToolStripMenuItem.Text = "进制转换(&R)";
            this.addBlankToolStripMenuItem.ToolTipText = "按【指定步距】给一段字符串添加空格";
            this.addBlankToolStripMenuItem.Click += new System.EventHandler(this.uTF82HexToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mD5ToolStripMenuItem,
            this.sHA1ToolStripMenuItem,
            this.strLenToolStripMenuItem});
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.checkToolStripMenuItem.Text = "文件校验(&C)";
            // 
            // mD5ToolStripMenuItem
            // 
            this.mD5ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.校验;
            this.mD5ToolStripMenuItem.Name = "mD5ToolStripMenuItem";
            this.mD5ToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.mD5ToolStripMenuItem.Text = "MD5(&M)";
            this.mD5ToolStripMenuItem.ToolTipText = "计算一个文件的【MD5】";
            this.mD5ToolStripMenuItem.Click += new System.EventHandler(this.mD5ToolStripMenuItem_Click);
            // 
            // sHA1ToolStripMenuItem
            // 
            this.sHA1ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.校验1;
            this.sHA1ToolStripMenuItem.Name = "sHA1ToolStripMenuItem";
            this.sHA1ToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.sHA1ToolStripMenuItem.Text = "SHA(&S)";
            this.sHA1ToolStripMenuItem.Click += new System.EventHandler(this.sHA1ToolStripMenuItem_Click);
            // 
            // strLenToolStripMenuItem
            // 
            this.strLenToolStripMenuItem.Name = "strLenToolStripMenuItem";
            this.strLenToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.strLenToolStripMenuItem.Text = "待开发(&L)";
            this.strLenToolStripMenuItem.Click += new System.EventHandler(this.calcStrLenToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算MD5ToolStripMenuItem,
            this.dES加密ToolStripMenuItem,
            this.dES加密ToolStripMenuItem1,
            this.计算MACToolStripMenuItem,
            this.dES解密ToolStripMenuItem,
            this.dES解密ToolStripMenuItem1});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.encryptToolStripMenuItem.Text = "加密解密(&E)";
            // 
            // 计算MD5ToolStripMenuItem
            // 
            this.计算MD5ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.加密;
            this.计算MD5ToolStripMenuItem.Name = "计算MD5ToolStripMenuItem";
            this.计算MD5ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.计算MD5ToolStripMenuItem.Text = "计算MD5(&M)";
            this.计算MD5ToolStripMenuItem.Click += new System.EventHandler(this.MD5_ToolStripMenuItem_Click);
            // 
            // dES加密ToolStripMenuItem
            // 
            this.dES加密ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.加密;
            this.dES加密ToolStripMenuItem.Name = "dES加密ToolStripMenuItem";
            this.dES加密ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.dES加密ToolStripMenuItem.Text = "DES加密(&D)";
            this.dES加密ToolStripMenuItem.Click += new System.EventHandler(this.DES_ToolStripMenuItem_Click);
            // 
            // dES加密ToolStripMenuItem1
            // 
            this.dES加密ToolStripMenuItem1.Image = global::BlueCentaurea.Properties.Resources.加密;
            this.dES加密ToolStripMenuItem1.Name = "dES加密ToolStripMenuItem1";
            this.dES加密ToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.dES加密ToolStripMenuItem1.Text = "3DES加密(&T)";
            this.dES加密ToolStripMenuItem1.Click += new System.EventHandler(this.TriDES_ToolStripMenuItem1_Click);
            // 
            // 计算MACToolStripMenuItem
            // 
            this.计算MACToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.加密;
            this.计算MACToolStripMenuItem.Name = "计算MACToolStripMenuItem";
            this.计算MACToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.计算MACToolStripMenuItem.Text = "计算3MAC(&C)";
            this.计算MACToolStripMenuItem.Click += new System.EventHandler(this.TriMac_ToolStripMenuItem_Click);
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.serialToolStripMenuItem.Text = "串口调试(&S)";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.Serial_ToolStripMenuItem_Click);
            // 
            // netToolStripMenuItem
            // 
            this.netToolStripMenuItem.Name = "netToolStripMenuItem";
            this.netToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.netToolStripMenuItem.Text = "网络调试(&N)";
            this.netToolStripMenuItem.Click += new System.EventHandler(this.Network_ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchHelpToolStripMenuItem,
            this.contectUsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.aboutBlueCentaureaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.helpToolStripMenuItem.Text = "帮助(&H)";
            // 
            // watchHelpToolStripMenuItem
            // 
            this.watchHelpToolStripMenuItem.Name = "watchHelpToolStripMenuItem";
            this.watchHelpToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.watchHelpToolStripMenuItem.Text = "查看帮助";
            this.watchHelpToolStripMenuItem.Click += new System.EventHandler(this.watchHelp_ToolStripMenuItem_Click);
            // 
            // contectUsToolStripMenuItem
            // 
            this.contectUsToolStripMenuItem.Name = "contectUsToolStripMenuItem";
            this.contectUsToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.contectUsToolStripMenuItem.Text = "联系我们";
            this.contectUsToolStripMenuItem.Click += new System.EventHandler(this.contectUs_ToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.updateToolStripMenuItem.Text = "更新日志";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // aboutBlueCentaureaToolStripMenuItem
            // 
            this.aboutBlueCentaureaToolStripMenuItem.Name = "aboutBlueCentaureaToolStripMenuItem";
            this.aboutBlueCentaureaToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.aboutBlueCentaureaToolStripMenuItem.Text = "关于 BlueCentaurea V2.0";
            this.aboutBlueCentaureaToolStripMenuItem.Click += new System.EventHandler(this.aboutBlueCentaurea_ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.serialToolStripMenuItem,
            this.netToolStripMenuItem,
            this.httpTest,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // httpTest
            // 
            this.httpTest.Name = "httpTest";
            this.httpTest.Size = new System.Drawing.Size(120, 23);
            this.httpTest.Text = "HTTP测试(&H)";
            this.httpTest.Click += new System.EventHandler(this.httpTest_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackgroundImage = global::BlueCentaurea.Properties.Resources.BlueCentaureaBig;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(12, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(780, 460);
            this.mainPanel.TabIndex = 1;
            // 
            // dES解密ToolStripMenuItem
            // 
            this.dES解密ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.解锁;
            this.dES解密ToolStripMenuItem.Name = "dES解密ToolStripMenuItem";
            this.dES解密ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.dES解密ToolStripMenuItem.Text = "DES解密(&D)";
            // 
            // dES解密ToolStripMenuItem1
            // 
            this.dES解密ToolStripMenuItem1.Image = global::BlueCentaurea.Properties.Resources.解锁;
            this.dES解密ToolStripMenuItem1.Name = "dES解密ToolStripMenuItem1";
            this.dES解密ToolStripMenuItem1.Size = new System.Drawing.Size(177, 24);
            this.dES解密ToolStripMenuItem1.Text = "3DES解密(&T)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 511);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BlueCentaurea V3.0";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem transToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进制转换为GB2312ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gB2312转换为16进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进制转换为ASCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCII转换为16进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delBlankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBlankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算MD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES加密ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 计算MACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contectUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBlueCentaureaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem strLenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem httpTest;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem dES解密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES解密ToolStripMenuItem1;
    }
}

