namespace BlueCentaurea
{
    partial class LoadingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingControl));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_caption = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // lbl_caption
            // 
            this.lbl_caption.AutoSize = true;
            this.lbl_caption.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_caption.Location = new System.Drawing.Point(115, 36);
            this.lbl_caption.Name = "lbl_caption";
            this.lbl_caption.Size = new System.Drawing.Size(52, 14);
            this.lbl_caption.TabIndex = 4;
            this.lbl_caption.Text = "请稍等";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_description.Location = new System.Drawing.Point(116, 58);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(84, 14);
            this.lbl_description.TabIndex = 5;
            this.lbl_description.Text = "正在加载...";
            // 
            // LoadingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(308, 102);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_caption);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(324, 141);
            this.MinimumSize = new System.Drawing.Size(324, 141);
            this.Name = "LoadingControl";
            this.Text = "请稍等...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadingControl_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_caption;
        private System.Windows.Forms.Label lbl_description;
    }
}