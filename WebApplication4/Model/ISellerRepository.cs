using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Model
{
   public  interface ISellerRepository
    {
        Seller GetSeller(int id);
    }
}
