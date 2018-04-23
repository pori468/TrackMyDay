using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackMyDay.Models;

namespace TrackMyDay.Controllers
{

    [RequireHttps]
    public class CalanderController : Controller
    {
        // GET: Calander
        public ActionResult Index()
        {
            ApplicationDbContext data = new ApplicationDbContext();

            var x = data.Calander.FirstOrDefault();
            var titel = x.Titel;
            var Des = x.Description;
            return View();
        }
    }
}