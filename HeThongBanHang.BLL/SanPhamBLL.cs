using System;
using System.Collections.Generic;
using HeThongBanHang.DAL;
using HeThongBanHang.DAL.Models;

namespace HeThongBanHang.BLL
{
    public class SanPhamBLL
    {
        private readonly SanPhamDAL _spDAL = new SanPhamDAL();

        public List<SanPham> GetAllProducts()
        {
            try
            {
                return _spDAL.GetAll();
            }
            catch (Exception ex)
            {
                // Trả về danh sách rỗng nếu có lỗi kết nối
                return new List<SanPham>();
            }
        }

        public bool AddProduct(SanPham sp, out string errorMessage)
        {
            errorMessage = string.Empty;

            // 1. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(sp.MaSP))
            {
                errorMessage = "Mã sản phẩm không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sp.TenSP))
            {
                errorMessage = "Tên sản phẩm không được để trống!";
                return false;
            }

            // 2. Kiểm tra độ dài ký tự theo Model Schema
            if (sp.MaSP.Trim().Length > 20)
            {
                errorMessage = "Mã sản phẩm không được vượt quá 20 ký tự!";
                return false;
            }

            if (sp.TenSP.Trim().Length > 100)
            {
                errorMessage = "Tên sản phẩm không được vượt quá 100 ký tự!";
                return false;
            }

            // 3. Kiểm tra giá trị số
            if (sp.DonGia < 0)
            {
                errorMessage = "Đơn giá phải lớn hơn hoặc bằng 0!";
                return false;
            }

            if (sp.SLTon < 0)
            {
                errorMessage = "Số lượng tồn phải lớn hơn hoặc bằng 0!";
                return false;
            }

            // 4. Thao tác CSDL
            try
            {
                if (!_spDAL.Add(sp))
                {
                    errorMessage = "Mã sản phẩm này đã tồn tại trong hệ thống!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi hệ thống khi thêm sản phẩm: {ex.Message}";
                return false;
            }
        }

        public bool UpdateProduct(SanPham sp, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(sp.MaSP))
            {
                errorMessage = "Chưa chọn sản phẩm cần sửa!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sp.TenSP))
            {
                errorMessage = "Tên sản phẩm không được để trống!";
                return false;
            }

            if (sp.TenSP.Trim().Length > 100)
            {
                errorMessage = "Tên sản phẩm không được vượt quá 100 ký tự!";
                return false;
            }

            if (sp.DonGia < 0)
            {
                errorMessage = "Đơn giá phải lớn hơn hoặc bằng 0!";
                return false;
            }

            if (sp.SLTon < 0)
            {
                errorMessage = "Số lượng tồn phải lớn hơn hoặc bằng 0!";
                return false;
            }

            try
            {
                if (!_spDAL.Update(sp))
                {
                    errorMessage = "Không tìm thấy sản phẩm cần cập nhật!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi hệ thống khi cập nhật: {ex.Message}";
                return false;
            }
        }

        public bool DeleteProduct(string maSP, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(maSP))
            {
                errorMessage = "Chưa chọn sản phẩm để xóa!";
                return false;
            }

            try
            {
                if (!_spDAL.Delete(maSP))
                {
                    errorMessage = "Không tìm thấy sản phẩm cần xóa!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                // Bắt lỗi ràng buộc khóa ngoại (nếu sản phẩm đã nằm trong ChiTietHoaDon)
                errorMessage = "Không thể xóa sản phẩm này vì đã có trong dữ liệu hóa đơn/giao dịch!";
                return false;
            }
        }
    }
}