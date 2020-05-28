using System;
using System.Collections.Generic;
using System.Text;
using Corona_B.I.E.R_V1.DataAccess;
using Corona_B.I.E.R_V1.DataModels;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class IncidentProcessor
    {
        public static void CreateIncident(string title, string context, string customer, string customerEmail, int employee_ID_CreatedBy)
        {
            IncidentDataModel data = new IncidentDataModel
            {
                Employee_ID_CreatedBy = employee_ID_CreatedBy,
                DateTimeStart = DateTime.Now,
                Title = title,
                Context = context,
                Customer = customer,
                CustomerEmail = customerEmail,
                Status = "open"
            };
            string sql =
                @"INSERT INTO incident (employee_id_createdby, datetimeStart, title, context, customer, customerEmail, status)
                            VALUES(@Employee_ID_CreatedBy, @DateTimeStart, @Title, @Context, @Customer, @CustomerEmail, @Status);";
            SQLDataAccess.SaveData(sql, data);
        }

        public static void CloseIncident(int id, int employee_ID_EndedBy)
        {
            IncidentDataModel data = LoadIncidentById(id);
            data.DateTimeEnd = DateTime.Now;
            var datetimestring = data.DateTimeEnd.ToString("yyyy/MM/dd HH:mm:ss");
            data.Status = "closed";
            data.Employee_ID_EndedBy = employee_ID_EndedBy;

            string sql = $"Update incident set employee_id_endedby = '{data.Employee_ID_EndedBy}', datetimeEnd = '{datetimestring}', status = '{data.Status}' WHERE id = '{id}';";
            SQLDataAccess.SaveData(sql ,data);
        }

        public static List<IncidentDataModel> LoadIncidents()
        {
            string sql = "SELECT * FROM incident;";
            return SQLDataAccess.LoadData<IncidentDataModel>(sql);
        }

        public static List<IncidentDataModel> LoadOpenIncidents()
        {
            string sql = $"Select * FROM incident WHERE status = 'open';";
            return SQLDataAccess.LoadData<IncidentDataModel>(sql);
        }

        public static IncidentDataModel LoadIncidentById(int id)
        {
            string sql = $"Select * FROM incident WHERE id = '{id}';";
            return SQLDataAccess.LoadFirstData<IncidentDataModel>(sql);
        }

        public static void DeleteIncident(int id)
        {
            string sql = $"DELETE FROM incident WHERE id = '{id}';";
            SQLDataAccess.DeleteData(sql);
        }

        public static void EditIncident(int id, string title, string context, string customer, string customerEmail)
        {
            IncidentDataModel data = new IncidentDataModel
            {
                Context = context,
                Customer = customer,
                CustomerEmail = customerEmail,
                Title = title,
            };

            string sql = $"Update incident set title = '{title}', context = '{context}', customer = '{customer}', customerEmail = '{customerEmail}' WHERE id = '{id}'";
            SQLDataAccess.SaveData(sql, data);
        }
    }
}
