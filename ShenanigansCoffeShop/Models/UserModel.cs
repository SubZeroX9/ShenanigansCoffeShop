using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShenanigansCoffeShop.Models
{
    public class UserModel
    {
        [Key]
        [Required]
        [RegularExpression("^[/w -/.] +@([/w -] +/.)+[/w-]{2,4}$", ErrorMessage = "Please Enter a valid E-Mail")]
        public string email_addr { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First Name must be a minimum of 2 letters and max of 50")]
        public string fname { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last Name must be a minimum of 2 letters and max of 50")]
        public string lname { get; set; }

        
        public string membr_type { get; set; }

        public string user_type { get; set; }

        [Required]
        public DateTime birth_day { get; set; }

        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*/d)(?=.*[@$!%*?&])[A-Za-z/d@$!%*?&]{8,16}$",ErrorMessage = "Password contain at least 1 Uppercase letter, 1 LowerCase letter, 1 Number and 1 special character")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "password length must be minimum of 8 and maximum 16")]
        public string password { get; set; }


        [StringLength(16, MinimumLength = 8, ErrorMessage = "Phone number must be a minimum of 8 digits")]
        public string phone { get; set; }

        public string l_num { get; set; }

    }
}