using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapStone.Models
{
    public class appointment
    {
        public int Id { get; set; }

        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        public int age { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string email { get; set; }


        [Required]
        [Display(Name = "Appointment time")]
        public string Time { get; set; }

        [Required]
        [Display(Name = "Appointment date")]
        public DateTime date { get; set; }

        public virtual payment payment { get; set; }
        
    }
}