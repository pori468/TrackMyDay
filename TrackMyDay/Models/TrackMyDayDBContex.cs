using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TrackMyDay.Models
{
    public class TrackMyDayDBContex : DbContext
    {
        public DbSet<CalanderModel> Calander { get; set; }
        public DbSet<JobModel> jobs { get; set; }
        public DbSet<JobHistoryModel> JobHistory { get; set; }
    }
}