using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class IncidentModel
    {
        public int ID { get; set; }
        public int Employee_ID_CreatedBy { get; set; }
        public int Employee_ID_EndedBy { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnded { get; set; }
        [Required(ErrorMessage = "Vul een titel in")]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Display(Name = "Context")] 
        public string Context { get; set; }

        [Required(ErrorMessage = "Vul een klant in")]
        [Display(Name = "Klant")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "Vul een klanten E-mail in")]
        [Display(Name = "Klanten E-mail")]
        public string CustomerEmail { get; set; }

        public string Status { get; set; }

    }
}
