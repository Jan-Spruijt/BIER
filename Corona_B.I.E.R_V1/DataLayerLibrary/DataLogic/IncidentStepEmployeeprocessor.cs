using System;
using System.Collections.Generic;
using System.Text;
using Corona_B.I.E.R_V1.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class IncidentStepEmployeeprocessor
    {
        public static void AddEmployeeToStep(int employeeId, int stepId)
        {
            var data = new IncidentStepEmployeeDataModel
            {
                employee_id = employeeId,
                incidentStep_id = stepId
            };
            string sql = @"INSERT INTO incident-timeline_employee (incident-timeline_id, employee_id) VALUES (@incidentStep_id, @employee_id);";
            SQLDataAccess.SaveData(sql, data);
        }

        public static void RemoveEmployeeFromStep(int stepId, int employeeId)
        {
            string sql = $"DELETE FROM incident-timeline_employee WHERE incident-timeline_id = '{stepId}' AND employee_id = '{employeeId}';";
            SQLDataAccess.DeleteData(sql);
        }
    }
}
