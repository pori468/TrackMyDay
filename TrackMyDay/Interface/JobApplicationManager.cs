using System;
using System.Collections.Generic;
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

    }
}