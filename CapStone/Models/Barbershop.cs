using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapStone.Models
{
    public class Barbershop
    {
        public int Id { get; set; }

        [Display(Name = "Haircut Prices")]
        public string Haircutprices { get; set; }
        [Display(Name = "Hours Open")]
        public string Openhours { get; set; }

        [Display(Name = "Days open")]
        public string OpenDays { get; set; }

        [Display(Name = "Holiday Hours")]
        public string holyday { get; set; }

        [Display(Name = "Holiday Days")]
        public string holdayDays { get; set; }
        public string phoneNumber { get; set; }


    }
    public class barber
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string specialty { get; set; }
        public string workDays { get; set;}
        public string workHours { get; set; }

    }
}