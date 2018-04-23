namespace TrackMyDay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CalanderModel
    {

        public int Id { get; set; }

        public string UserId { get; set; }

        public string Titel { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}
