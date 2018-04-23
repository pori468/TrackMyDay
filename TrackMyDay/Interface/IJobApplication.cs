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
    }
}
