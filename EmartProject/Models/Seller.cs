using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartProject.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string CompName { get; set; }
        public string Gstin { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public int Phno { get; set; }


        public Seller(int Id, string Name, string Password, string Email, string CompName, string Gstin, string About, string Address, string Website, int Phno)
        {
            this.Id = Id;
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.CompName = CompName;
            this.Gstin = Gstin;
            this.About = About;
            this.Address = Address;
            this.Website = Website;
            this.Phno = Phno;
        }
    }
}

