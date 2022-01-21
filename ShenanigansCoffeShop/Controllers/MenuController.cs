using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShenanigansCoffeShop.Controllers
{
    public class MenuController : Controller
    {

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult HotBeverages()
        {
            return View();
        }

        public ActionResult ColdBeverages()
        {
            return View();
        }

        public ActionResult CakesNCupcakes()
        {
            return View();
        }
    }
}