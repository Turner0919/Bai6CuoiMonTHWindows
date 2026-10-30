namespace HeThongBanHang.GUI
{
    public partial class FormQuanLyBanHang : Form
    {
        public FormQuanLyBanHang()
        {
            InitializeComponent();
        }
        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng có chắc chắn muốn thoát hay không
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu chọn Yes thì đóng ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Thoát toàn bộ chương trình
            }
        }
        private void MoFormCon(Form formCon, string tenChucNang)
        {
            panelChinh.Controls.Clear();

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            panelChinh.Controls.Add(formCon);
            panelChinh.Tag = formCon;
            formCon.Show();
            this.Text = "Bạn Đang Mở: " + tenChucNang;
        }
        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormQuanLySanPham(), "Quản Lý Sản Phẩm");
        }

        private void mnuQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new QuanLyKhachHang(), "Quản Lý Khách Hàng");
        }

        private void mnuTaoDonHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormTaoDonHang(), "Tạo Đơn Hàng");
        }

        private void mnuDanhSachDonHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new FormDanhSachDonHang(), "Danh Sách Đơn Hàng");
        }
    }
}
