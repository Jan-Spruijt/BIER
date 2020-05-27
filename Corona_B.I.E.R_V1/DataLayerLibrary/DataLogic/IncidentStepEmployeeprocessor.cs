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
            string sql = @"INSERT INTO incidenttimeline_employee (incidentTimeline_id, employee_id) VALUES (@incidentStep_id, @employee_id);";
            SQLDataAccess.SaveData(sql, data);
        }

        public static void RemoveEmployeeFromStep(int stepId, int employeeId)
        {
            string sql = $"DELETE FROM incidenttimeline_employee WHERE incidentTimeline_id = '{stepId}' AND employee_id = '{employeeId}';";
            SQLDataAccess.DeleteData(sql);
        }

        public static List<IncidentStepEmployeeDataModel> LoadEmployeesFromStepId(int id)
        {
            string sql = $"SELECT * FROM incidenttimeline_employee WHERE incidentTimeline_id = '{id}';";
            return SQLDataAccess.LoadData<IncidentStepEmployeeDataModel>(sql);
        }
    }
}
