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
        public ActionResult Edit()
        {

            return View();
        }

        // GET: JobApplication
        public ActionResult Detail(int ? id)
        {

            return PartialView ("_PartialDetailview",_job.JobDetail(id.Value));
        }

        // GET: JobApplication
        public ActionResult Create()
        {
            return PartialView("_PartialCreateView");
        }
        [HttpPost]
        public ActionResult Create(JobModel model)
        {
            _data.jobs.Add(model);
            _data.SaveChanges();
            return View();
        }
    }
}