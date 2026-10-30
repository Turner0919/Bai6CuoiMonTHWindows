using HeThongBanHang.BLL;
using HeThongBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HeThongBanHang.GUI
{
    public partial class FormQuanLySanPham : Form
    {
        private readonly SanPhamBLL _spBLL = new SanPhamBLL();
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }
        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            InitDataGridView(); // Khởi tạo cột và định dạng màu 1 lần duy nhất
            LoadData();
        }
        private void InitDataGridView()
        {
            dgvSanPham.Columns.Clear();
            dgvSanPham.AutoGenerateColumns = false;

            // ÉP CỨNG MÀU NỀN VÀ MÀU CHỮ
            dgvSanPham.BackgroundColor = Color.White;
            dgvSanPham.DefaultCellStyle.BackColor = Color.White;
            dgvSanPham.DefaultCellStyle.ForeColor = Color.Black; // Chữ ĐEN khi KHÔNG CHỌN
            dgvSanPham.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue; // Nền xanh nhạt khi CHỌN
            dgvSanPham.DefaultCellStyle.SelectionForeColor = Color.Black; // Chữ ĐEN khi ĐƯỢC CHỌN

            // Tạo 4 cột
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaSP", DataPropertyName = "MaSP", HeaderText = "Mã SP", Width = 100 });
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenSP", DataPropertyName = "TenSP", HeaderText = "Tên Sản Phẩm", Width = 200 });
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { Name = "DonGia", DataPropertyName = "DonGia", HeaderText = "Đơn Giá", Width = 120 });
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { Name = "SLTon", DataPropertyName = "SLTon", HeaderText = "SL Tồn", Width = 80 });
        }
        private void LoadData()
        {
            try
            {
                List<SanPham> listSP = _spBLL.GetAllProducts();

                // Gán lại DataSource
                dgvSanPham.DataSource = null;
                dgvSanPham.DataSource = listSP;
                dgvSanPham.ClearSelection();
                // Cập nhật số lượng
                lblTongSoSP.Text = $"Tổng số sản phẩm: {listSP.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonGia.Clear();
            txtSLTon.Clear();
            txtMaSP.Enabled = true; // Mở lại cho phép nhập Mã SP khi thêm mới
            txtMaSP.Focus();
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSLTon.Text.Trim(), out int slTon))
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPham sp = new SanPham
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                DonGia = donGia,
                SLTon = slTon
            };

            if (_spBLL.AddProduct(sp, out string error))
            {
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadData();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia))
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSLTon.Text.Trim(), out int slTon))
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPham sp = new SanPham
            {
                MaSP = txtMaSP.Text.Trim(),
                TenSP = txtTenSP.Text.Trim(),
                DonGia = donGia,
                SLTon = slTon
            };

            if (_spBLL.UpdateProduct(sp, out string error))
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadData();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã SP cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (_spBLL.DeleteProduct(maSP, out string error))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
                //txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
                // Ép kiểu decimal để cắt bỏ đuôi .00 khi đưa lên TextBox
                if (decimal.TryParse(row.Cells["DonGia"].Value?.ToString(), out decimal donGia))
                {
                    txtDonGia.Text = donGia.ToString("0"); // Hoặc donGia.ToString("N0") nếu muốn có dấu phẩy phân cách
                }
                else
                {
                    txtDonGia.Text = string.Empty;
                }
                txtSLTon.Text = row.Cells["SLTon"].Value?.ToString();

                txtMaSP.Enabled = false;
            }
        }
        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ép màu chữ của tất cả các ô luôn luôn là màu ĐEN
                e.CellStyle.ForeColor = Color.Black;
            }
        }
    }
}
