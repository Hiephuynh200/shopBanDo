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
        public int MaSp { get; set; }
        [Display(Name = "Mã Sản Phẩm")]
        public float KhuyenMai { get; set; }
        [Display(Name = "Khuyến mãi")]
        public float TongTien { get; set; }
        [Display(Name = "Tổng Tiền")]
        public DateTime NgayLapHoaDon{ get; set; }
        [Display(Name = "Ngày lập hóa đơn")]
        public string Email { get; set; }
        [Display(Name = "Email")]
        public int SoLuongSanPham{ get; set; }
        [Display(Name = "Số Lượng Sản Phẩm")]
        public float DonGia { get; set; }
        [Display(Name ="Đơn giá")]
        public double thanhtien
        {
            get { return DonGia * SoLuongSanPham; }
        }
        public ShoppingCart(int id)
        {
            MaHD = id;
            ShoppingCart shoppingCart = data.ChiTietHoaDons.SingleOrDefault(n => n.MaHD == MaHD);
            MaSp = shoppingCart.MaSp;
            KhuyenMai = shoppingCart.KhuyenMai;
            TongTien = shoppingCart.TongTien;
            NgayLapHoaDon = shoppingCart.NgayLapHoaDon;
            Email = shoppingCart.Email;
            SoLuongSanPham = shoppingCart.SoLuongSanPham;
            DonGia = shoppingCart.DonGia;
        }
    }
}