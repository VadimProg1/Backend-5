using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Backend5.Models
{
    public class Analysis
    {
        public Int32 Id { get; set; }
        public String Type { get; set; }
        public DateTime Date { get; set; }
        public String Status { get; set; }

        public Int32 LabId { get; set; }
        public Lab Lab { get; set; }
        public Int32 PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
