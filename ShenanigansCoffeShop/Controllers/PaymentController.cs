﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}