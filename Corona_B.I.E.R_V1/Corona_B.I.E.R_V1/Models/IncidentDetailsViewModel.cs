using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class IncidentDetailsViewModel
    {
        [Display(Name = "Klant")]
        public string Customer { get; set; }
        [Display(Name = "Klanten E-mail")]
        public string CustomerEmail { get; set; }
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Display(Name = "Context")]
        public string Context { get; set; }
        public string Status { get; set; }
        public int id { get; set; }
        public List<IncidentStepModel> steps { get; set; }
    }
}
