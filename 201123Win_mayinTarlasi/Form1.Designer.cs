namespace _201123Win_mayinTarlasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolayToolStripMenuItem,
            this.ortaToolStripMenuItem,
            this.zorToolStripMenuItem});
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun";
            // 
            // kolayToolStripMenuItem
            // 
            this.kolayToolStripMenuItem.Name = "kolayToolStripMenuItem";
            this.kolayToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kolayToolStripMenuItem.Text = "Kolay";
            this.kolayToolStripMenuItem.Click += new System.EventHandler(this.kolayToolStripMenuItem_Click);
            // 
            // ortaToolStripMenuItem
            // 
            this.ortaToolStripMenuItem.Name = "ortaToolStripMenuItem";
            this.ortaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ortaToolStripMenuItem.Text = "Orta";
            this.ortaToolStripMenuItem.Click += new System.EventHandler(this.ortaToolStripMenuItem_Click);
            // 
            // zorToolStripMenuItem
            // 
            this.zorToolStripMenuItem.Name = "zorToolStripMenuItem";
            this.zorToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.zorToolStripMenuItem.Text = "Zor";
            this.zorToolStripMenuItem.Click += new System.EventHandler(this.zorToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(629, 344);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 400);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zorToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

