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
                Employee_ID_CreatedBy = 11,
                //Employee_ID_EndedBy = 11,
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

        //closeincident moet nog aangepast worden met custom invul waardes 
        public static void CloseIncident(int id)
        {
            IncidentDataModel data = LoadIncidentById(id);
            data.DateTimeEnd = DateTime.Now;
            data.Status = "closed";
            data.Employee_ID_EndedBy = 11;
            UpdateIncidentData(id, data.Employee_ID_EndedBy, data.DateTimeEnd, data.Status);
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

        public static IncidentDataModel LoadIncidentById(int id)
        {
            string sql = $"Select * FROM incident WHERE id = '{id}'";
            return SQLDataAccess.LoadFirstData<IncidentDataModel>(sql);
        }

        public static void UpdateIncidentData(int id, int employeeEndedBy, DateTime timeEnded, string status)
        {
            string sql = $"Update incident set employee_id_ended_by = '{employeeEndedBy}', datetimeEnd = '{timeEnded}', status = '{status}' WHERE id = '{id}'";
        }
    }
}
