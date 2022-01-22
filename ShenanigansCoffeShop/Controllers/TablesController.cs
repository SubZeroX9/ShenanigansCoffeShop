using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShenanigansCoffeShop.Models;
using ShenanigansCoffeShop.ViewModel;
using ShenanigansCoffeShop.Dal;
namespace ShenanigansCoffeShop.Controllers
{
    public class TablesController : Controller
    {
        // GET: Tables
        public ActionResult ChooseTable()
        {
            CTableDal ctable = new CTableDal();
            TableViewModel tvm = new TableViewModel();
            tvm.Tables = ctable.Tables.ToList<CTableModel>();

            return View("ChooseTable", tvm);
        }

        public ActionResult ChooseTableProccess(CTableModel table)
        {
            if (Session["CurrentOrderObj"] == null)
            {
                TotalOrderDal totalOrderDal = new TotalOrderDal();
                string NewOrderNum = (Convert.ToInt64(totalOrderDal.TotalOrderList.Max(x => x.o_num)) + 1).ToString();
                TotalOrderModel newTotalOrder = new TotalOrderModel();
                newTotalOrder.o_num = NewOrderNum;
                newTotalOrder.email_addr = ((UserModel)Session["CurrentUserObj"]).email_addr;
                newTotalOrder.currentOrder = true;
                DateTime newDate = DateTime.Now;
                newTotalOrder.o_date = new DateTime(newDate.Year, newDate.Month, newDate.Day);
                newTotalOrder.totalprice = 0;
                newTotalOrder.t_num = table.t_num;
                totalOrderDal.TotalOrderList.Add(newTotalOrder);
                totalOrderDal.SaveChanges();
                Session["CurrentOrderObj"] = newTotalOrder;
            }
            else
            {
                if (((TotalOrderModel) Session["CurrentOrderObj"]).t_num != null)
                {
                    CTableDal CTdal = new CTableDal();
                    CTableModel prevTable = CTdal.Tables.Where(x => x.s_num == ((TotalOrderModel)Session["CurrentOrderObj"]).t_num).FirstOrDefault();
                    prevTable.availability = true;
                    CTdal.SaveChanges();
                }

                TotalOrderDal totalOrderDal = new TotalOrderDal();
                TotalOrderModel currentOrder = totalOrderDal.TotalOrderList.Where(x => x.o_num == ((TotalOrderModel) Session["CurrentOrderObj"]).o_num).FirstOrDefault();
                currentOrder.t_num = table.t_num;
                totalOrderDal.SaveChanges();
                Session["CurrentOrderObj"] = currentOrder;
            }

            CTableDal ctDal = new CTableDal();
            CTableModel tableModel = ctDal.Tables.Where(x => x.s_num == table.t_num).FirstOrDefault();
            tableModel.availability = false;
            ctDal.SaveChanges();

            return View("Index");
        }
    }
}