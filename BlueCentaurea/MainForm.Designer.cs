﻿namespace BlueCentaurea
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
            this.hex2UTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTF82HexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strLenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算MD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES加密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.计算MACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dES解密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contectUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBlueCentaureaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qqOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.hex2UTF8ToolStripMenuItem,
            this.uTF82HexToolStripMenuItem});
            this.transToolStripMenuItem.Name = "transToolStripMenuItem";
            this.transToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.transToolStripMenuItem.Text = "编码转换(&T)";
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
            this.mD5ToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.mD5ToolStripMenuItem.Text = "MD5(&M)";
            this.mD5ToolStripMenuItem.Click += new System.EventHandler(this.mD5ToolStripMenuItem_Click);
            // 
            // sHA1ToolStripMenuItem
            // 
            this.sHA1ToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.校验1;
            this.sHA1ToolStripMenuItem.Name = "sHA1ToolStripMenuItem";
            this.sHA1ToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.sHA1ToolStripMenuItem.Text = "SHA1(&S)";
            this.sHA1ToolStripMenuItem.Click += new System.EventHandler(this.sHA1ToolStripMenuItem_Click);
            // 
            // strLenToolStripMenuItem
            // 
            this.strLenToolStripMenuItem.Image = global::BlueCentaurea.Properties.Resources.calc;
            this.strLenToolStripMenuItem.Name = "strLenToolStripMenuItem";
            this.strLenToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.strLenToolStripMenuItem.Text = "字符串长度(&L)";
            this.strLenToolStripMenuItem.Click += new System.EventHandler(this.calcStrLenToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算MD5ToolStripMenuItem,
            this.dES加密ToolStripMenuItem,
            this.dES加密ToolStripMenuItem1,
            this.计算MACToolStripMenuItem});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.encryptToolStripMenuItem.Text = "加密(&E)";
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
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dES解密ToolStripMenuItem,
            this.dES解密ToolStripMenuItem1});
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.decryptToolStripMenuItem.Text = "解密(&D)";
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
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.serialToolStripMenuItem.Text = "串口(&S)";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.Serial_ToolStripMenuItem_Click);
            // 
            // netToolStripMenuItem
            // 
            this.netToolStripMenuItem.Name = "netToolStripMenuItem";
            this.netToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.netToolStripMenuItem.Text = "网口(&N)";
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
            this.queryToolStripMenuItem,
            this.transToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem,
            this.serialToolStripMenuItem,
            this.netToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qqOnlineToolStripMenuItem,
            this.trainToolStripMenuItem,
            this.airportToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.queryToolStripMenuItem.Text = "查询(&Q)";
            // 
            // qqOnlineToolStripMenuItem
            // 
            this.qqOnlineToolStripMenuItem.Name = "qqOnlineToolStripMenuItem";
            this.qqOnlineToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.qqOnlineToolStripMenuItem.Text = "QQ在线状态(&O)";
            this.qqOnlineToolStripMenuItem.Click += new System.EventHandler(this.qqOnlineToolStripMenuItem_Click_1);
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.trainToolStripMenuItem.Text = "火车时刻表(T)";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // airportToolStripMenuItem
            // 
            this.airportToolStripMenuItem.Name = "airportToolStripMenuItem";
            this.airportToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.airportToolStripMenuItem.Text = "飞机航班(A)";
            this.airportToolStripMenuItem.Click += new System.EventHandler(this.airportToolStripMenuItem_Click);
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

        private System.Windows.Forms.ToolStripMenuItem transToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进制转换为GB2312ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gB2312转换为16进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进制转换为ASCIIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSCII转换为16进制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hex2UTF8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTF82HexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算MD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES加密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES加密ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 计算MACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES解密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dES解密ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contectUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBlueCentaureaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem strLenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qqOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportToolStripMenuItem;
    }
}

