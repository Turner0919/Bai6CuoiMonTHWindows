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
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            bánHàngToolStripMenuItem = new ToolStripMenuItem();
            tạoĐơnHàngToolStripMenuItem = new ToolStripMenuItem();
            danhSáchĐơnHàngToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Size = new Size(950, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ThoatToolStripMenuItem });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(48, 24);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // ThoatToolStripMenuItem
            // 
            ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            ThoatToolStripMenuItem.Size = new Size(130, 26);
            ThoatToolStripMenuItem.Text = "Thoát";
            ThoatToolStripMenuItem.Click += ThoatToolStripMenuItem_Click;
            // 
            // danhToolStripMenuItem
            // 
            danhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýSảnPhẩmToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem });
            danhToolStripMenuItem.Name = "danhToolStripMenuItem";
            danhToolStripMenuItem.Size = new Size(90, 24);
            danhToolStripMenuItem.Text = "Danh Mục";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            quảnLýSảnPhẩmToolStripMenuItem.Size = new Size(223, 26);
            quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý Sản phẩm";
            quảnLýSảnPhẩmToolStripMenuItem.Click += quảnLýSảnPhẩmToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(223, 26);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý Khách hàng";
            // 
            // bánHàngToolStripMenuItem
            // 
            bánHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoĐơnHàngToolStripMenuItem, danhSáchĐơnHàngToolStripMenuItem });
            bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            bánHàngToolStripMenuItem.Size = new Size(88, 24);
            bánHàngToolStripMenuItem.Text = "Bán Hàng";
            // 
            // tạoĐơnHàngToolStripMenuItem
            // 
            tạoĐơnHàngToolStripMenuItem.Name = "tạoĐơnHàngToolStripMenuItem";
            tạoĐơnHàngToolStripMenuItem.Size = new Size(229, 26);
            tạoĐơnHàngToolStripMenuItem.Text = "Tạo Đơn hàng";
            // 
            // danhSáchĐơnHàngToolStripMenuItem
            // 
            danhSáchĐơnHàngToolStripMenuItem.Name = "danhSáchĐơnHàngToolStripMenuItem";
            danhSáchĐơnHàngToolStripMenuItem.Size = new Size(229, 26);
            danhSáchĐơnHàngToolStripMenuItem.Text = "Danh sách Đơn hàng";
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(950, 88);
            label1.TabIndex = 2;
            label1.Text = "HỆ THỐNG QUẢN LÝ CỬA HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelChinh
            // 
            panelChinh.Dock = DockStyle.Bottom;
            panelChinh.Location = new Point(0, 119);
            panelChinh.Name = "panelChinh";
            panelChinh.Size = new Size(950, 758);
            panelChinh.TabIndex = 3;
            // 
            // FormQuanLyBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 877);
            Controls.Add(panelChinh);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem bánHàngToolStripMenuItem;
        private ToolStripMenuItem tạoĐơnHàngToolStripMenuItem;
        private ToolStripMenuItem danhSáchĐơnHàngToolStripMenuItem;
        private Label label1;
        private Panel panelChinh;
    }
}
