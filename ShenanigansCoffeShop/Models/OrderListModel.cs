using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(Order = 1)]
        public string o_num { get; set; }
        [Key]
        [Column(Order = 2)]
        public string item_id { get; set; }
        public int num_of_orders { get; set; }

        public string item_name { get; set; }
        
        public float price { get; set; }
    }
}