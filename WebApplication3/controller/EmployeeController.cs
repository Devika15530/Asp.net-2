using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.model;


namespace WebApplication3.controller
{
    public class EmployeeController : Controller
    {
        //IEmployeeRepository er=new EmployeeRepository();

        private readonly IEmployeeRepository employeeRepository;//dependency injected object
        public EmployeeController(IEmployeeRepository emRepository)
        {
            employeeRepository = emRepository;


        }
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);

            MyEmployee emp = employeeRepository.GetEmployee(ID);
            //if(emp!=null)
            //{
            //    return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n" + emp.Dept);
            //}
            //return Content("employee does not exist");
            //return emp.Id+"\n"+emp.Name+"\n"+emp.Email+"\n"+emp.Dept; 



            //**************************************************************************************************
            //this code is for """"viewData****
            //ViewData["id"] = emp.Id;
            //ViewData["name"] = emp.Name;
            //ViewData["email"] = emp.Email;
            //ViewData["dept"] = emp.Dept;

            //********object is passing ******//
            //ViewData["Employee"]=emp;

            //******************************************************************************************************

            //***********VIEWbag code****************************************************************************



            //ViewBag.id = emp.Id;
            //ViewBag.name = emp.Name;
            //ViewBag.email = emp.Email;
            //ViewBag.dept = emp.Dept;

            //ViewBag.employee = emp;
            //return View();



            return View(emp);
        }
        public IActionResult Index()
        {
            List<MyEmployee> elist = employeeRepository.DisplayDetails();
            return View(elist);

        }
        public ViewResult AboutEmployee()
        {
            MyEmployee emp = employeeRepository.GetEmployee(2);
            //ViewBag.projectName = "BookHive";
            EmployeeProjectView ep = new EmployeeProjectView();
            ep.employee = emp;
            ep.projectName = "Book Hive";

            return View(ep);


        }


        public IActionResult GetAllEmployees()
        {
            List<MyEmployee> elist = (employeeRepository.DisplayDetails()).Where(e => e.Dept == Dept.insurance).ToList();
            //abosulet path to refer a view
            //return View("~/Views/Employee/Index.cshtml", elist);
            return View("Index", elist);

        }
        [HttpGet]

        public IActionResult Create()
        {
            //MyEmployee emp = employeeRepository.GetEmployee(2);
            //return View(emp);
            return View();

        }
        [HttpPost]
        public IActionResult Create(MyEmployee emp)       {
            if(ModelState.IsValid)
            {
             employeeRepository.AddEmployee(emp);
                return RedirectToAction("List");
            }
            //else
            //    return View("Fail");
            return View();
        }
        public IActionResult Fail()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult List()
        {

            List<MyEmployee> elist = employeeRepository.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(MyEmployee me)
        {
            bool res = employeeRepository.AddEmployee(me);
            return RedirectToAction("Index");
           // return View();
        }
        /***Checking mail exist or not*********/
          public bool IsExist(string email)
        {
            var result = (employeeRepository.DisplayDetails()).Find(r => r.Email == email);
            if (result == null)
                return true;
            else
                return false;


        }
        [AcceptVerbs("Get","Post")]
        [AllowAnonymous]
        public JsonResult IsEmailExist(string email)
        {
            return IsExist(email) ? Json(true) : Json("Email alreay exist");
        }
        public bool IsName(string name)
        {
            var result= (employeeRepository.DisplayDetails()).Find(r => r.Name == name);
            if (result == null)
                return true;
            else
                return false;


        }
        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public JsonResult IsNameExist(string name)
        {
            return IsName(name) ? Json(true) : Json("Name alreay exist");
        }

        public IActionResult _MyPartial()
        {
            return View();
        }

    }

    }

