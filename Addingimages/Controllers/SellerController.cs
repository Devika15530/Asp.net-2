         using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Addingimages.Models;
using Addingimages.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Addingimages.Controllers
{
    public class SellerController : Controller
    {
        // GET: Seller


        private readonly SellerContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        public SellerController(SellerContext context,IWebHostEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;

            _context = context;
        }

       




        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SellerCreateViewModel scv)
        {
           
                if (ModelState.IsValid)
                {
                    string uniqueFileName = null;

                    // If the Photo property on the incoming model object is not null, then the user
                    // has selected an image to upload.
                    if (scv.photopath != null)
                    {
                        // The image must be uploaded to the images folder in wwwroot
                        // To get the path of the wwwroot folder we are using the inject
                        // HostingEnvironment service provided by ASP.NET Core
                        string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        // To make sure the file name is unique we are appending a new
                        // GUID value and and an underscore to the file name
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + scv.photopath.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        // Use CopyTo() method provided by IFormFile interface to
                        // copy the file to wwwroot/images folder
                        scv.photopath.CopyTo(new FileStream(filePath, FileMode.Create));
                    }

                    Seller newSeller = new Seller
                    {
                        Name = scv.Name,
                        Email = scv.Email,
                        Password = scv.Password,
                        // Store the file name in PhotoPath property of the employee object
                        // which gets saved to the Employees database table
                        photopath = uniqueFileName
                    };

                    _context.Add(newSeller);
                    _context.SaveChanges();
                    return RedirectToAction("Details", new { id = newSeller.Id });
                }

                return View();
            }
        public ActionResult Details(int id)
        {
            Seller seller = _context.SellerAccounts.FirstOrDefault(m => m.Id == id);
            if(seller==null)
            {
                ViewBag.message = "not a valid seller";
               
            }

            return View(seller);
        }

      
    }
}