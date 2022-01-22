using System;
using System.Collections.Generic;
using System.IO;
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
            ItemDal itemdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = itemdal.Items.OrderBy(m => m.popularity).ToList<ItemModel>().FindAll(model=> model.m_type == "HotBeverages");
            return View("ItemDisplay",ivm);
        }

        public ActionResult ColdBeverages()
        {
            ItemDal userdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = userdal.Items.ToList<ItemModel>().FindAll(model => model.m_type == "ColdBeverages");
            return View("ItemDisplay", ivm);
        }

        public ActionResult CakesNCupcakes()
        {
            ItemDal userdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = userdal.Items.ToList<ItemModel>().FindAll(model => model.m_type == "CakesNCupcakes");
            return View("ItemDisplay", ivm);
        }
        public ActionResult Pastries()
        {
            ItemDal userdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = userdal.Items.ToList<ItemModel>().FindAll(model => model.m_type == "Pastries");
            return View("ItemDisplay", ivm);
        }

        public ActionResult Cookies()
        {
            ItemDal userdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = userdal.Items.ToList<ItemModel>().FindAll(model => model.m_type == "cookies");
            return View("ItemDisplay", ivm);
        }

        public ActionResult Sandwitches()
        {
            ItemDal userdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = userdal.Items.ToList<ItemModel>().FindAll(model => model.m_type == "sandwiches");
            return View("ItemDisplay", ivm);
        }
    }
}