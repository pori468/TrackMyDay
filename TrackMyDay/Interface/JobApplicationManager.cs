using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrackMyDay.Interface;
using TrackMyDay.Models;
namespace TrackMyDay.Interface
{
    public class JobApplicationManager : IJobApplication
    {
        private ApplicationDbContext _data = new ApplicationDbContext();
        public IEnumerable<JobModel> AllJobLIst()
        {
            List<JobModel> Joblist = new List<JobModel>();
            try
            {

                Joblist = _data.jobs.ToList();
                return Joblist;
            }

            catch
            {
                return Joblist;
            }
        }

        public JobModel JobDetail(int id)
        {
            JobModel detail = new JobModel();
            try
            {
                detail = _data.jobs.FirstOrDefault(x=>x.Id==id);
                
                return detail;
            }

            catch
            {
                return detail;
            }
        }

       public bool SaveJobInfo(JobModel model)
        {
            try
            {
                model.Status = "Not Reply Yet";
                model.UserId = "Rubel";
                model.ApplyDate = DateTime.Now;

                //JobModel rubel = new JobModel();
                //rubel.UserId = "a";
                //rubel.Position = "a";
                //rubel.Company = "a";
                //rubel.Address = "a";
                //rubel.Announcement = "a";
                //rubel.ApplyDate = DateTime.Now;
                //rubel.ApplyThrough = "a";
                //rubel.ContacInfo = "a";
                //rubel.Date = DateTime.Now;
                //rubel.Refferance = "a";
                //rubel.Status = "a";
                //rubel.Type = "a";
                //rubel.Weblink = "a";



                _data.jobs.Add(model);
            _data.SaveChanges();

            return true;
            }

            catch
            {
                return false;

            }
        }


        public JobModel Getedit(int id)
        {
            try
            {
                return JobDetail(id);
            }
            catch
            {
                throw;
            }
        }


        public bool Postedit(JobModel model)
        {
            try
            {
                
                _data.Entry(model).State = EntityState.Modified;
                _data.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}