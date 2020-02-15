using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeMvcValidation.Models;
using EmployeeMvcValidation.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeMvcValidation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Designation = new SelectList(new string[] { "TeamLeader", "ProjectManager", "Trainee" });

            ViewBag.Projectname = new SelectList(new string[] { "Emart", "Student", "Business"});
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee item)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int id, string pwd)
        {

            EmployeeRepository repository = new EmployeeRepository();
            Employee emp = repository.Validate(id, pwd);
            if (emp != null)
            {
                return RedirectToAction("Details",emp);
            }
            else
            {
                ViewData["err"] = "Invalid credentials";
                return View();
            }

        }
        public IActionResult SignUp()
        {
            return RedirectToAction("create");
        }


       
        public IActionResult Details(Employee item)
        {
            return View(item);
        }
    }
}