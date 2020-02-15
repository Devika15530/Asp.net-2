using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Model
{
    public class SellerRepository:ISellerRepository
    {
        public List<Seller> s;
        public SellerRepository()
        {
            s = new List<Seller>
            { new Seller(1, 12, "dev", "dev@530", "ssss", "gfwagy", "qatwr", "twrtyer", "rwtyret", "dsge"),
               new Seller(11, 1211, "devi", "dev@5300", "ssss", "gfwagy", "qatwr", "twrtyer", "rwtyret", "dsge"),
               new Seller(111, 121, "devika", "dev@5300", "ssss", "gfwagy", "qatwr", "twrtyer", "rwtyret", "dsge")
            };
        }
        public Seller GetSeller(int id)
        {
            Seller  me = s.FirstOrDefault(e => e.Id == id);
            return me;
        }
    }
}
