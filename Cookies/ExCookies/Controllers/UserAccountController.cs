using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExCookies.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExCookies.Controllers
{
    [Route("")]

    [Route("[controller]/[action]")]
    public class UserAccountController : Controller
    {
       
        // GET: UserAccount
            private readonly UserAccountContext _context;

            public UserAccountController(UserAccountContext context)
            {
                _context = context;
            }
        //[Route("")]  
      
        [HttpGet]
            public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserAccount uc)
        {
            try
            {
                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.name + "has successfully registered";
                return RedirectToAction("Login");

            }
            catch(Exception e)
            {
                ViewBag.message = uc.name + "Registration failed";
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount uc)
        {
            var loguser = _context.UserAccounts.Where(e => e.name == uc.name && e.password == uc.password).ToList();
            if (loguser.Count == 0)
            {
                ViewBag.message = "Not a valid user";
                return View();

            }
            else
            {
                //to store session values
                HttpContext.Session.SetString("name", uc.name);
                //Response.Cookies.Append("lastlogin", DateTime.Now.ToString());
                //HttpContext.Session.SetString("LastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreatedashBoard");
            }
        }

        public ActionResult CreateDashBoard()
        {
            if (HttpContext.Session.GetString("name") != null)
            {
                ViewBag.name = HttpContext.Session.GetString("name").ToString();
                //ViewBag.ll = HttpContext.Session.GetString("LastLogin").ToString();
                if (Request.Cookies["lastlogin"] != null)
                    ViewBag.lldt = Request.Cookies["lastlogin"].ToString();


            }
            
           
            return View();
        }
        public ActionResult Logout()
        {
            Response.Cookies.Append("lastlogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        // GET: UserAccount/Details/5
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserAccount/Create
         public ActionResult Create()
        {
          
            return View();
        }

        // POST: UserAccount/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserAccount/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserAccount/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}