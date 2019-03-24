using EntityFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult CreateNewEmployee(Employee employee)
        {
            EmployeeDbContext db = new EmployeeDbContext();
            db.Employees.Add(employee);
            db.SaveChanges();

            return View("Index");
        }

    }
}