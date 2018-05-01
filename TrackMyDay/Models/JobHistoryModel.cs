using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackMyDay.Models
{
    public class JobHistoryModel
    {
        [Key]
        public int Id { get; set; }
        public string JobId { get; set; }
        public string UserId { get; set; }

        
        public DateTime ActionDate { get; set; }
        [Required]
        [Display(Name = "Next Action Date")]
        public DateTime NextActionDate { get; set; }

        [Required]
        [Display(Name = "Action Details")]
        public string ActionDetails { get; set; }
        [Required]
        [Display(Name = "Next Action")]
        public string NextAction { get; set; }
        




    }
}

