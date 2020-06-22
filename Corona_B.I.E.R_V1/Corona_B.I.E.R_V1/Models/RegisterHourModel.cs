using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;

namespace Corona_B.I.E.R_V1.Models
{
    public class RegisterHourModel
    {
        [Display(Name = "Uren die standby gestaan zijn.")]
        [Required(ErrorMessage = "Vul standby uren in.")]
        public int StandbyHours { get; 
            set; }
        [Display(Name = "Uren dat aan incident is gewerkt.")]
        [Required(ErrorMessage = "Vul incident uren in.")]
        public int IncidentHours { get; 
            set; }
    }
}
