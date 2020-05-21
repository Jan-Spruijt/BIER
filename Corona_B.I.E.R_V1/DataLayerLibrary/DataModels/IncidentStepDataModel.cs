using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    public class IncidentStepDataModel
    {
        public int id { get; set; }
        public int employee_id_createdby { get; set; }
        public int employee_id_endedby { get; set; }
        public int incident_id { get; set; }
        public int stepnumber { get; set; }
        public string context { get; set; }
        public string title { get; set; }
        public DateTime datetimeStart { get; set; }
        public DateTime datetimeEnd { get; set; }
        public string status { get; set; }
    }
}
