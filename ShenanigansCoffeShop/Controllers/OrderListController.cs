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
    public class OrderListController : Controller
    {
        // GET: OrderList
        public ActionResult OrderList()
        {
            return View();
        }

        public ActionResult AddToOrderList(OrderListModel item)
        {
            OrderListModel newItem = new OrderListModel();
            newItem.item_id = item.item_id;
            newItem.item_name = item.item_name;
            newItem.price = item.price;

            return View();
        }
    }
}