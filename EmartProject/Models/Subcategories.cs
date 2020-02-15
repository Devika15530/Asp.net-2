using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartProject.Models
{
    public class Subcategories
    {
        public int SId { get; set; }
        public string SName { get; set; }
        public string SDetails { get; set; }


        public Subcategories(int id, string name, string details)
        {
            this.SId = id;
            this.SName = name;
            this.SDetails = details;

        }
    }
}
