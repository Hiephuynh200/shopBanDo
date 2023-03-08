using shopBanDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shopBanDo.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        MyDataDataContext data = new MyDataDataContext();

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