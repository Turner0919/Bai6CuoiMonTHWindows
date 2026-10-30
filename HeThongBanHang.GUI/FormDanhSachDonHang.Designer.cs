namespace HeThongBanHang.GUI
{
    partial class FormDanhSachDonHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            lblTongSoDonHang = new Label();
            dgvDanhSachDonHang = new DataGridView();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            dgvChiTietDonHang = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachDonHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDonHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(830, 62);
            label1.TabIndex = 2;
            label1.Text = "DANH SÁCH ĐƠN HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 3;
            label2.Text = "Danh sách đơn hàng:";
            // 
            // lblTongSoDonHang
            // 
            lblTongSoDonHang.AutoSize = true;
            lblTongSoDonHang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongSoDonHang.ForeColor = Color.FromArgb(0, 0, 192);
            lblTongSoDonHang.Location = new Point(12, 250);
            lblTongSoDonHang.Name = "lblTongSoDonHang";
            lblTongSoDonHang.Size = new Size(136, 17);
            lblTongSoDonHang.TabIndex = 4;
            lblTongSoDonHang.Text = "Tổng số đơn hàng: 0";
            // 
            // dgvDanhSachDonHang
            // 
            dgvDanhSachDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhSachDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSachDonHang.ColumnHeadersHeight = 29;
            dgvDanhSachDonHang.Columns.AddRange(new DataGridViewColumn[] { TenSP, SoLuong, DonGia, ThanhTien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhSachDonHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachDonHang.EnableHeadersVisualStyles = false;
            dgvDanhSachDonHang.Location = new Point(12, 89);
            dgvDanhSachDonHang.Margin = new Padding(3, 2, 3, 2);
            dgvDanhSachDonHang.Name = "dgvDanhSachDonHang";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDanhSachDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachDonHang.RowHeadersVisible = false;
            dgvDanhSachDonHang.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvDanhSachDonHang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDanhSachDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachDonHang.Size = new Size(793, 159);
            dgvDanhSachDonHang.TabIndex = 11;
            dgvDanhSachDonHang.CellClick += dgvDanhSachDonHang_CellClick;
            dgvDanhSachDonHang.CellFormatting += dgv_CellFormatting;
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Mã ĐH";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Khách Hàng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Ngày Đặt";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Trạng Thái";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // dgvChiTietDonHang
            // 
            dgvChiTietDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Blue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvChiTietDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvChiTietDonHang.ColumnHeadersHeight = 29;
            dgvChiTietDonHang.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvChiTietDonHang.DefaultCellStyle = dataGridViewCellStyle6;
            dgvChiTietDonHang.EnableHeadersVisualStyles = false;
            dgvChiTietDonHang.Location = new Point(12, 308);
            dgvChiTietDonHang.Margin = new Padding(3, 2, 3, 2);
            dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvChiTietDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvChiTietDonHang.RowHeadersVisible = false;
            dgvChiTietDonHang.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = Color.White;
            dgvChiTietDonHang.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvChiTietDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietDonHang.Size = new Size(793, 179);
            dgvChiTietDonHang.TabIndex = 12;
            dgvChiTietDonHang.CellFormatting += dgv_CellFormatting;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "TenSP";
            dataGridViewTextBoxColumn1.HeaderText = "Sản Phẩm";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "SoLuong";
            dataGridViewTextBoxColumn2.HeaderText = "SL";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "DonGia";
            dataGridViewTextBoxColumn3.HeaderText = "Đơn Giá Lúc Bán";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 281);
            label4.Name = "label4";
            label4.Size = new Size(167, 15);
            label4.TabIndex = 13;
            label4.Text = "Chi tiết đơn hàng đang chọn:";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(541, 256);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 14;
            button1.Text = "HỦY ĐƠN HÀNG";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(676, 256);
            button2.Name = "button2";
            button2.Size = new Size(129, 40);
            button2.TabIndex = 15;
            button2.Text = "LÀM MỚI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormDanhSachDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 498);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dgvChiTietDonHang);
            Controls.Add(dgvDanhSachDonHang);
            Controls.Add(lblTongSoDonHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDanhSachDonHang";
            Text = "FormDanhSachDonHang";
            Load += FormDanhSachDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachDonHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblTongSoDonHang;
        private DataGridView dgvDanhSachDonHang;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridView dgvChiTietDonHang;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}