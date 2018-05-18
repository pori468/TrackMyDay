using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackMyDay.Models;
using TrackMyDay.Interface;

namespace TrackMyDay.Controllers
{

    [RequireHttps]
    public class CalanderController : Controller
    {
        private readonly ICalander _Calander;
        private ApplicationDbContext _data = new ApplicationDbContext();

        public CalanderController()
        {
            _Calander = new CalanderManager();

        }

        public ActionResult MyCalander()
        {
            
            return View();
        }

        // GET: Calander
        public ActionResult Index()
        {
           
            return View("_PartialCalanderIndexView",_Calander.AllTasks());
        }
        public ActionResult Unsolicide()
        {

            return View("_PartialCalanderIndexView", _Calander.Unsolicide());
        }
        

        public ActionResult CreateNewTasks()
        {
            return PartialView("_PartialCreateCalanderView");
        }

       
        [HttpPost]
        public ActionResult CreateNewTasks(CalanderModel model)
        {

            bool Result = _Calander.SaveTaskInfo(model);
            return Content(Result.ToString());
        }

        public ActionResult Detail(int id)
        {

            return View("_PartialDetailCalanderView", _Calander.Detail(id));
        }


        public ActionResult Edit(int id)
        {
            var result = _Calander.Getedit(id);
            return PartialView("_PartialCalanderEditView", result);
        }


        [HttpPost]
        public ActionResult Edit(CalanderModel model)
        {
            bool Result = _Calander.Postedit(model);
            return Content(Result.ToString());
        }

        public ActionResult Status(int id)
        {
            var Result = _Calander.Status(id);
            return Content(Result.ToString());
        }

        public ActionResult History(int Id)
        {

            return View("_PartialCalanderHistoryView", _Calander.History(Id));
        }

    }
}