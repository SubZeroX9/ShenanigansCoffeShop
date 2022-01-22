using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShenanigansCoffeShop.Dal;
using ShenanigansCoffeShop.Models;
using ShenanigansCoffeShop.ViewModel;

namespace ShenanigansCoffeShop.Controllers
{
    public class ManagerController : Controller
    {
        // GET: ItemManage
        public ActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProccessAddItem(ItemModel itemToAdd)
        {
            itemToAdd.ImageToBinaryConv(Request.Files[0]);
            ItemDal itemdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = itemdal.Items.ToList<ItemModel>();
            ItemModel checkItem;
            checkItem = ivm.Items.Find(x => x.item_id == itemToAdd.item_id);
            if (checkItem != null)
            {
                ViewBag.ErrorMassage = "Item Id already Exists";
                return View("AddItem", itemToAdd);
            }

            itemToAdd.availability = true;
            itemdal.Items.Add(itemToAdd);
            itemdal.SaveChanges();

            return View("AddItem");
        }

        public ActionResult EditItem(ItemModel itemToEdit)
        {
            return View("EditItem", itemToEdit);
        }

        [HttpPost]
        public ActionResult EditItemProccess(ItemModel itemToEdit)
        {
            ItemDal itemdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = itemdal.Items.ToList<ItemModel>(); ;
            ItemModel checkItem;
            checkItem = ivm.Items.Find(x => x.item_id == itemToEdit.item_id);
            // need to add check that item id notchange to one already existing or remove possebility to change item id
            checkItem = itemToEdit;
            itemdal.SaveChanges();

            return View("Index");
        }

        public ActionResult EditTable()
        {
            ViewBag.CurrentTime = DateTime.Today.ToString("MM");
            return View();
        }

        public ActionResult TableEdit()
        {
            return View();
        }

        public ActionResult Barista()
        {
            return View();
        }
    }
}