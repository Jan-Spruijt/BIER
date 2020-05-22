using Corona_B.I.E.R_V1.DataAccess;
using DataLayerLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace DataLayerLibrary.DataLogic
{
    public class CalendarProcessor
    {
        public static List<EventsDataModel> LoadAllEvents()
        {
            string sql = "SELECT * FROM schedule;";
            return SQLDataAccess.LoadData<EventsDataModel>(sql);
        }

        public static void CreateEvent(int employee_id, string title, string description, DateTime dateTimeStart, DateTime dateTimeEnd, string type)
        {
            EventsDataModel data = new EventsDataModel
            {
                Employee_ID = employee_id,
                Title = title,
                Description = description,
                DatetimeStart = dateTimeStart,
                DatetimeEnd = dateTimeEnd,
                Type = type
            };
            string sql = @"INSERT INTO schedule (employee_id, datetimeStart, datetimeEnd, title, description, type)                                                salt, passwordHash, profession, role)
                            VALUES(@Employee_id, @DatetimeStart, @DatetimeEnd, @Title, @Description, @Type);";
            SQLDataAccess.SaveData(sql, data);
        }

        public static void UpdateEvent(int employee_id, string title, string description, DateTime dateTimeStart, DateTime dateTimeEnd, string type, int update_id)
        {
            EventsDataModel data = new EventsDataModel
            {
                Employee_ID = employee_id,
                Title = title,
                Description = description,
                DatetimeStart = dateTimeStart,
                DatetimeEnd = dateTimeEnd,
                Type = type
            };
            string sql = @"UPDATE schedule SET employee_id = @employee_id, datetimeStart = @DatetimeStart, datetimeEnd = @DatetimeEnd,
                           title = @Title, description = @Description, type = @Type WHERE id = "+update_id+";";
            SQLDataAccess.SaveData(sql, data);
        }
    }
}
