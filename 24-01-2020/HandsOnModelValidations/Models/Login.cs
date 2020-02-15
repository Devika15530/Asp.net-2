using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace HandsOnModelValidations.Models
{
    public class Login
    {
        [Required(ErrorMessage="please provide your name")]
        [DisplayName("Username")]
        public string Uname { get; set; }
        [Required(ErrorMessage="password is required")]
        [DisplayName("Password ")]
        public string Pwd { get; set; }

    }
}
