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
        public int StandbyHours { get; set; }
        public int IncidentHours { get; set; }
        public DateTime TimeStamp { get; set; }

    }

}
