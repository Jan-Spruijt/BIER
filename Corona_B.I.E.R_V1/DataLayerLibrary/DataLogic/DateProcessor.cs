using Corona_B.I.E.R_V1.DataAccess;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1;
using System.Collections.Generic;
using Corona_B.I.E.R_V1.Models;
using System.Security.Principal;
using System;

namespace DataLayerLibrary.DataLogic
{
    public class DateProcessor
    {
        public static void CreateEvent(int id , string title , string description , string type , DateTime start , DateTime end)
        {
            DateDataModel data = new DateDataModel
            {
                Id = id,
                Title = title,
                Description = description,
                Type = type,
                datetimeStart = start,
                datetimeEnd = end
            };

            string sql = @"INSERT INTO schedule (id, datetimeStart, datetimeENd, title, description, type)
                            VALUES(@Id , @Start , @End , @Title , @Decription , @Type);";
            SQLDataAccess.SaveData(sql, data);
        }

        public static List<DateDataModel> LoadDates()
        {
            string sql = "SELECT * FROM schedule;";
            return SQLDataAccess.LoadData<DateDataModel>(sql);
        }

        public static DateDataModel getDateByType(string type)
        {
            string sql = "SELECT * FROM schedule WHERE type = '{type}';";
            return SQLDataAccess.LoadFirstData<DateDataModel>(sql);
        }
    }
}
