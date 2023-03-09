using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopBanDo.Models
{
    public class CartItem
    {
        public SanPham _Shopping_product { get; set; }
        public int _shopping_quanity { get; set; }

    }
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(SanPham sp, int quantity = 1)
        {
            var i = items.FirstOrDefault(s => s._Shopping_product.MaSP == sp.MaSP);
            if(i == null)
            {
                items.Add(new CartItem
                {
                    _Shopping_product = sp,
                    _shopping_quanity = quantity,
                });
            } else
            {
                i._shopping_quanity += quantity;
            }
        }
    }
}