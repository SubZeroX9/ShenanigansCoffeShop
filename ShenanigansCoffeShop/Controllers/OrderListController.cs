using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShenanigansCoffeShop.Controllers
{
    public class OrderListController : Controller
    {
        // GET: OrderList
        public ActionResult OrderList()
        {
            return View();
        }

        public ActionResult AddToOrderList()
        {
            return View();
        }
    }
}