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
                detail = _data.jobs.FirstOrDefault(x => x.Id == id);

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
                model.NextAction= "Follow up on the application";

                _data.jobs.Add(model);
                _data.SaveChanges();

                JobHistoryModel history = new JobHistoryModel();

                history.UserId = "Rubel";
                history.JobId = model.Id.ToString();
                history.ActionDate = DateTime.Now;

                history.NextAction = "Follow up on the application";
                history.NextActionDate = model.Date;
                history.ActionDetails = "Follow up on the application";

                _data.JobHistory.Add(history);

                CalanderModel MyCalander = new CalanderModel();

                MyCalander.UserId = "Rubel";
                MyCalander.Titel= "Follow up on the application";
                MyCalander.Description = "Position: " + model.Position + ". " + "Company :" + model.Company + ". " + "Address :" + model.Address + ". " + "Contac :" + model.ContacInfo + ". " + "Deadline :" + model.Date;
                MyCalander.Event = "Job Application";
                MyCalander.Date = model.Date;
                MyCalander.Status = true;

                _data.Calander.Add(MyCalander);

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

        public IEnumerable<JobHistoryModel> AllHistory(string id)
        {
            List <JobHistoryModel> JobHistory = new List<JobHistoryModel>();
           
            try
            {
                JobHistory = _data.JobHistory.Where(x=>x.UserId=="Rubel" && x.JobId== id).OrderBy(y=>y.ActionDate).ToList();
                
                return JobHistory;
            }

            catch
            {
                return JobHistory;
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


        public  bool CreateHistory(string Id, string Action, DateTime Nextdate, string NextAction)
        {
            try
            {
                JobHistoryModel History = new JobHistoryModel();

                History.JobId = Id;
                History.UserId = "Rubel";

                History.ActionDate = DateTime.Now;
                History.ActionDetails = Action;
                History.NextActionDate = Nextdate;
                History.NextAction = NextAction;

                _data.JobHistory.Add(History);

                int id = Int32.Parse(Id);
               var job= _data.jobs.FirstOrDefault(x=>x.Id==id);
                job.NextAction = NextAction;
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