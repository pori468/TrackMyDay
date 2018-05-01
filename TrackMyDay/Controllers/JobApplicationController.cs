using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackMyDay.Models;
using TrackMyDay.Interface;

namespace TrackMyDay.Controllers
{
    public class JobApplicationController : Controller
    {
        private readonly IJobApplication _job ;
        private ApplicationDbContext _data = new ApplicationDbContext();

        public JobApplicationController()
        {
             _job = new JobApplicationManager();
           
        }
                    
          
        
        // GET: JobApplication
        public ActionResult MyJob ()
        {

            return View();

        }
        public ActionResult Index()
        {

            return PartialView ("_PartialIndexView",_job.AllJobLIst());
        }

        // GET: JobApplication

        public ActionResult Edit(int id)
        {
            var result = _job.Getedit(id);
            return PartialView("_PartialEditView",result);
        }


        [HttpPost]
        public ActionResult Edit( JobModel model)
        {
            bool Result = _job.Postedit(model);
            return Content(Result.ToString());
        }

        // GET: JobApplication
        public ActionResult Detail(int ? id)
        {

            return PartialView ("_PartialDetailview",_job.JobDetail(id.Value));
        }
        [HttpGet]
        public ActionResult JobHistory(int jobId)
        {
            JobHistoryViewModel job = new JobHistoryViewModel();
            job.JObId = jobId.ToString();
            return PartialView("_PartialJobHistoryView", job);
        }

        [HttpPost]
        public ActionResult JobHistory(string Id, string Action, DateTime Nextdate, string NextAction )
        {
            bool Result = _job.CreateHistory(Id,Action, Nextdate,  NextAction);
            return Content(Result.ToString());
        }



        public ActionResult AllHistory (string jobId)
        {
            var result = _job.AllHistory(jobId);
            return PartialView("_PartialAllhistoryView", result);
        }

        // GET: JobApplication
        public ActionResult Create()
        {
            return PartialView("_PartialCreateView");
        }
        [HttpPost]
        public ActionResult Create(JobModel model)
        {

            bool Result = _job.SaveJobInfo(model);
            return Content(Result.ToString());
        }
    }
}