using System;

namespace Corona_B.I.E.R_V1.DataModels
{
    class HourDataModel
    {
        public int ID { get; set; }
        public int Employee_Id { get; set; }
        public string StandbyHours { get; set; }
        public string IncidentHours { get; set; }
        public DateTime TimeStamp { get; set; }



    }
}
