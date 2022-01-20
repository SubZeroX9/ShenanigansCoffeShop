using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShenanigansCoffeShop.Models
{
    public class UserModel
    {
        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*/d)(?=.*[@$!%*?&])[A-Za-z/d@$!%*?&]{8,16}$",ErrorMessage = "Password length must be minimum of 8 and maximum 16 and contain at least 1 Uppercase letter, 1 LowerCase letter, 1 Number and 1 special character")]
        public string password { get; set; }

        public string fname { get; set; }

        public string l_num { get; set; }

        [Key]
        [Required]
        [RegularExpression("^[/w -/.] +@([/w -] +/.)+[/w-]{2,4}$", ErrorMessage="Please Enter a valid E-Mail")]
        public string email_addr { get; set; }

        public string membr_type { get; set; }

        public string user_type { get; set; }

        public string phone { get; set; }

        public DateTime birth_day { get; set; }
    }
}