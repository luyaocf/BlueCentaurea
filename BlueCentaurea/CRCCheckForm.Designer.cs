namespace BlueCentaurea
{
    partial class CRCCheckForm
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
            this.radioButtonCRC8 = new System.Windows.Forms.RadioButton();
            this.radioButtonCRC16_CCITT = new System.Windows.Forms.RadioButton();
            this.radioButtonCRC16 = new System.Windows.Forms.RadioButton();
            this.radioButtonCRC32 = new System.Windows.Forms.RadioButton();
            this.radioButtonSUM = new System.Windows.Forms.RadioButton();
            this.radioButtonXOR = new System.Windows.Forms.RadioButton();
            this.btnCheckConfirm = new System.Windows.Forms.Button();
            this.btnCheckCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonLowFront = new System.Windows.Forms.RadioButton();
            this.radioButtonHighFront = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonCRC8
            // 
            this.radioButtonCRC8.AutoSize = true;
            this.radioButtonCRC8.Checked = true;
            this.radioButtonCRC8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCRC8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCRC8.Location = new System.Drawing.Point(43, 20);
            this.radioButtonCRC8.Name = "radioButtonCRC8";
            this.radioButtonCRC8.Size = new System.Drawing.Size(53, 19);
            this.radioButtonCRC8.TabIndex = 16;
            this.radioButtonCRC8.TabStop = true;
            this.radioButtonCRC8.Text = "CRC8";
            this.radioButtonCRC8.UseVisualStyleBackColor = true;
            // 
            // radioButtonCRC16_CCITT
            // 
            this.radioButtonCRC16_CCITT.AutoSize = true;
            this.radioButtonCRC16_CCITT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCRC16_CCITT.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCRC16_CCITT.Location = new System.Drawing.Point(43, 45);
            this.radioButtonCRC16_CCITT.Name = "radioButtonCRC16_CCITT";
            this.radioButtonCRC16_CCITT.Size = new System.Drawing.Size(102, 19);
            this.radioButtonCRC16_CCITT.TabIndex = 17;
            this.radioButtonCRC16_CCITT.Text = "CRC16-CCITT";
            this.radioButtonCRC16_CCITT.UseVisualStyleBackColor = true;
            // 
            // radioButtonCRC16
            // 
            this.radioButtonCRC16.AutoSize = true;
            this.radioButtonCRC16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCRC16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCRC16.Location = new System.Drawing.Point(43, 70);
            this.radioButtonCRC16.Name = "radioButtonCRC16";
            this.radioButtonCRC16.Size = new System.Drawing.Size(60, 19);
            this.radioButtonCRC16.TabIndex = 18;
            this.radioButtonCRC16.Text = "CRC16";
            this.radioButtonCRC16.UseVisualStyleBackColor = true;
            // 
            // radioButtonCRC32
            // 
            this.radioButtonCRC32.AutoSize = true;
            this.radioButtonCRC32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCRC32.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCRC32.Location = new System.Drawing.Point(43, 95);
            this.radioButtonCRC32.Name = "radioButtonCRC32";
            this.radioButtonCRC32.Size = new System.Drawing.Size(60, 19);
            this.radioButtonCRC32.TabIndex = 19;
            this.radioButtonCRC32.Text = "CRC32";
            this.radioButtonCRC32.UseVisualStyleBackColor = true;
            // 
            // radioButtonSUM
            // 
            this.radioButtonSUM.AutoSize = true;
            this.radioButtonSUM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSUM.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSUM.Location = new System.Drawing.Point(43, 120);
            this.radioButtonSUM.Name = "radioButtonSUM";
            this.radioButtonSUM.Size = new System.Drawing.Size(67, 19);
            this.radioButtonSUM.TabIndex = 20;
            this.radioButtonSUM.Text = "累加和";
            this.radioButtonSUM.UseVisualStyleBackColor = true;
            // 
            // radioButtonXOR
            // 
            this.radioButtonXOR.AutoSize = true;
            this.radioButtonXOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonXOR.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXOR.Location = new System.Drawing.Point(43, 145);
            this.radioButtonXOR.Name = "radioButtonXOR";
            this.radioButtonXOR.Size = new System.Drawing.Size(53, 19);
            this.radioButtonXOR.TabIndex = 21;
            this.radioButtonXOR.Text = "异或";
            this.radioButtonXOR.UseVisualStyleBackColor = true;
            // 
            // btnCheckConfirm
            // 
            this.btnCheckConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckConfirm.Location = new System.Drawing.Point(21, 241);
            this.btnCheckConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckConfirm.Name = "btnCheckConfirm";
            this.btnCheckConfirm.Size = new System.Drawing.Size(78, 24);
            this.btnCheckConfirm.TabIndex = 22;
            this.btnCheckConfirm.Text = "确定";
            this.btnCheckConfirm.UseVisualStyleBackColor = true;
            this.btnCheckConfirm.Click += new System.EventHandler(this.BtnCheckConfirm_Click);
            // 
            // btnCheckCancel
            // 
            this.btnCheckCancel.BackgroundImage = global::BlueCentaurea.Properties.Resources.校验;
            this.btnCheckCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckCancel.Location = new System.Drawing.Point(134, 240);
            this.btnCheckCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckCancel.Name = "btnCheckCancel";
            this.btnCheckCancel.Size = new System.Drawing.Size(78, 24);
            this.btnCheckCancel.TabIndex = 23;
            this.btnCheckCancel.Text = "取消";
            this.btnCheckCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCRC8);
            this.groupBox1.Controls.Add(this.radioButtonCRC16_CCITT);
            this.groupBox1.Controls.Add(this.radioButtonXOR);
            this.groupBox1.Controls.Add(this.radioButtonCRC16);
            this.groupBox1.Controls.Add(this.radioButtonSUM);
            this.groupBox1.Controls.Add(this.radioButtonCRC32);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 175);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "校验方式";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonLowFront);
            this.groupBox2.Controls.Add(this.radioButtonHighFront);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 35);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonLowFront
            // 
            this.radioButtonLowFront.AutoSize = true;
            this.radioButtonLowFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonLowFront.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLowFront.Location = new System.Drawing.Point(106, 10);
            this.radioButtonLowFront.Name = "radioButtonLowFront";
            this.radioButtonLowFront.Size = new System.Drawing.Size(81, 19);
            this.radioButtonLowFront.TabIndex = 26;
            this.radioButtonLowFront.Text = "小端模式";
            this.radioButtonLowFront.UseVisualStyleBackColor = true;
            // 
            // radioButtonHighFront
            // 
            this.radioButtonHighFront.AutoSize = true;
            this.radioButtonHighFront.Checked = true;
            this.radioButtonHighFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonHighFront.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHighFront.Location = new System.Drawing.Point(6, 10);
            this.radioButtonHighFront.Name = "radioButtonHighFront";
            this.radioButtonHighFront.Size = new System.Drawing.Size(81, 19);
            this.radioButtonHighFront.TabIndex = 22;
            this.radioButtonHighFront.TabStop = true;
            this.radioButtonHighFront.Text = "大端模式";
            this.radioButtonHighFront.UseVisualStyleBackColor = true;
            // 
            // CRCCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(236, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCheckCancel);
            this.Controls.Add(this.btnCheckConfirm);
            this.Controls.Add(this.groupBox1);
            this.Name = "CRCCheckForm";
            this.Text = "校验";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RadioButton radioButtonCRC8;
        internal System.Windows.Forms.RadioButton radioButtonCRC16_CCITT;
        internal System.Windows.Forms.RadioButton radioButtonCRC16;
        internal System.Windows.Forms.RadioButton radioButtonCRC32;
        internal System.Windows.Forms.RadioButton radioButtonSUM;
        internal System.Windows.Forms.RadioButton radioButtonXOR;
        private System.Windows.Forms.Button btnCheckConfirm;
        private System.Windows.Forms.Button btnCheckCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.RadioButton radioButtonLowFront;
        internal System.Windows.Forms.RadioButton radioButtonHighFront;
    }
}