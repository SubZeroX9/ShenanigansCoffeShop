using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShenanigansCoffeShop.Controllers
{
    public class ItemManageController : Controller
    {
        // GET: ItemManage
        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult ProccessAddItem()
        {
            return View("AddItem");
        }

        public ActionResult EditItem()
        {

            return View();
        }
    }
}