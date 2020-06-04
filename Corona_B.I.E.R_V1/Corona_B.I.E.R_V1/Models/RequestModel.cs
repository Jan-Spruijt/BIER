using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class RequestModel
    {
        [Display(Name = "Werknemer")]
        public string Employeename { get; set; }
        [Display(Name = "Geaccepteerd door")]
        public string EmployeeAcceptedbyName { get; set; }
        public int RequestId { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeIdAcceptedby { get; set; }
        [Display(Name = "Datum")]
        public string Date { get; set; }
        [Display(Name = "Begindatum")]
        [DataType(DataType.Date)]
        public DateTime DateStart { get; set; }
        [Display(Name = "Einddatum")]
        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }

        [Display(Name = "Starttijd")]
        [DataType(DataType.Time)]
        public TimeSpan TimeStart { get; set; }

        [Display(Name = "Eindtijd")]
        [DataType(DataType.Time)]
        public TimeSpan TimeEnd { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Startdatum")]
        public string stringDateStart { get; set; }
        [Display(Name = "Einddatum")]
        public string stringDateEnd { get; set; }
        [Display(Name = "Starttijd")]
        public string stringTimeStart { get; set; }
        [Display(Name = "Eindtijd")]
        public string stringTimeEnd { get; set; }


        public RequestStatus Status { get; set; }
        public RequestType Type { get; set; }
        [Display(Name = "Reden")]
        public string Reason { get; set; }

    }

    public enum RequestStatus {
        open,
        accepted,
        expired
    }

    public enum RequestType
    {
        [Display(Name = "Ruilen")]
        Exchange,
        [Display(Name = "Verlof")]
        Absence,
        [Display(Name = "Vakantie")]
        Vacation
    }
}
