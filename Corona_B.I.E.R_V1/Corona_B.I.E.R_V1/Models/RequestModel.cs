using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class RequestModel
    {
        public string Employeename { get; set; }
        public int RequestId { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeIdAcceptedby { get; set; }
        public string Date { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
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
        exchange,
        abscence
    }
}
