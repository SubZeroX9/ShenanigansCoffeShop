using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShenanigansCoffeShop.Models;

namespace ShenanigansCoffeShop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProcessLogin(UserModel userModel)
        {

            return View("LoginSuccess", userModel);
        }
    }
}