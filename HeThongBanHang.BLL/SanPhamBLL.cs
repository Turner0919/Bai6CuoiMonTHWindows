using HeThongBanHang.DAL;
using HeThongBanHang.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeThongBanHang.BLL
{
    public class SanPhamBLL
    {
        private readonly SanPhamDAL spDAL = new SanPhamDAL();

        public List<SanPham> GetAllProducts()
        {
            return spDAL.GetAll();
        }

        public void AddProduct(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new Exception("Mã sản phẩm không được để trống!");

            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new Exception("Tên sản phẩm không được để trống!");

            if (sp.DonGia < 0)
                throw new Exception("Đơn giá phải lớn hơn hoặc bằng 0!");

            if (sp.SLTon < 0)
                throw new Exception("Số lượng tồn phải lớn hơn hoặc bằng 0!");

            if (spDAL.GetById(sp.MaSP) != null)
                throw new Exception("Mã sản phẩm đã tồn tại!");

            spDAL.Add(sp);
        }

        public void UpdateProduct(SanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new Exception("Vui lòng chọn sản phẩm cần sửa!");

            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new Exception("Tên sản phẩm không được để trống!");

            if (sp.DonGia < 0)
                throw new Exception("Đơn giá phải lớn hơn hoặc bằng 0!");

            if (sp.SLTon < 0)
                throw new Exception("Số lượng tồn phải lớn hơn hoặc bằng 0!");

            if (spDAL.GetById(sp.MaSP) == null)
                throw new Exception("Sản phẩm không tồn tại!");

            spDAL.Update(sp);
        }

        public void DeleteProduct(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new Exception("Vui lòng chọn sản phẩm cần xóa!");

            if (spDAL.GetById(maSP) == null)
                throw new Exception("Sản phẩm không tồn tại!");

            spDAL.Delete(maSP);
        }
    }
}
