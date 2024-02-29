using EmployeeDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeDetails.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        static List<Employee> listEmployee = new List<Employee>()
        { 
            new Employee(){Email="rutuja@gmail.com",Name="Rutuja"},
             new Employee(){Email="mary@gmail.com",Name="Mary",},
              new Employee(){Email="sylvia@gmail.com",Name="Sylvia"},
               new Employee(){Email="jebaa@gmail.com",Name="Jeba"}
        };
        public ActionResult Index()
        {
            return View();
        }
    }
}