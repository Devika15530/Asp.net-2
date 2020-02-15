using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HandsOnMvcUsingModelValidations.Models
{
    public class User
    {
        [Required(ErrorMessage = "please provide your name")]
        [DisplayName("Username")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Inavalid Email ")]
        [Required(ErrorMessage = "please provide your Email")]
        public string Email { get; set; }
        //[Required (ErrorMessage = "please provide your Dob")]
        [DataType (DataType.Date)]
        public DateTime DOB { get; set; }

        [RegularExpression(@"[6-9)]\d{9}", ErrorMessage = "Invalid Mobile No")]
        [Required(ErrorMessage = "mobile number is required")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "please provide your Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "please provide your UName")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string  Pwd{ get; set; }
        [Compare("Pwd", ErrorMessage = "Password mismatch")]
        public string Cpwd { get; set; }

    }
}
