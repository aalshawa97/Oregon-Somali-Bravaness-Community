using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4WebApplication.Models.View
{
    public class EventViewController : Controller
    {
        // GET: EventView
        public ActionResult Index()
        {
            return View();
        }
    }
}