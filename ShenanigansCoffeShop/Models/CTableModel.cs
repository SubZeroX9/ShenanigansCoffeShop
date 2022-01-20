using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShenanigansCoffeShop.Models
{
    public class CTableModel
    {
        public int t_num { get; set; }

        public string t_type { get; set; }

        public bool availability { get; set; }

        public int s_num { get; set; }

        public string l_num { get; set; }
    }
}