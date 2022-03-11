using System;
using WebApplicationRavi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationRavi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp = new Employee();
            emp.Name = "Ravi";
            emp.age = 32;
            emp.Salary = 22000;

            Session["name"] = "Ravi";
            Session["Slist"] = new List<String>()
            {
                "India",
                "China",
                "pak",
                "Nz"
            };

            return View(emp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}