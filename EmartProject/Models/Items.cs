using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmart.Models
{
    public class Items
    {
        //id,catid,subcatid,price,itemname,desc,stocknum,remarks
             public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Price { get; set; }
        public string Itemname { get; set; }
        public int Catid { get; set; }


    }
}
