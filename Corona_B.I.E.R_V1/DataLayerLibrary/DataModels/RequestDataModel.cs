using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataModels
{
    public class RequestDataModel
    {
        public int id { get; set; }
        public int employee_id { get; set; }
        public int employee_id_acceptedby { get; set; }
        public DateTime datetimestart { get; set; }
        public DateTime datetimeend { get; set; }
        public string status { get; set; }
        public string request_type { get; set; }
        public string reason { get; set; }

    }
}
