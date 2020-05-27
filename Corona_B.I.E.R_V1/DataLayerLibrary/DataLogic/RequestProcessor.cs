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

        public static void CreateExchangeRequest(int EmployeeId, DateTime DateTimeStart, DateTime DateTimeEnd, string Status,
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
            string sql = @"INSERT INTO requests (employee_id, datetimestart, datetimeend, status, request_type, reason)
                            VALUES(@employee_id, @datetimestart, @datetimeend, @status, @request_type, @reason);";
            SQLDataAccess.SaveData(sql, request);

        }


        public static void CreateVacationRequest(int EmployeeId, DateTime DateTimeStart, DateTime DateTimeEnd, string Status,
            string RequestType)
        {

            RequestDataModel request = new RequestDataModel
            {
                employee_id = EmployeeId,
                datetimestart = DateTimeStart,
                datetimeend = DateTimeEnd,
                status = Status,
                request_type = RequestType,
            };
            string sql = @"INSERT INTO requests (employee_id, datetimestart, datetimeend, status, request_type)
                            VALUES(@employee_id, @datetimestart, @datetimeend, @status, @request_type);";
            SQLDataAccess.SaveData(sql, request);

        }

        public static void EditRequest(int id, DateTime DateTimeStart, DateTime DateTimeEnd, string Status, string Reason)
        {
            var StringDateTimeStart = DateTimeStart.ToString("yyyy/MM/dd HH:mm:ss");
            var StringDateTimeEnd = DateTimeEnd.ToString("yyyy/MM/dd HH:mm:ss");

            RequestDataModel request = new RequestDataModel
            {
                datetimestart = DateTimeStart,
                datetimeend = DateTimeEnd,
                status = Status,
                reason = Reason
            };
            string sql = $"Update requests set datetimestart = '{StringDateTimeStart}', datetimeEnd = '{StringDateTimeEnd}', status = '{request.status}', reason = '{request.reason}' WHERE id = '{id}';";
            SQLDataAccess.SaveData(sql, request);
        }

        public static void AcceptRequest(int id, int AcceptedBy)
        {
            RequestDataModel acceptrequest = new RequestDataModel
            {
                employee_id_acceptedby = AcceptedBy
            };
            string sql = $"Update requests set employee_id_acceptedby = '{acceptrequest.employee_id_acceptedby}' WHERE id = '{id}';";
            SQLDataAccess.SaveData(sql, acceptrequest);
        }


        public static List<RequestDataModel> LoadRequests()
        {
            string sql = "SELECT * FROM requests;";
            return SQLDataAccess.LoadData<RequestDataModel>(sql);

        }

        public static RequestDataModel GetRequestById(int id)
        {
            string sql = $"SELECT * FROM requests WHERE id = '{id}';";
            return SQLDataAccess.LoadFirstData<RequestDataModel>(sql);
        }

    }
}
