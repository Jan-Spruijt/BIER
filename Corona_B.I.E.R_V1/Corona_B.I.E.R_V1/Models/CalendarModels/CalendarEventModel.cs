using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class CalendarEventModel
    {
        public int ID { get; set; }
        public int Employee_id { get; set; }
        public string EmployeeName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatetimeStart { get; set; }
        public DateTime DatetimeEnd { get; set; }
        public string Type { get; set; }
    }
}
