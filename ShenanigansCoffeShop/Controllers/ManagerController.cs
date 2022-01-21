using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public ActionResult ProccessAddItem(ItemModel itemToAdd)
        {
            ItemDal itemdal = new ItemDal();
            ItemViewModel ivm = new ItemViewModel();
            ivm.Items = itemdal.Items.ToList<ItemModel>(); ;
            ItemModel checkItem;
            checkItem = ivm.Items.Find(x => x.item_id == itemToAdd.item_id);
            if (checkItem != null)
            {
                ViewBag.ErrorMassage = "Item Id already Exists";
                return View("AddItem", itemToAdd);
            }


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

        public ActionResult EditTables()
        {



            return View("Index");
        }
    }
}