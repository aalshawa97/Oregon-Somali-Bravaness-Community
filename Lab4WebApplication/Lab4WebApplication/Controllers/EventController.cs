using Lab4WebApplication.Data;
using Lab4WebApplication.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4WebApplication.Controllers
{
    public class EventController : Controller
    {
        public ActionResult List(int userId)
        {
            ViewBag.UserId = userId;

            var events = GetEventsForUser(userId);

            return View(events);
        }
        

        private ICollection<EventViewModel> GetEventsForUser(int userId)
        {
            var eventViewModels = new List<EventViewModel>();

            var dbContext = new AppDbContext();

            var events = dbContext.Events.Where(aEvent => aEvent.UserId == userId).ToList();

            return eventViewModels;
        }
        
        
    }
}