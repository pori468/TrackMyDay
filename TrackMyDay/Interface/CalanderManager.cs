using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrackMyDay.Interface;
using TrackMyDay.Models;

namespace TrackMyDay.Interface
{
    public class CalanderManager : ICalander
    {
            private ApplicationDbContext _data = new ApplicationDbContext();

       public IEnumerable<CalanderModel> AllTasks()
        {
            List<CalanderModel> Tasks = new List<CalanderModel>();
            DateTime date = DateTime.Now.Date;
            try
            {
                Tasks = _data.Calander.Where(x => x.Status == true && x.UserId=="Rubel" && (x.Date > date || x.Date == date)).ToList();

                return Tasks;
            }

            catch
            {
                return Tasks;
            }
        }

        public IEnumerable<CalanderModel> Unsolicide()
        {
            List<CalanderModel> Tasks = new List<CalanderModel>();
            DateTime date = DateTime.Now.Date;
            try
            {
                Tasks = _data.Calander.Where(x => x.Status == true && x.UserId == "Rubel" && x.Date<date).ToList();

                return Tasks;
            }

            catch
            {
                return Tasks;
            }
        }

        public CalanderModel Detail(int id)
        {
            CalanderModel Task = new CalanderModel();
           
            try
            {
                Task = _data.Calander.FirstOrDefault(x => x.Id==id && x.UserId == "Rubel");

                return Task;
            }

            catch
            {
                return Task;
            }
        }

        public bool SaveTaskInfo(CalanderModel model)
        {
            try
            {
                CalanderModel Task = new CalanderModel();

                Task.UserId = "Rubel";
                Task.Event = model.Event;
                Task.Titel = model.Titel;
                Task.Description = model.Description;
                Task.Date = model.Date;
                Task.Status = true;


                _data.Calander.Add(Task);
                _data.SaveChanges();

                return true;
            }

            catch
            {
                return false;
            }
        }

        public CalanderModel Getedit(int id)
        {
            try
            {
                return Detail(id);
            }
            catch
            {
                throw;
            }
        }

        
        public bool Postedit(CalanderModel model)
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
       public bool Status(int id)
        {

            CalanderModel Task = new CalanderModel();
                try
                {
                Task = _data.Calander.FirstOrDefault(x => x.Id == id && x.UserId == "Rubel");
                Task.Status = false;
                _data.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
           
        }

        public IEnumerable<CalanderModel> History(int id )
        {
            List<CalanderModel> Tasks = new List<CalanderModel>();
            DateTime date = DateTime.Now.Date;
            try
            {
                var singletask = _data.Calander.FirstOrDefault(x=>x.Id==id);

                Tasks = _data.Calander.Where(x => x.Event== singletask.Event).ToList();

                return Tasks;
            }

            catch
            {
                return Tasks;
            }
        }

    }
}