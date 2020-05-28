using System;
using System.Collections.Generic;
using System.Text;
using Corona_B.I.E.R_V1.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class IncidentEmployeeProcessor
    {
        public static void AddEmployeeToIncident(int incident_Id, int employee_Id)
        {
            IncidentEmployeeDataModel data = new IncidentEmployeeDataModel
            {
                Employee_Id = employee_Id,
                Incident_Id = incident_Id
            };
            string sql = @"INSERT INTO incident_employee (incident_id, employee_id) VALUES (@Incident_Id, @Employee_Id);";
            SQLDataAccess.SaveData(sql,data);
        }

        public static void RemoveEmployeeFromIncident(int id, int employee_Id)
        {
            string sql = $"DELETE FROM incident_employee WHERE incident_id = '{id}' AND employee_id = '{employee_Id}';";
            SQLDataAccess.DeleteData(sql);
        }

        public static List<IncidentEmployeeDataModel> LoadEmployeesByIncidentId(int incident_Id)
        {
            string sql = $"SELECT * FROM incident_employee WHERE incident_id = '{incident_Id}';";
            return SQLDataAccess.LoadData<IncidentEmployeeDataModel>(sql);
        }
    }
}
