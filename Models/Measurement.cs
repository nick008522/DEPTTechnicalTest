using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEPTTechnicalTest.Models
{
    public class Measurement
    {
        public string location { get; set; }
        public string parameter { get; set; }
        public Date date { get; set; }
        public double value { get; set; }
        public string unit { get; set; }
        public Coordinates coordinates { get; set; }
        public string country { get; set; }
        public string city { get; set; }
    }
}
