using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.model
{

    public class MyEmployee
    {
       public  MyEmployee()
        {

        }
        public int Id { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Length can be maximum 10")]
        [Remote(action: "IsNameExist", controller: "Employee")]//email exist or not
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$|^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}", ErrorMessage = "Please enter a valid email address or phone number")]


        [DisplayName("Company mail")]
        [ValidateDomain(allowdomain:"cts.com")]
        [Remote(action:"IsEmailExist",controller: "Employee")]
        public string Email { get; set; }
        public Dept Dept { get; set; }
        public MyEmployee(int id,string name,string email,Dept dept)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Dept = dept;
        }
    }
}
