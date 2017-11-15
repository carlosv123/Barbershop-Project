using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapStone.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public DateTime time = DateTime.Now;
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string comment { get; set; }

    }
}