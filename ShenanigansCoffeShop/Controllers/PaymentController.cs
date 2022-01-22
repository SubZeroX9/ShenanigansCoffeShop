using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShenanigansCoffeShop.Dal;
using ShenanigansCoffeShop.Models;

namespace ShenanigansCoffeShop.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult CreditCardPayment()
        {
            return View();
        }

        public ActionResult CashPayment()
        {
            return View();
        }

        public ActionResult CreditCardPaymentProccess()
        {

            CTableDal ctdal = new CTableDal();
            CTableModel usedtable = ctdal.Tables.ToList().Find(x => x.t_num == ((TotalOrderModel)Session["CurrentOrdObj"]).t_num);
            usedtable.availability = true;
            ctdal.SaveChanges();

            TotalOrderDal todal = new TotalOrderDal();
            TotalOrderModel currentorder = todal.TotalOrderList.ToList().Find(x => x.o_num == ((TotalOrderModel)Session["CurrentOrdObj"]).o_num);
            currentorder.currentOrder = false;
            Session["CurrentOrdObj"] = null;

            return View("PaymentSuccess");
        }

        public ActionResult CashPaymentProccess()
        {
            string cashpayed = Request.Form["Cash"];
            if (Convert.ToInt32(cashpayed) < ((TotalOrderModel) Session["CurrentOrdObj"]).totalprice)
            {
                ViewBag.ErrorMessage = "Not Enough Cash Payed";
                return View("CashPayment");
            }
            CTableDal ctdal = new CTableDal();
            CTableModel usedtable = ctdal.Tables.ToList().Find(x => x.t_num == ((TotalOrderModel) Session["CurrentOrdObj"]).t_num);
            usedtable.availability = true;
            ctdal.SaveChanges();

            TotalOrderDal todal = new TotalOrderDal();
            TotalOrderModel currentorder = todal.TotalOrderList.ToList().Find(x => x.o_num == ((TotalOrderModel) Session["CurrentOrdObj"]).o_num);
            currentorder.currentOrder = false;
            Session["CurrentOrdObj"] = null;

            return View("PaymentSuccess");
        }
    }
}