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
                    return View("Index");
                }
                else
                {
                    ModelState.AddModelError("Login_Error", "* Password/Email Incorrect");
                    return View("Login");
                }
            }
            else
            {
                ModelState.AddModelError("Login_Error", "* Password/Email Incorrect");
                return View("Login");
            }
        }

        public ActionResult Register()
        {
            ViewBag.CurrentTime = DateTime.Today.ToString("yyyy-MM-dd");
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
                    userModel.l_num = "69";
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