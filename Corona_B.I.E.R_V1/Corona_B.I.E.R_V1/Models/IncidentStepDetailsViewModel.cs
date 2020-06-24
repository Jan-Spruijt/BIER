using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class IncidentStepDetailsViewModel
    {
        public int id { get; set; }
        public int employee_id_createdby { get; set; }
        public int employee_id_endedby { get; set; }
        public int incident_id { get; set; }
        [Display(Name = "Stapnummer")]
        public int stepnumber { get; set; }
        [Required(ErrorMessage = "Vul context in")]
        [Display(Name = "Context")]
        public string context { get; set; }

        [Required(ErrorMessage = "Vul een titel in")]
        [Display(Name = "Titel")]
        public string title { get; set; }

        public DateTime datetimeStart { get; set; }
        public DateTime datetimeEnd { get; set; }
        public string status { get; set; }
        public List<EmployeeModel> employee { get; set; }
    }
}
