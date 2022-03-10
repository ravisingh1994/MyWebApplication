using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApplication.Controllers
{
    public class RaviController : Controller
    {
        // GET: Ravi
        public ActionResult Index()
        {
            TempData["Name"] = "Ravi";
            TempData["id"] = 1234;
            TempData["age"] = 15.5f;
            TempData["Salary"] = 67.87;
            return View();
        }
    }
}