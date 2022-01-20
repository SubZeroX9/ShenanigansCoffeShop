using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShenanigansCoffeShop.Models
{
    public class ItemModel
    {
        [Key]
        public string item_id { get; set; }

        public string item_name { get; set; }

        public float price { get; set; }

        public string descript { get; set; }

        public bool availability { get; set; }

        public float popularity { get; set; }

        public string m_type { get; set; }

        public string image_url { get; set; }
    }
}