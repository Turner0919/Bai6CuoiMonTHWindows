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
    public partial class QuanLyKhachHang : Form
    {
        private readonly KhachHangBLL _khBLL = new KhachHangBLL();
        public QuanLyKhachHang()
        {
            InitializeComponent();
            this.Load += FormQuanLyKhachHang_Load;
        }
        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            InitDataGridView();
            LoadData();
        }
        private void InitDataGridView()
        {
            //dgvKhachHang.Columns.Clear();
            dgvKhachHang.AutoGenerateColumns = false;

            // Định dạng màu sắc chuẩn chữ ĐEN trên nền Trắng
            dgvKhachHang.DefaultCellStyle.ForeColor = Color.Black;
            dgvKhachHang.DefaultCellStyle.BackColor = Color.White;
            dgvKhachHang.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvKhachHang.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvKhachHang.ForeColor = Color.Black;
        }
        private void LoadData()
        {
            try
            {
                List<KhachHang> listKH = _khBLL.GetAllCustomers();

                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = listKH;
                dgvKhachHang.ClearSelection(); // Tự động bỏ chọn hàng bôi xanh

                lblTongSoKH.Text = $"Tổng số khách hàng: {listKH.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtSoDienThoai.Enabled = true; // Mở khóa Số điện thoại khi thêm mới
            txtHoTen.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang
            {
                HoTen = txtHoTen.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim()
            };

            if (_khBLL.AddCustomer(kh, out string error))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            KhachHang kh = new KhachHang
            {
                HoTen = txtHoTen.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim()
            };

            if (_khBLL.UpdateCustomer(kh, out string error))
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string sdt = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng có SĐT {sdt}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (_khBLL.DeleteCustomer(sdt, out string error))
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();

                txtSoDienThoai.Enabled = false; // Khóa SĐT không cho sửa khóa chính
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
