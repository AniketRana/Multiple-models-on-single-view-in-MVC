using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleModel_InSingleView.Models;
using System.Dynamic;

namespace MultipleModel_InSingleView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var employees = GetEmployee();
            var students= GetStudent();

            //Six ways to pass multiple model on single view 

            //1-View model 
            //IndexVM model = new IndexVM();
            //model.Employees = employees; 
            //model.Students = students;  
            //return View(model);

            //2-dynamic model 
            //dynamic model = new ExpandoObject();
            //model.Employees = employees;
            //model.Students = students;  
            //return View(model);

            //3-Tuple 
            //var model = new Tuple<List<Employee>, List<Student>, string>(employees, students, "Aniket");
            //return View(model);

            //4-ViewBag 
            //ViewBag.Employees = employees;
            //ViewBag.Students = students;
            //return View();

            //5-Viewdata
            //ViewData["Employees"] = employees;
            //ViewData["Students"] = students;
            //return View();

            
            
            return View();

        }

        //6-Partial View
        public PartialViewResult Employees()
        {
            var employees = GetEmployee();
            var students = GetStudent();
            return PartialView("_EmployeeData", employees);
        }
        public PartialViewResult Students() 
        {
            var employees = GetEmployee();
            var students = GetStudent();
            return PartialView("_StudentData", students);
        }


        private List<Employee> GetEmployee()
        {
            return new List<Employee>()
            {
                new Employee(){ Id = 1,Name = "Aniket" ,Email = "Aniket@gmail.com" },
                new Employee(){ Id = 1,Name = "Rahul" ,Email = "Rahul@gmail.com" },
                new Employee(){ Id = 1,Name = "Paresh" ,Email = "Paresh@gmail.com" }
            };
        }

        private List<Student> GetStudent() 
        {
            return new List<Student>()
            {
                new Student(){ Id = 1,Name = "Jack" ,Email = "Jack@gmail.com" },
                new Student(){ Id = 1,Name = "Mack" ,Email = "Mack@gmail.com" },
                new Student(){ Id = 1,Name = "Nack" ,Email = "Nack@gmail.com" }
            };
        }
    }
}