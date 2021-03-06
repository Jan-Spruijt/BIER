﻿using Corona_B.I.E.R_V1.DataAccess;
using DataLayerLibrary.DataModels;
using System;
using System.Collections.Generic;

namespace DataLayerLibrary.DataLogic
{
    public class IncidentStepProcessor
    {
        public static void CreateStep(int employeeCreatedBy, int incidentId, string Context, string title)
        {
            var data = new IncidentStepDataModel
            {
                context = Context,
                title = title,
                employee_id_createdby = employeeCreatedBy,
                incident_id = incidentId,
                status = "pending"
            };
            string sql = @"INSERT INTO incident_timeline (employee_id_createdby, incident_id, context, title, status)
                            VALUES (@employee_id_createdby, @incident_id, @context, @title, @status)";
            SQLDataAccess.SaveData(sql,data);
        }

        public static void StartStep(int id, int employee_id)
        {
            bool isWorkingOn = false;
            var data = LoadStepById(id);
            var incidentEmployeeData = IncidentEmployeeProcessor.LoadEmployeesByIncidentId(data.incident_id);
            foreach (var employee in incidentEmployeeData)
            {
                if (employee_id == employee.Employee_Id)
                {
                    isWorkingOn = true;
                } 
            }

            if (isWorkingOn == false)
            {
                IncidentEmployeeProcessor.AddEmployeeToIncident(data.incident_id, employee_id);
            }

            data.datetimeStart = DateTime.Now;
            var datetimestring = data.datetimeStart.ToString("yyyy/MM/dd HH:mm:ss");
            data.status = "busy";

            IncidentStepEmployeeprocessor.AddEmployeeToStep(employee_id, id);

            string sql = $"Update incident_timeline Set datetimeStart = '{datetimestring}', status = '{data.status}'";
            SQLDataAccess.SaveData(sql,data);
        }

        public static void CloseStep(int id, int employee_id_endedby)
        {
            var data = LoadStepById(id);
            data.datetimeEnd = DateTime.Now;
            var datetimestring = data.datetimeEnd.ToString("yyyy/MM/dd HH:mm:ss");
            data.status = "done";
            data.employee_id_endedby = employee_id_endedby;
            string sql = $"Update incident_timeline Set datetimeEnd = '{datetimestring}', status = '{data.status}', employee_id_endedby = '{data.employee_id_endedby}' WHERE id = '{id}';";
            SQLDataAccess.SaveData(sql, data);
        }

        public static IncidentStepDataModel LoadStepById(int id)
        {
            string sql = $"SELECT * FROM incident_timeline WHERE id = '{id}';";
            return SQLDataAccess.LoadFirstData<IncidentStepDataModel>(sql);
        }

        public static List<IncidentStepDataModel> LoadStepsByIncidentId(int id)
        {
            string sql = $"SELECT * FROM incident_timeline WHERE incident_id = '{id}';";
            return SQLDataAccess.LoadData<IncidentStepDataModel>(sql);
        }

        public static void DeleteStep(int id)
        {
            var employees = IncidentStepEmployeeprocessor.LoadEmployeesFromStepId(id);
            foreach (var employee in employees)
            {
                IncidentStepEmployeeprocessor.RemoveEmployeeFromStep(id,employee.employee_id);
            }
            string sql = $"DELETE FROM incident_timeline WHERE id = '{id}';";
            SQLDataAccess.DeleteData(sql);
        }
    }
}
