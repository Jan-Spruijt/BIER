using Corona_B.I.E.R_V1.DataAccess;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1;
using System.Collections.Generic;


namespace DataLayerLibrary.DataLogic
{
    public class HourProcessor
    {

        public static void RegisterHour(int employee_id, string standbyHours, string incidentHours)
        {
            HourDataModel data = new HourDataModel
            {

                Employee_Id = employee_id,
                StandbyHours = standbyHours,
                IncidentHours = incidentHours,


            };

            string sql = @"INSERT INTO registeredhours (employee_id, standbyHours, incidentHours )
                            VALUES(@Employee_Id, @StandbyHours, @IncidentHours);";
            SQLDataAccess.SaveData(sql, data);
        }
    }
}
