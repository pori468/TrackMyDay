using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackMyDay.Models;

namespace TrackMyDay.Interface
{
    interface ICalander
    {
        IEnumerable<CalanderModel> AllTasks();
        IEnumerable<CalanderModel> Unsolicide();
        CalanderModel Detail( int id);
        bool SaveTaskInfo(CalanderModel model);

        CalanderModel Getedit(int id);
        bool Postedit(CalanderModel model);
        bool Status(int id);

        IEnumerable<CalanderModel> History(int id);
    }
}
