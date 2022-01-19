using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShenanigansCoffeShop.Models;

namespace ShenanigansCoffeShop.ViewModel
{
    public class UserViewModel
    {
        public UserModel User { get; set; }

        public List<UserModel> Users { get; set; }
    }
}