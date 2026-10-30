namespace HeThongBanHang.GUI
{
    partial class FormQuanLySanPham
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtSLTon = new TextBox();
            txtDonGia = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            label2 = new Label();
            dgvSanPham = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SLTon = new DataGridViewTextBoxColumn();
            lblTongSo = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
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
            label1.Size = new Size(949, 82);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SẢN PHẨM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSLTon);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(12, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 540);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ControlDark;
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(156, 412);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(137, 62);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(16, 412);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(137, 62);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.RoyalBlue;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(156, 344);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 62);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(16, 344);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 62);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(16, 257);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 7;
            label5.Text = "Số lượng tồn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(16, 183);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(16, 114);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên sản phẩm:";
            // 
            // txtSLTon
            // 
            txtSLTon.Location = new Point(16, 280);
            txtSLTon.Name = "txtSLTon";
            txtSLTon.Size = new Size(277, 27);
            txtSLTon.TabIndex = 4;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(16, 206);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(277, 27);
            txtDonGia.TabIndex = 3;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(16, 137);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(277, 27);
            txtTenSP.TabIndex = 2;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(16, 72);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(277, 27);
            txtMaSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(16, 49);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã SP:";
            // 
            // dgvSanPham
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Blue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Blue;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSanPham.ColumnHeadersHeight = 29;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, DonGia, SLTon });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSanPham.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.Location = new Point(333, 136);
            dgvSanPham.Name = "dgvSanPham";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = Color.White;
            dgvSanPham.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvSanPham.Size = new Size(603, 503);
            dgvSanPham.TabIndex = 2;
            // 
            // MaSP
            // 
            MaSP.HeaderText = "Mã SP";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.Width = 125;
            // 
            // TenSP
            // 
            TenSP.HeaderText = "Tên Sản Phẩm";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.Width = 200;
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn Giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.Width = 150;
            // 
            // SLTon
            // 
            SLTon.HeaderText = "SL Tồn";
            SLTon.MinimumWidth = 6;
            SLTon.Name = "SLTon";
            SLTon.Width = 125;
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongSo.ForeColor = Color.FromArgb(0, 0, 192);
            lblTongSo.Location = new Point(333, 99);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(154, 20);
            lblTongSo.TabIndex = 3;
            lblTongSo.Text = "Tổng số sản phẩm: 0";
            // 
            // FormQuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 651);
            Controls.Add(lblTongSo);
            Controls.Add(dgvSanPham);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormQuanLySanPham";
            Text = "Quản Lý Sản Phẩm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnThem;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtSLTon;
        private TextBox txtDonGia;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private Label label2;
        private Button btnLamMoi;
        private Button btnXoa;
        private DataGridView dgvSanPham;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SLTon;
        private Label lblTongSo;
    }
}