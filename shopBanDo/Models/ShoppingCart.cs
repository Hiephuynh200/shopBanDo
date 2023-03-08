using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shopBanDo.Models
{
    public class ShoppingCart
    {
        MyDataDataContext data = new MyDataDataContext();
        public int MaHD { get; set; }
        [Display(Name = "Mã Hóa Đơn")]
        public string MaSp { get; set; }
        [Display(Name = "Mã Sản Phẩm")]
        public string MaNV { get; set; }
        [Display(Name = "Mã Nhân Viên")]
        public string MaKH { get; set; }
        [Display(Name = "Mã Khách Hàng")]
        public DateTime NgayDatHang { get; set; }
        [Display(Name = "Ngày Đặt Hàng")]
        public double giaBan { get; set; }
        [Display(Name = "Giá Bán")]
        public double SoLuong  { get; set; }
        [Display(Name = "Số Lượng")]
        public double thanhtien
        {
            get { return giaBan * SoLuong; }
        }
        public ShoppingCart(int id)
        {
        }
    }
}