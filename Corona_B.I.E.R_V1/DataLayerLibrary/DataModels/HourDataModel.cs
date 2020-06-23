using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    public class HourDataModel
    {
        public int ID { get; set; }
        public int Employee_Id { get; set; }
        public int StandbyHours { get; set; }
        public int IncidentHours { get; set; }
        public DateTime TimeStamp { get; set; }


    }
}
