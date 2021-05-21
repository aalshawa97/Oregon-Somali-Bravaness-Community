using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I am a co-founder of the first Oregon Somali Bravaness Community website for all of the Pacific Northwest. Responsibilities include maintaining excellent communication with members and leaders of the organization. My responsibilities forced me to learn, and apply proper web development procedures. They also pushed me toward developing leadership skills required for organizing large teams to hold events for 10+ people. As a community run organization, a big challenge is generating our own revenues and expenses through the events we hold. It is essential that events are successful because the organization's success depend on it.";

            return View();
        }

        public ActionResult Career()
        {
            ViewBag.Message = "Search jobs!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hi, how can we help?";

            return View();
        }
    }
}