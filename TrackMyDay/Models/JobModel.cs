using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackMyDay.Models
{
    public class JobModel
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Position { get; set; }

        public string Company  { get; set; }
        public string Address  { get; set; }
        public string Type { get; set; }

        public string Weblink  { get; set; }

        public string Announcement   { get; set; }

        public string ContacInfo  { get; set; }

        public string ApplyThrough  { get; set; }

        public string Status  { get; set; }


        public DateTime Date { get; set; }

        public DateTime ApplyDate { get; set; }

        public string Refferance  { get; set; }

}
}