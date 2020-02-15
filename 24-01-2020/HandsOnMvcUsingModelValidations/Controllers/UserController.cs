using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMvcUsingModelValidations.Models;
using HandsOnMvcUsingModelValidations.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMvcUsingModelValidations.Controllers
{
    public class UserController : Controller
    {
            public IActionResult Index()
            {
                return View();
            }
            [HttpGet]
            public IActionResult Create()
            {
                ViewBag.Country = new SelectList(new string[] { "India", "China", "Us", "Uk" });
                return View();
            }
            [HttpPost]
            public IActionResult Create(User item)
            {
            //UserRepository repository = new UserRepository();
            //repository.Add(item);
            //return RedirectToAction("Login");

            if (ModelState.IsValid)//modelstate validates model
            {
                return RedirectToAction("Index");
            }
            else
                return View();

        }
            [HttpGet]
            public IActionResult Login()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Login(string uname, string pwd)
            {
                UserRepository repository = new UserRepository();
                User user = repository.Validate(uname, pwd);
                if (user != null)
                {
                    return RedirectToAction("Details", user);
                }
                else
                {
                    ViewData["err"] = "Invalid credentials";
                    return View();
                }

            }
            public IActionResult Details([Bind(include: "name")]User item)
            {
                return View(item);
            }
        }

       

    }
