using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEPTTechnicalTest.Models
{
    public class Results
    {
        public Meta meta { get; set; }
        public List<Measurement> results { get; set; }
    }
}
