using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
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
            if (Session["CurrentOrderObj"] == null)
            {
                return View("OrderList");
            }
            else
            {
                string curOrdNum = ((TotalOrderModel) Session["CurrentOrderObj"]).o_num;
                OrderListDal OLdal = new OrderListDal();
                OrderListViewModel olvm = new OrderListViewModel();
                olvm.Orders = OLdal.OrderList.ToList().FindAll(x => x.o_num == curOrdNum);
                return View("OrderList", olvm);
            }
        }

        public ActionResult AddToOrderList(OrderListModel item)
        {
            if (Session["CurrentOrderObj"] == null)
            {
                TotalOrderDal totalOrderDal = new TotalOrderDal();
                string NewOrderNum =(Convert.ToInt64(totalOrderDal.TotalOrderList.Max(x => x.o_num))+1).ToString();
                TotalOrderModel newTotalOrder = new TotalOrderModel();
                newTotalOrder.o_num = NewOrderNum;
                newTotalOrder.email_addr = ((UserModel) Session["CurrentUserObj"]).email_addr;
                newTotalOrder.currentOrder = true;
                DateTime newDate = DateTime.Now;
                newTotalOrder.o_date =new DateTime(newDate.Year, newDate.Month, newDate.Day);
                newTotalOrder.totalprice = 0;
                totalOrderDal.TotalOrderList.Add(newTotalOrder);
                totalOrderDal.SaveChanges();
                Session["CurrentOrderObj"] = newTotalOrder;
            }

            string orderNum = ((TotalOrderModel) Session["CurrentOrderObj"]).o_num;
            OrderListDal OLdal = new OrderListDal();
            OrderListViewModel TOvm = new OrderListViewModel();
            
            OrderListModel checkItem = OLdal.OrderList.ToList().Where(x => x.o_num == orderNum && x.item_id == item.item_id).FirstOrDefault();
            if (checkItem != null)
            {
                checkItem.num_of_orders++;
            }
            else
            {
                OrderListModel newItem = new OrderListModel();
                newItem.item_id = item.item_id;
                newItem.item_name = item.item_name;
                newItem.price = item.price;
                newItem.num_of_orders = 1;
                newItem.o_num = ((TotalOrderModel)Session["CurrentOrderObj"]).o_num;
                OLdal.OrderList.Add(newItem);
            }

            OLdal.SaveChanges();
            TotalOrderDal todal = new TotalOrderDal();
            Session["CurrentOrderObj"] = todal.TotalOrderList.ToList().Find(x => x.o_num == ((TotalOrderModel)Session["CurrentOrderObj"]).o_num);
            TOvm.Orders = OLdal.OrderList.ToList().FindAll(x => x.o_num == orderNum);
            return View("OrderList", TOvm);
        }
    }
}