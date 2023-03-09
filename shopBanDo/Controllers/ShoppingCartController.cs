using shopBanDo.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace shopBanDo.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        MyDataDataContext data = new MyDataDataContext();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;

            }
            return cart;
        }
        public ActionResult AddtoCart(int id)
        {
            var pro = data.SanPhams.SingleOrDefault(s => s.MaSP == id);
            if(pro!= null)
            {
                GetCart().Add(pro);
            }
            return RedirectToAction("ShowToCart", "ShoppingCart");
        }

        public ActionResult ShowToCart()
        {
            if (Session["Cart"] == null)
                //dùng để điều huóng
                return RedirectToAction("ShowToCart", "ShoppingCart");
                Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult edit()
        {
            return View();
        }
    }
}