using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExCookies.Models
{
    
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        [DataType("password")]
        public string password { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }

    }
}
