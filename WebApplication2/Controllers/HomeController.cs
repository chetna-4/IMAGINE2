using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Variable()
        {
            var variables = new List<Variable>();
            variables.Add(new Variable { Id = 1, Name = "Variable1", DataType = "Int" });
            variables.Add(new Variable { Id = 2, Name = "Variable2", DataType = "String" });
            variables.Add(new Variable { Id = 3, Name = "Variable3", DataType = "Int" });

            return View(variables);
        }
        [HttpPost]
        public ActionResult Variable(List<Variable> variables)
        {
            variables.Add(new Variable { Id = variables.Count+1, Name = "Variable", DataType = "Int" });
            return View(variables);
        }
    }
}