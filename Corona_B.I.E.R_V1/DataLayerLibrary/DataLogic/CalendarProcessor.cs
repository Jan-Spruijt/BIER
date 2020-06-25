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
        public static List<EventDataModel> LoadAllEvents()
        {
            string sql = "SELECT * FROM schedule;";
            return SQLDataAccess.LoadData<EventDataModel>(sql);
        }
        public static EventDataModel GetEventById(int employeeId)
        {
            string sql = $"SELECT * FROM schedule WHERE id ={employeeId};";
            return SQLDataAccess.LoadFirstData<EventDataModel>(sql);
        }
        public static List<EventDataModel> LoadEmployeeEvents(int employee_id)
        {
            string sql = $"SELECT * FROM schedule WHERE employee_id ={employee_id};";
            return SQLDataAccess.LoadData<EventDataModel>(sql);
        }

        public static void CreateEvent(int employee_id, string title, string description, DateTime dateTimeStart, DateTime dateTimeEnd, string type)
        {
            EventDataModel data = new EventDataModel
            {
                Employee_ID = employee_id,
                Title = title,
                Description = description,
                DatetimeStart = dateTimeStart,
                DatetimeEnd = dateTimeEnd,
                Type = type
            };
            string sql = @"INSERT INTO schedule (employee_id, datetimeStart, datetimeEnd, title, description, type)
                            VALUES(@Employee_id, @DatetimeStart, @DatetimeEnd, @Title, @Description, @Type);";
            SQLDataAccess.SaveData(sql, data);
        }

        public static void UpdateEvent(int event_id, int employee_id, string title, string description, DateTime dateTimeStart, DateTime dateTimeEnd, string type)
        {
            EventDataModel data = new EventDataModel
            {
                Employee_ID = employee_id,
                Title = title,
                Description = description,
                DatetimeStart = dateTimeStart,
                DatetimeEnd = dateTimeEnd,
                Type = type
            };
            string sql = @"UPDATE schedule SET employee_id = @employee_id, datetimeStart = @DatetimeStart, datetimeEnd = @DatetimeEnd,
                           title = @Title, description = @Description, type = @Type WHERE id = "+ event_id + ";";
            SQLDataAccess.SaveData(sql, data);
        }

        public static void DeleteEvent(int id)
        {
            string sql = $"DELETE FROM schedule WHERE id = '{id}';";
            SQLDataAccess.DeleteData(sql);
        }
    }
}
