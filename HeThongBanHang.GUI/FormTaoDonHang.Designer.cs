namespace HeThongBanHang.GUI
{
    partial class FormTaoDonHang
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboKhachHang = new ComboBox();
            cboSanPham = new ComboBox();
            label5 = new Label();
            nudSoLuong = new NumericUpDown();
            dgvGioHang = new DataGridView();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnXoaKhoiGio = new Button();
            btnDatHang = new Button();
            lblTongTien = new Label();
            btnDong = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
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
            label1.TabIndex = 1;
            label1.Text = "TẠO ĐƠN HÀNG MỚI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 2;
            label2.Text = "Khách hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(25, 115);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 3;
            label3.Text = "Sản phẩm:";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(121, 76);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(336, 23);
            cboKhachHang.TabIndex = 4;
            cboKhachHang.SelectedIndexChanged += cboKhachHang_SelectedIndexChanged;
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(121, 114);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(336, 23);
            cboSanPham.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(484, 115);
            label5.Name = "label5";
            label5.Size = new Size(24, 17);
            label5.TabIndex = 7;
            label5.Text = "SL:";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(514, 115);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(64, 23);
            nudSoLuong.TabIndex = 8;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dgvGioHang
            // 
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGioHang.ColumnHeadersHeight = 29;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { TenSP, SoLuong, DonGia, ThanhTien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGioHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGioHang.EnableHeadersVisualStyles = false;
            dgvGioHang.Location = new Point(25, 150);
            dgvGioHang.Margin = new Padding(3, 2, 3, 2);
            dgvGioHang.Name = "dgvGioHang";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvGioHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.White;
            dgvGioHang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new Size(777, 187);
            dgvGioHang.TabIndex = 10;
            dgvGioHang.CellFormatting += dgvGioHang_CellFormatting;
            // 
            // TenSP
            // 
            TenSP.DataPropertyName = "TenSP";
            TenSP.HeaderText = "Sản phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "SL";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            ThanhTien.HeaderText = "Thành Tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // btnXoaKhoiGio
            // 
            btnXoaKhoiGio.BackColor = Color.Red;
            btnXoaKhoiGio.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaKhoiGio.ForeColor = Color.White;
            btnXoaKhoiGio.Location = new Point(25, 353);
            btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            btnXoaKhoiGio.Size = new Size(157, 49);
            btnXoaKhoiGio.TabIndex = 11;
            btnXoaKhoiGio.Text = "X Xóa Khỏi GIỏ";
            btnXoaKhoiGio.UseVisualStyleBackColor = false;
            btnXoaKhoiGio.Click += btnXoaKhoiGio_Click;
            // 
            // btnDatHang
            // 
            btnDatHang.BackColor = Color.Green;
            btnDatHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatHang.ForeColor = SystemColors.ControlLightLight;
            btnDatHang.Location = new Point(514, 425);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(121, 51);
            btnDatHang.TabIndex = 12;
            btnDatHang.Text = "Đặt Hàng";
            btnDatHang.UseVisualStyleBackColor = false;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(514, 386);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(167, 32);
            lblTongTien.TabIndex = 14;
            lblTongTien.Text = "Tổng tiền: 0đ";
            // 
            // btnDong
            // 
            btnDong.BackColor = SystemColors.ControlDarkDark;
            btnDong.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(641, 425);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(121, 51);
            btnDong.TabIndex = 15;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(608, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 39);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormTaoDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 488);
            Controls.Add(btnAdd);
            Controls.Add(btnDong);
            Controls.Add(lblTongTien);
            Controls.Add(btnDatHang);
            Controls.Add(btnXoaKhoiGio);
            Controls.Add(dgvGioHang);
            Controls.Add(nudSoLuong);
            Controls.Add(label5);
            Controls.Add(cboSanPham);
            Controls.Add(cboKhachHang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTaoDonHang";
            Text = "FormTaoDonHang";
            Load += FormTaoDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboKhachHang;
        private ComboBox cboSanPham;
        private Label label5;
        private NumericUpDown nudSoLuong;
        private DataGridView dgvGioHang;
        private Button btnXoaKhoiGio;
        private Button btnDatHang;
        private Label lblTongTien;
        private Button btnDong;
        private Button btnAdd;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}