using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models.CalendarModels
{
    public class CalendarCreateEventModel
    {
        public int Employee_ID { get; set; }
        public List<EmployeeCalendarModel> Employees { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatetimeStart { get; set; }
        public DateTime DatetimeEnd { get; set; }
        public string Type { get; set; }
    }
}
