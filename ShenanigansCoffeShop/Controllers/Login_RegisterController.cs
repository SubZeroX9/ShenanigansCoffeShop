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
    public class Login_RegisterController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult ProcessLogin(UserModel userModel)
        {
            UserDal userdal = new UserDal();
            UserViewModel uvm = new UserViewModel();
            uvm.Users = userdal.Users.ToList<UserModel>();

            return View("Login", userModel);
        }

        public ActionResult Register()
        {
            return View("Register");
        }

        public ActionResult ProccessRegister(UserModel user)
        {
            if (ModelState.IsValid)
            {
                UserDal userdal = new UserDal();



                return View("Login");
            }
            else
            {
                return View("Register",user);
            }


            return View("Register", user);
        }
    }
}