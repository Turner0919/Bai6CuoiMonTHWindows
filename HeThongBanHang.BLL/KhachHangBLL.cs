using System;
using System.Collections.Generic;
using HeThongBanHang.DAL;
using HeThongBanHang.DAL.Models;

namespace HeThongBanHang.BLL
{
    public class KhachHangBLL
    {
        private readonly KhachHangDAL _khDAL = new KhachHangDAL();

        public List<KhachHang> GetAllCustomers()
        {
            try
            {
                return _khDAL.GetAll();
            }
            catch
            {
                return new List<KhachHang>();
            }
        }

        public bool AddCustomer(KhachHang kh, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(kh.SoDienThoai))
            {
                errorMessage = "Số điện thoại không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(kh.HoTen))
            {
                errorMessage = "Họ tên khách hàng không được để trống!";
                return false;
            }

            string sdt = kh.SoDienThoai.Trim();
            if (sdt.Length != 10 || !long.TryParse(sdt, out _))
            {
                errorMessage = "Số điện thoại phải nhập đúng 10 chữ số!";
                return false;
            }

            try
            {
                if (!_khDAL.Add(kh))
                {
                    errorMessage = "Số điện thoại này đã tồn tại trong hệ thống!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi hệ thống: {ex.Message}";
                return false;
            }
        }

        public bool UpdateCustomer(KhachHang kh, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(kh.SoDienThoai))
            {
                errorMessage = "Chưa chọn khách hàng cần sửa!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(kh.HoTen))
            {
                errorMessage = "Họ tên khách hàng không được để trống!";
                return false;
            }

            try
            {
                if (!_khDAL.Update(kh))
                {
                    errorMessage = "Không tìm thấy khách hàng để cập nhật!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi hệ thống: {ex.Message}";
                return false;
            }
        }

        public bool DeleteCustomer(string sdt, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(sdt))
            {
                errorMessage = "Chưa chọn khách hàng để xóa!";
                return false;
            }

            try
            {
                if (!_khDAL.Delete(sdt))
                {
                    errorMessage = "Không tìm thấy khách hàng cần xóa!";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "Không thể xóa khách hàng này vì đã có lịch sử hóa đơn!";
                return false;
            }
        }
    }
}