using HeThongBanHang.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HeThongBanHang.GUI
{
    public partial class FormDanhSachDonHang : Form
    {
        private readonly HoaDonBLL _hdBLL = new HoaDonBLL();
        public FormDanhSachDonHang()
        {
            InitializeComponent();
        }

        private void FormDanhSachDonHang_Load(object sender, EventArgs e)
        {
            InitDataGridViews();
            LoadData();
        }
        private void InitDataGridViews()
        {
            // 1. Cấu hình DataGridView Danh Sách Đơn Hàng (Bảng trên)
            dgvDanhSachDonHang.Columns.Clear();
            dgvDanhSachDonHang.AutoGenerateColumns = false;
            SetupDgvStyle(dgvDanhSachDonHang);

            dgvDanhSachDonHang.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaHD", DataPropertyName = "MaHD", HeaderText = "Mã ĐH", Width = 100 });
            dgvDanhSachDonHang.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenKhachHang", DataPropertyName = "TenKhachHang", HeaderText = "Khách Hàng", Width = 220 });
            dgvDanhSachDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NgayLap",
                DataPropertyName = "NgayLap",
                HeaderText = "Ngày Đặt",
                Width = 160,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });
            dgvDanhSachDonHang.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", DataPropertyName = "TrangThai", HeaderText = "Trạng Thái", Width = 140 });

            // 2. Cấu hình DataGridView Chi Tiết Đơn Hàng (Bảng dưới)
            dgvChiTietDonHang.Columns.Clear();
            dgvChiTietDonHang.AutoGenerateColumns = false;
            SetupDgvStyle(dgvChiTietDonHang);

            dgvChiTietDonHang.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenSP", DataPropertyName = "TenSP", HeaderText = "Sản Phẩm", Width = 280 });
            dgvChiTietDonHang.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuong", DataPropertyName = "SoLuong", HeaderText = "SL", Width = 80 });
            dgvChiTietDonHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                DataPropertyName = "DonGia",
                HeaderText = "Đơn Giá Lúc Bán",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
        }

        private void SetupDgvStyle(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.ForeColor = Color.Black;
        }

        private void LoadData()
        {
            try
            {
                var listHD = _hdBLL.GetAllOrders();

                dgvDanhSachDonHang.DataSource = null;
                dgvDanhSachDonHang.DataSource = listHD;
                dgvDanhSachDonHang.ClearSelection();

                // Dọn sạch bảng chi tiết
                dgvChiTietDonHang.DataSource = null;

                lblTongSoDonHang.Text = $"Tổng số đơn hàng: {listHD.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvDanhSachDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSachDonHang.Rows.Count)
            {
                var row = dgvDanhSachDonHang.Rows[e.RowIndex];
                if (int.TryParse(row.Cells["MaHD"].Value?.ToString(), out int maHD))
                {
                    var listChiTiet = _hdBLL.GetOrderDetails(maHD);
                    dgvChiTietDonHang.DataSource = null;
                    dgvChiTietDonHang.DataSource = listChiTiet;
                    dgvChiTietDonHang.ClearSelection();
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachDonHang.CurrentRow == null || dgvDanhSachDonHang.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvDanhSachDonHang.CurrentRow;
            int maHD = Convert.ToInt32(row.Cells["MaHD"].Value);
            string trangThai = row.Cells["TrangThai"].Value?.ToString();

            if (trangThai == "Đã Hủy")
            {
                MessageBox.Show("Đơn hàng này đã được hủy trước đó rồi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn HỦY đơn hàng #{maHD}?\n(Số lượng sản phẩm sẽ được cộng hoàn trả lại vào kho)",
                                          "Xác nhận hủy đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (_hdBLL.CancelOrder(maHD, out string error))
                {
                    MessageBox.Show("Hủy đơn hàng thành công và đã hoàn trả số lượng vào kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Nạp lại danh sách
                }
                else
                {
                    MessageBox.Show(error, "Lỗi hủy đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.CellStyle.ForeColor = Color.Black;
            }
        }
    }
}
