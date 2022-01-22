using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShenanigansCoffeShop.Models;

namespace ShenanigansCoffeShop.ViewModel
{
    public class TotalOrderViewModel
    {
        public TotalOrderModel TotalOrder { get; set; }

        public List<TotalOrderModel> TotalOrderList { get; set; }
    }
}