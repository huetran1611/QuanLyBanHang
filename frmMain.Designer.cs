namespace QuanLyBanHang
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qLDanhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMLoaiHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLDanhMucToolStripMenuItem,
            this.quanLyHoaDonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qLDanhMucToolStripMenuItem
            // 
            this.qLDanhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dMHangToolStripMenuItem,
            this.dMLoaiHangToolStripMenuItem,
            this.dMKhachHangToolStripMenuItem});
            this.qLDanhMucToolStripMenuItem.Name = "qLDanhMucToolStripMenuItem";
            this.qLDanhMucToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.qLDanhMucToolStripMenuItem.Text = "QLDanhMuc";
            // 
            // quanLyHoaDonToolStripMenuItem
            // 
            this.quanLyHoaDonToolStripMenuItem.Name = "quanLyHoaDonToolStripMenuItem";
            this.quanLyHoaDonToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.quanLyHoaDonToolStripMenuItem.Text = "QuanLyHoaDon";
            // 
            // dMHangToolStripMenuItem
            // 
            this.dMHangToolStripMenuItem.Name = "dMHangToolStripMenuItem";
            this.dMHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dMHangToolStripMenuItem.Text = "DMHang";
            this.dMHangToolStripMenuItem.Click += new System.EventHandler(this.dMHangToolStripMenuItem_Click);
            // 
            // dMLoaiHangToolStripMenuItem
            // 
            this.dMLoaiHangToolStripMenuItem.Name = "dMLoaiHangToolStripMenuItem";
            this.dMLoaiHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dMLoaiHangToolStripMenuItem.Text = "DMLoaiHang";
            // 
            // dMKhachHangToolStripMenuItem
            // 
            this.dMKhachHangToolStripMenuItem.Name = "dMKhachHangToolStripMenuItem";
            this.dMKhachHangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dMKhachHangToolStripMenuItem.Text = "DM Khach Hang";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qLDanhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMLoaiHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyHoaDonToolStripMenuItem;
    }
}