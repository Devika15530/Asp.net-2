using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartProject.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }


        public Categories(int id, string name, string details)
        {
            this.Id = Id;
            this.Name = Name;
            this.Details = details;

        }
    }
}
