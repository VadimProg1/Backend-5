using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend5.Models.ViewModels
{
    public class DiagnosesCreateEditModel
    {
        [Required]
        public String Type { get; set; }
        public String Complications { get; set; }
        public String Details { get; set; }
    }
}
