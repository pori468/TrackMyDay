using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyDay.Models;

namespace TrackMyDay.Interface
{
    interface IJobApplication
    {
        IEnumerable<JobModel> AllJobLIst();
        JobModel JobDetail( int id);
        bool SaveJobInfo(JobModel model);
        JobModel Getedit(int id);
       bool Postedit(JobModel model);
    }
}
