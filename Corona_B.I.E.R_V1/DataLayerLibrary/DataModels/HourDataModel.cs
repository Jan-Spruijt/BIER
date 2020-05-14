using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    class HourDataModel
    {
        public int ID { get; set; }
        public string Employee_Id { get; set; }
        public string StandbyHours { get; set; }
        public string IncidentHours { get; set; }
        public string TimeStamp { get; set; }

    }
}
