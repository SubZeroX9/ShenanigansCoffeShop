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

        [HttpPost]
        public ActionResult ProcessLogin(UserModel userModel)
        {
            UserDal userdal = new UserDal();
            UserViewModel uvm = new UserViewModel();
            uvm.Users = userdal.Users.ToList<UserModel>(); ;
            UserModel currentUser;

            currentUser = uvm.Users.Find(x => x.email_addr == userModel.email_addr);
            
            if (currentUser != null)
            {
                if (userModel.password.Equals(currentUser.password))
                {
                   /* ViewBag.ErrorMessage = "Password/Email Incorrect";
                    ViewData["Email"] = currentUser.email_addr;
                    ViewData["Password"] = currentUser.password;*/
                    return View("Login"); // need to add home page mabey to shared
                }
                else
                {
                    return View("Login", currentUser); //need to add return view with error email dont exist
                }
            }
            else
            {
                return View("Login", currentUser); //need to add return view with error email dont exist
            }
        }

        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult ProccessRegister(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                UserDal userdal = new UserDal();
                UserViewModel uvm = new UserViewModel();
                uvm.Users = userdal.Users.ToList<UserModel>(); ;
                UserModel currentUser;
                currentUser = uvm.Users.Find(x => x.email_addr == userModel.email_addr);
                if (currentUser == null)
                    return View("Register", userModel); // add error for email registered
                else
                {
                    userModel.membr_type = "regular";
                    userModel.user_type = "client";
                    userdal.Users.Add(userModel);
                    userdal.SaveChanges();
                    return View("RegisterSuccess");
                }
            }
            else
            {
                return View("Register", userModel);
            }
        }
    }
}