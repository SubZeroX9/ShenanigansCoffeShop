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
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Key]
        [Required]
        [RegularExpression("^[/w -/.] +@([/w -] +/.)+[/w-]{2,4}$", ErrorMessage="Please Enter a valid E-Mail")]
        public string Email { get; set; }

        public string MemberType { get; set; }

        public string UserType { get; set; }

        public string PhoneNum { get; set; }

        public DateTime BirthDay { get; set; }
    }
}