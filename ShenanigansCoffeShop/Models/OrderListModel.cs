using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace ShenanigansCoffeShop.Models
{
    public class OrderListModel
    {
        [Key]
        public string item_id { get; set; }

        public string item_name { get; set; }

        public float price { get; set; }

    }
}