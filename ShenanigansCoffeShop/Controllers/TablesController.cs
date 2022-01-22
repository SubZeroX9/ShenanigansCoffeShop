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
            // CTableDal ctable = new CTableDal();
            // TableViewModel tvm = new TableViewModel();
            // tvm.Tables = ctable.Tables.ToList<CTableModel>();

            return View("ChooseTable");//, tvm);
        }
    }
}