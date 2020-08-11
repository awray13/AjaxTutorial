using AjaxTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxTutorial.Controllers
{
    

    public class EmployeesController : Controller
    {
        private DBModels db = new DBModels();

        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            return View(GetAllEployees());

        }

        IEnumerable<Employee> GetAllEployees()
        {
            return db.Employees.ToList<Employee>();
        }


        public ActionResult AddOrEdit(int id = 0)
        {
            // Declare an Object of the Employee model
            Employee emp = new Employee();

            return View(emp);

        }

        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();

        }
    }
}