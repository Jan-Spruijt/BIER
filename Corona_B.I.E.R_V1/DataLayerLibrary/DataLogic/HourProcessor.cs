using System;
using System.Collections.Generic;
using System.Text;
using Corona_B.I.E.R_V1.DataAccess;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1;
using DataLayerLibrary.DataModels;
using Org.BouncyCastle.Asn1.Cms;

namespace DataLayerLibrary.DataLogic
{
    class HourProcessor
    {

        public static void CreateHours(string employee_id, string standbyHours, string incidentHours, string timestamp)
        {
            HourDataModel data = new HourDataModel
            {

                Employee_Id = employee_id,
                StandbyHours = standbyHours,
                IncidentHours = incidentHours,
                TimeStamp = timestamp,


    };
            string sql = @"INSERT INTO registered-hours (employee_id, standbyHours, incidentHours, timestamp )
                            VALUES(@Employee_Id, @StandbyHours, @IncidentHours, @TimeStamp);";
            SQLDataAccess.SaveData(sql, data);
        }
    }
}
