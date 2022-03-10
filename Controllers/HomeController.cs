using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.data1 = "I am in ViewBag";
            ViewBag.data2 = 98765;
            ViewBag.data3 = 96.5f;
            ViewBag.data4 = 98.56;
            List<String> list = new List<String>();
            list.Add("India");
            list.Add("PAK");
            list.Add("China");
            ViewBag.ListData = list;

            ViewData["Name"] = "Ravi";
            ViewData["id"] = 123;
            ViewData["age"] = 13.5f;
            ViewData["Salary"] = 2000.34;

            ViewData["listdata"] = new List<String>()
            {
                "India",
                "pak"
            };


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
    }
}