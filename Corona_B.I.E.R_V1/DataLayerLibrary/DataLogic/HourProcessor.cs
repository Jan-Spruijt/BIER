using Corona_B.I.E.R_V1.DataAccess;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1;
using System.Collections.Generic;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class HourProcessor
    {

        public static void RegisterHour(int employee_id, int standbyHours, int incidentHours)
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



        public static List<HourDataModel> LoadHours()
        {
            string sql = "SELECT * FROM registeredhours;";
            return SQLDataAccess.LoadData<HourDataModel>(sql);

        }

        public static List<HourDataModel> LoadHours(int id)
        {
            string sql = $"SELECT * FROM registeredhours WHERE employee_id = '{id}';";
            return SQLDataAccess.LoadData<HourDataModel>(sql);

        }

        public static void DeleteHours(int id)
        {
            string sql = $"DELETE FROM registeredhours WHERE id = '{id}';";
            SQLDataAccess.DeleteData(sql);
        }
    }
}
