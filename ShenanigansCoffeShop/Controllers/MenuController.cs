using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShenanigansCoffeShop.Dal;
using ShenanigansCoffeShop.Models;
using ShenanigansCoffeShop.ViewModel;

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
            ItemDal userdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = userdal.Items.OrderBy(m => m.popularity).ToList<ItemModel>().FindAll(model=> model.m_type == "HotBeverages");
            return View("HotBeverages",ivm);
        }

        public ActionResult ColdBeverages()
        {
            ItemDal userdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = userdal.Items.ToList<ItemModel>().FindAll(model => model.m_type == "ColdBeverages");
            return View("ColdBeverages", ivm);
        }

        public ActionResult CakesNCupcakes()
        {
            ItemDal userdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = userdal.Items.ToList<ItemModel>().FindAll(model => model.m_type == "CakesNCupcakes");
            return View("CakesNCupcakes", ivm);
        }
    }
}