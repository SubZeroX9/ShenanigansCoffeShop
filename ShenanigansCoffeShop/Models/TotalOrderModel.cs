using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShenanigansCoffeShop.Models
{
    public class TotalOrderModel
    {
        [Key]
        public string o_num { get; set; }

        public DateTime o_date { get; set; }

        public float totalprice { get; set; }

        public bool currentOrder { get; set; }

        public string email_addr { get; set; }

        public int t_num { get; set; }

    }
}