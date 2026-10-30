namespace HeThongBanHang.GUI
{
    partial class FormQuanLyBanHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            ThoatToolStripMenuItem = new ToolStripMenuItem();
            danhToolStripMenuItem = new ToolStripMenuItem();
            quảnLýSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            mnuQuanLyKhachHang = new ToolStripMenuItem();
            bánHàngToolStripMenuItem = new ToolStripMenuItem();
            mnuTaoDonHang = new ToolStripMenuItem();
            mnuDanhSachDonHang = new ToolStripMenuItem();
            label1 = new Label();
            panelChinh = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, danhToolStripMenuItem, bánHàngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(831, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ThoatToolStripMenuItem });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(39, 20);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // ThoatToolStripMenuItem
            // 
            ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            ThoatToolStripMenuItem.Size = new Size(105, 22);
            ThoatToolStripMenuItem.Text = "Thoát";
            ThoatToolStripMenuItem.Click += ThoatToolStripMenuItem_Click;
            // 
            // danhToolStripMenuItem
            // 
            danhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSảnPhẩmToolStripMenuItem, mnuQuanLyKhachHang });
            danhToolStripMenuItem.Name = "danhToolStripMenuItem";
            danhToolStripMenuItem.Size = new Size(74, 20);
            danhToolStripMenuItem.Text = "Danh Mục";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(181, 22);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý Sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // mnuQuanLyKhachHang
            // 
            mnuQuanLyKhachHang.Name = "mnuQuanLyKhachHang";
            mnuQuanLyKhachHang.Size = new Size(181, 22);
            mnuQuanLyKhachHang.Text = "Quản lý Khách hàng";
            mnuQuanLyKhachHang.Click += mnuQuanLyKhachHang_Click;
            // 
            // bánHàngToolStripMenuItem
            // 
            bánHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuTaoDonHang, mnuDanhSachDonHang });
            bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            bánHàngToolStripMenuItem.Size = new Size(71, 20);
            bánHàngToolStripMenuItem.Text = "Bán Hàng";
            // 
            // mnuTaoDonHang
            // 
            mnuTaoDonHang.Name = "mnuTaoDonHang";
            mnuTaoDonHang.Size = new Size(184, 22);
            mnuTaoDonHang.Text = "Tạo Đơn hàng";
            mnuTaoDonHang.Click += mnuTaoDonHang_Click;
            // 
            // mnuDanhSachDonHang
            // 
            mnuDanhSachDonHang.Name = "mnuDanhSachDonHang";
            mnuDanhSachDonHang.Size = new Size(184, 22);
            mnuDanhSachDonHang.Text = "Danh sách Đơn hàng";
            mnuDanhSachDonHang.Click += mnuDanhSachDonHang_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(831, 66);
            label1.TabIndex = 2;
            label1.Text = "HỆ THỐNG QUẢN LÝ CỬA HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelChinh
            // 
            panelChinh.Dock = DockStyle.Bottom;
            panelChinh.Location = new Point(0, 90);
            panelChinh.Margin = new Padding(3, 2, 3, 2);
            panelChinh.Name = "panelChinh";
            panelChinh.Size = new Size(831, 568);
            panelChinh.TabIndex = 3;
            // 
            // FormQuanLyBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 658);
            Controls.Add(panelChinh);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormQuanLyBanHang";
            Text = "Quản Lý Bán Hàng";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem ThoatToolStripMenuItem;
        private ToolStripMenuItem danhToolStripMenuItem;
        private ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem mnuQuanLyKhachHang;
        private ToolStripMenuItem bánHàngToolStripMenuItem;
        private ToolStripMenuItem mnuTaoDonHang;
        private ToolStripMenuItem mnuDanhSachDonHang;
        private Label label1;
        private Panel panelChinh;
    }
}
