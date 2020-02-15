using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Model;

namespace WebApplication4.controller
{
    public class SellerController:Controller
    {
        //ISellerRepository sr = new SellerRepository();
        public ISellerRepository seller1;
        public SellerController(ISellerRepository seller)
        {
            this.seller1 = seller;
        }
        public IActionResult Search(int id)
        {
            Seller s = seller1.GetSeller(id);

            //ViewData["id"] = s.Id;



            //ViewData["name"] = s.Name;
            //ViewData["email"] = s.Email;
            //ViewData["phno"] = s.Phno;
            //ViewData["About"] = s.Cabout;
            //ViewData["compname"] = s.compname;
            //ViewData["Website"] = s.Cweb;
            //ViewData["Gstin"] = s.Gstin;
            //ViewData["password"] = s.Pswd;
            //ViewData["Adress"] = s.Cadress;
            //ViewData["Seller"] = s;
            ViewData["Employee"] = s;

            return View();
            //return Content(s.Cabout +"\n"+ s.Cadress+"\n"  + s.Cadress + "\n" + s.compname + "\n" + s.Cweb + "\n" + s.Email + "\n" + s.Gstin + "\n" + s.Id + "\n" + s.Name + "\n" + s.Phno + "\n");
        }



    }
}
