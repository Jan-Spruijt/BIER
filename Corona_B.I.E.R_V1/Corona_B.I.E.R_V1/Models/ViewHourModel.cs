using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;


namespace Corona_B.I.E.R_V1.Models
{
    public class ViewHourModel
    {
        public int Id { get; set; }
        public int Employee_ID { get; set; }
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        [Display(Name = "Standby Uren")]
        public int StandbyHours { get; set; }
        [Display(Name = "Incident Uren")]
        public int IncidentHours { get; set; }
        [Display(Name = "Aanmaak Datum")]
        public DateTime TimeStamp { get; set; }

    }

}
