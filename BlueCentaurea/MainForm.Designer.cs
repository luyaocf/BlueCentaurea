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
            this.编码转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进制转换为GB2312ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gB2312转换为16进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进制转换为ASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCII转换为16进制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hex2UTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF82HexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件校验ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算MD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES加密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.计算MACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES解密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.串口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网口NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于BlueCentaureaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 编码转换ToolStripMenuItem
            // 
            this.编码转换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进制转换为GB2312ToolStripMenuItem,
            this.gB2312转换为16进制ToolStripMenuItem,
            this.进制转换为ASCIIToolStripMenuItem,
            this.aSCII转换为16进制ToolStripMenuItem,
            this.hex2UTF8ToolStripMenuItem,
            this.uTF82HexToolStripMenuItem});
            this.编码转换ToolStripMenuItem.Name = "编码转换ToolStripMenuItem";
            this.编码转换ToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.编码转换ToolStripMenuItem.Text = "编码转换(&T)";
            // 
            // 进制转换为GB2312ToolStripMenuItem
            // 
            this.进制转换为GB2312ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.进制转换为GB2312ToolStripMenuItem.Name = "进制转换为GB2312ToolStripMenuItem";
            this.进制转换为GB2312ToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.进制转换为GB2312ToolStripMenuItem.Text = "Hex2GBK(&H)";
            this.进制转换为GB2312ToolStripMenuItem.Click += new System.EventHandler(this.Hex2GB2312ToolStripMenuItem_Click);
            // 
            // gB2312转换为16进制ToolStripMenuItem
            // 
            this.gB2312转换为16进制ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.gB2312转换为16进制ToolStripMenuItem.Name = "gB2312转换为16进制ToolStripMenuItem";
            this.gB2312转换为16进制ToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.gB2312转换为16进制ToolStripMenuItem.Text = "GBK2Hex(G)";
            this.gB2312转换为16进制ToolStripMenuItem.Click += new System.EventHandler(this.GB2312ToHexToolStripMenuItem_Click);
            // 
            // 进制转换为ASCIIToolStripMenuItem
            // 
            this.进制转换为ASCIIToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.进制转换为ASCIIToolStripMenuItem.Name = "进制转换为ASCIIToolStripMenuItem";
            this.进制转换为ASCIIToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.进制转换为ASCIIToolStripMenuItem.Text = "Hex2ASC(&X)";
            this.进制转换为ASCIIToolStripMenuItem.Click += new System.EventHandler(this.Hex2ASCII_ToolStripMenuItem_Click);
            // 
            // aSCII转换为16进制ToolStripMenuItem
            // 
            this.aSCII转换为16进制ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.aSCII转换为16进制ToolStripMenuItem.Name = "aSCII转换为16进制ToolStripMenuItem";
            this.aSCII转换为16进制ToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.aSCII转换为16进制ToolStripMenuItem.Text = "ASC2Hex(&A)";
            this.aSCII转换为16进制ToolStripMenuItem.Click += new System.EventHandler(this.ASCII2Hex_ToolStripMenuItem_Click);
            // 
            // hex2UTF8ToolStripMenuItem
            // 
            this.hex2UTF8ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.hex2UTF8ToolStripMenuItem.Name = "hex2UTF8ToolStripMenuItem";
            this.hex2UTF8ToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.hex2UTF8ToolStripMenuItem.Text = "Hex2UTF-8(&E)";
            this.hex2UTF8ToolStripMenuItem.Click += new System.EventHandler(this.hex2UTF8ToolStripMenuItem_Click);
            // 
            // uTF82HexToolStripMenuItem
            // 
            this.uTF82HexToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.uTF82HexToolStripMenuItem.Name = "uTF82HexToolStripMenuItem";
            this.uTF82HexToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.uTF82HexToolStripMenuItem.Text = "UTF-82Hex(&U)";
            this.uTF82HexToolStripMenuItem.Click += new System.EventHandler(this.uTF82HexToolStripMenuItem_Click);
            // 
            // 文件校验ToolStripMenuItem
            // 
            this.文件校验ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mD5ToolStripMenuItem,
            this.sHA1ToolStripMenuItem});
            this.文件校验ToolStripMenuItem.Name = "文件校验ToolStripMenuItem";
            this.文件校验ToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.文件校验ToolStripMenuItem.Text = "文件校验(&C)";
            this.文件校验ToolStripMenuItem.Click += new System.EventHandler(this.Check_ToolStripMenuItem_Clic);
            // 
            // mD5ToolStripMenuItem
            // 
            this.mD5ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.校验;
            this.mD5ToolStripMenuItem.Name = "mD5ToolStripMenuItem";
            this.mD5ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.mD5ToolStripMenuItem.Text = "MD5(&M)";
            // 
            // sHA1ToolStripMenuItem
            // 
            this.sHA1ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.校验1;
            this.sHA1ToolStripMenuItem.Name = "sHA1ToolStripMenuItem";
            this.sHA1ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.sHA1ToolStripMenuItem.Text = "SHA1(&S)";
            // 
            // 加密ToolStripMenuItem
            // 
            this.加密ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算MD5ToolStripMenuItem,
            this.dES加密ToolStripMenuItem,
            this.dES加密ToolStripMenuItem1,
            this.计算MACToolStripMenuItem});
            this.加密ToolStripMenuItem.Name = "加密ToolStripMenuItem";
            this.加密ToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.加密ToolStripMenuItem.Text = "加密(&E)";
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
            // 解密ToolStripMenuItem
            // 
            this.解密ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dES解密ToolStripMenuItem,
            this.dES解密ToolStripMenuItem1});
            this.解密ToolStripMenuItem.Name = "解密ToolStripMenuItem";
            this.解密ToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.解密ToolStripMenuItem.Text = "解密(&D)";
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
            // 串口ToolStripMenuItem
            // 
            this.串口ToolStripMenuItem.Name = "串口ToolStripMenuItem";
            this.串口ToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.串口ToolStripMenuItem.Text = "串口(&S)";
            this.串口ToolStripMenuItem.Click += new System.EventHandler(this.Serial_ToolStripMenuItem_Click);
            // 
            // 网口NToolStripMenuItem
            // 
            this.网口NToolStripMenuItem.Name = "网口NToolStripMenuItem";
            this.网口NToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.网口NToolStripMenuItem.Text = "网口(&N)";
            this.网口NToolStripMenuItem.Click += new System.EventHandler(this.Network_ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.联系我们ToolStripMenuItem,
            this.更新日志ToolStripMenuItem,
            this.关于BlueCentaureaToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            this.查看帮助ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助_ToolStripMenuItem_Click);
            // 
            // 联系我们ToolStripMenuItem
            // 
            this.联系我们ToolStripMenuItem.Name = "联系我们ToolStripMenuItem";
            this.联系我们ToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.联系我们ToolStripMenuItem.Text = "联系我们";
            this.联系我们ToolStripMenuItem.Click += new System.EventHandler(this.联系我们_ToolStripMenuItem_Click);
            // 
            // 更新日志ToolStripMenuItem
            // 
            this.更新日志ToolStripMenuItem.Name = "更新日志ToolStripMenuItem";
            this.更新日志ToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.更新日志ToolStripMenuItem.Text = "更新日志";
            this.更新日志ToolStripMenuItem.Click += new System.EventHandler(this.更新日志ToolStripMenuItem_Click);
            // 
            // 关于BlueCentaureaToolStripMenuItem
            // 
            this.关于BlueCentaureaToolStripMenuItem.Name = "关于BlueCentaureaToolStripMenuItem";
            this.关于BlueCentaureaToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.关于BlueCentaureaToolStripMenuItem.Text = "关于 BlueCentaurea V2.0";
            this.关于BlueCentaureaToolStripMenuItem.Click += new System.EventHandler(this.关于BlueCentaurea_ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编码转换ToolStripMenuItem,
            this.文件校验ToolStripMenuItem,
            this.加密ToolStripMenuItem,
            this.解密ToolStripMenuItem,
            this.串口ToolStripMenuItem,
            this.网口NToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlueCentaurea.Properties.Resources.browser_icon_chrome;
            this.ClientSize = new System.Drawing.Size(755, 511);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private System.Windows.Forms.ToolStripMenuItem 编码转换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进制转换为GB2312ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gB2312转换为16进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进制转换为ASCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCII转换为16进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hex2UTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF82HexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件校验ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算MD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES加密ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 计算MACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES解密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES解密ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 串口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网口NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于BlueCentaureaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

