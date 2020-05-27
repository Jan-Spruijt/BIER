using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class RequestModel
    {
        public string Employeename { get; set; }
        public string EmployeeAcceptedbyName { get; set; }
        public int RequestId { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeIdAcceptedby { get; set; }
        public string Date { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateStart { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan TimeStart { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan TimeEnd { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        public string stringDateStart { get; set; }
        public string stringDateEnd { get; set; }

        public string stringTimeStart { get; set; }
        public string stringTimeEnd { get; set; }


        public RequestStatus Status { get; set; }
        public RequestType Type { get; set; }
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
