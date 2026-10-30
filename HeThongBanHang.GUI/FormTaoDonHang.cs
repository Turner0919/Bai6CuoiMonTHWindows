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
    public partial class FormTaoDonHang : Form
    {
        private readonly KhachHangBLL _khBLL = new KhachHangBLL();
        private readonly SanPhamBLL _spBLL = new SanPhamBLL();
        private readonly HoaDonBLL _hdBLL = new HoaDonBLL();
        private List<GioHangItem> _gioHang = new List<GioHangItem>();
        public FormTaoDonHang()
        {
            InitializeComponent();

        }
        private void FormTaoDonHang_Load(object sender, EventArgs e)
        {
            InitDataGridView();
            LoadKhachHang();

            // BAN ĐẦU CHƯA CHỌN KHÁCH HÀNG -> KHÓA COMBOBOX SẢN PHẨM
            cboSanPham.Enabled = false;
            nudSoLuong.Enabled = false;
            btnAdd.Enabled = false;

            // Đăng ký sự kiện khi đổi Khách hàng
            //cboKhachHang.SelectedIndexChanged += cboKhachHang_SelectedIndexChanged;
        }
        private void InitDataGridView()
        {
            //dgvGioHang.Columns.Clear();
            dgvGioHang.AutoGenerateColumns = false;

            dgvGioHang.BackgroundColor = Color.White;
            dgvGioHang.DefaultCellStyle.BackColor = Color.White;
            dgvGioHang.DefaultCellStyle.ForeColor = Color.Black;
            dgvGioHang.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvGioHang.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvGioHang.ForeColor = Color.Black;
        }
        private void LoadKhachHang()
        {
            var listKH = _khBLL.GetAllCustomers();
            cboKhachHang.DataSource = listKH;
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "SoDienThoai";
            cboKhachHang.SelectedIndex = -1; // Chưa chọn ai lúc vừa mở Form
        }

        private void LoadSanPham()
        {
            var listSP = _spBLL.GetAllProducts();
            cboSanPham.DataSource = listSP;
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
            cboSanPham.SelectedIndex = -1;
        }
        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedIndex >= 0)
            {
                cboSanPham.Enabled = true;
                nudSoLuong.Enabled = true;
                btnAdd.Enabled = true;

                // Nạp sản phẩm nếu chưa nạp
                if (cboSanPham.DataSource == null)
                {
                    LoadSanPham();
                }
            }
            else
            {
                cboSanPham.Enabled = false;
                nudSoLuong.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPham spSelected = (SanPham)cboSanPham.SelectedItem;
            int soLuongMua = (int)nudSoLuong.Value;

            if (soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tồn kho
            int slTrongGio = _gioHang.Where(x => x.MaSP == spSelected.MaSP).Sum(x => x.SoLuong);
            if (soLuongMua + slTrongGio > spSelected.SLTon)
            {
                MessageBox.Show($"Số lượng tồn kho không đủ! (Còn tồn: {spSelected.SLTon})", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu đã có trong giỏ hàng thì cộng dồn số lượng, chưa có thì thêm mới
            var itemInCart = _gioHang.FirstOrDefault(x => x.MaSP == spSelected.MaSP);
            if (itemInCart != null)
            {
                itemInCart.SoLuong += soLuongMua;
            }
            else
            {
                _gioHang.Add(new GioHangItem
                {
                    MaSP = spSelected.MaSP,
                    TenSP = spSelected.TenSP,
                    SoLuong = soLuongMua,
                    DonGia = spSelected.DonGia
                });
            }

            RefreshGioHang();
        }
        private void btnXoaKhoiGio_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null && dgvGioHang.CurrentRow.Index >= 0)
            {
                int index = dgvGioHang.CurrentRow.Index;
                if (index < _gioHang.Count)
                {
                    _gioHang.RemoveAt(index);
                    RefreshGioHang();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RefreshGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = _gioHang.ToList();
            dgvGioHang.ClearSelection();

            // Tự động tính tổng tiền giỏ hàng
            decimal tongTien = _gioHang.Sum(x => x.ThanhTien);
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0}đ";
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sdtKH = cboKhachHang.SelectedValue.ToString();

            if (_hdBLL.TaoDonHang(sdtKH, _gioHang, out string error))
            {
                MessageBox.Show("Tạo đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset giao diện sau khi đặt hàng thành công
                _gioHang.Clear();
                RefreshGioHang();
                cboKhachHang.SelectedIndex = -1;
                cboSanPham.SelectedIndex = -1;
                nudSoLuong.Value = 1;
            }
            else
            {
                MessageBox.Show(error, "Lỗi đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvGioHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                e.CellStyle.ForeColor = Color.Black;
            }
        }
    }
}
