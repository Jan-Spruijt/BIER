using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    public class IncidentDataModel
    {
        public int ID { get; set; }
        public int Employee_ID_CreatedBy { get; set; }
        public int Employee_ID_EndedBy { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public string Customer { get; set; }
        public string CustomerEmail { get; set; }
        public string Status { get; set; }
    }
}
