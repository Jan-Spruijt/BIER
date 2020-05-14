using System;
using System.Collections.Generic;
using System.Text;
using Corona_B.I.E.R_V1.DataAccess;
using Corona_B.I.E.R_V1.DataModels;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class RequestProcessor
    {

        public static void CreateRequest(int EmployeeId, DateTime DateTimeStart, DateTime DateTimeEnd, string Status,
            string RequestType, string Reason)
        {
            RequestDataModel request = new RequestDataModel
            {
                employee_id = EmployeeId,
                datetimestart = DateTimeStart,
                datetimeend = DateTimeEnd,
                status = Status,
                request_type = RequestType,
                reason = Reason
            };
            string sql = @"INSERT INTO employee (EmployeeId, DateTimeStart, DateTimeEnd, Status, RequestType, Reason)
                            VALUES(@employee_id, @datetimestart, @datetimeend, @status, @request_type, @reason);";
            SQLDataAccess.SaveData(sql, request);

        }
    

        public static List<RequestDataModel> LoadRequests()
        {
            string sql = "SELECT * FROM requests;";
            return SQLDataAccess.LoadData<RequestDataModel>(sql);

        }

    }
}
