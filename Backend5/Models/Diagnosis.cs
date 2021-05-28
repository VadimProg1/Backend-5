using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Backend5.Models
{
    public class Diagnosis
    {
        public Int32 Id { get; set; }
        public String Type { get; set; }
        public String Complications { get; set; }
        public String Details { get; set; }

        public Int32 PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
