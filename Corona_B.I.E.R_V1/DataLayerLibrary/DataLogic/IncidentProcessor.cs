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
        public static void CreateIncident(string title, string context, string customer, string customerEmail)
        {
            IncidentDataModel data = new IncidentDataModel
            {
                Employee_ID_CreatedBy = 1,
                Employee_ID_EndedBy = 1,
                DateTimeStart = DateTime.Now,
                Title = title,
                Context = context,
                Customer = customer,
                CustomerEmail = customerEmail,
                Status = "open"
            };
            string sql =
                @"INSERT INTO incident (employee_id_createdby, datetimestart, title, context, customer, customerEmail, status)
                            VALUES(@Employee_ID_CreatedBy, @DateTimeStart, @Title, @Context, @Customer, @CustomerEmail, @Status);";
            SQLDataAccess.SaveData(sql, data);
        }

        public static List<IncidentDataModel> LoadIncidents()
        {
            string sql = "SELECT * FROM incident;";
            return SQLDataAccess.LoadData<IncidentDataModel>(sql);
        }

        public static List<IncidentDataModel> LoadOpenIncidents()
        {
            string sql = $"Select * FROM incident WHERE status = open;";
            return SQLDataAccess.LoadData<IncidentDataModel>(sql);
        }
    }
}
