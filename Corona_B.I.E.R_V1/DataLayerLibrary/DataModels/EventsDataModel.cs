using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    public class EventsDataModel
    {
        public int ID { get; set; }
        public int Employee_ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatetimeStart { get; set; }
        public DateTime DatetimeEnd { get; set; }
        public string Type { get; set; }
    }
}
