using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.ExtensionMethods;
using Corona_B.I.E.R_V1.Models;
using DataLayerLibrary.DataLogic;
using LogicLayerLibrary.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Corona_B.I.E.R_V1.ViewComponents
{
    public class RequestDashboardViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var data = RequestProcessor.LoadRequests();
            List<RequestModel> requests = new List<RequestModel>();
            foreach (var row in data)
            {
                EmployeeDataModel employee = EmployeeProcessor.GetUserById(row.employee_id);

                EmployeeDataModel? AcceptedByEmployee = EmployeeProcessor.GetUserById(row.employee_id_acceptedby);
                string nameAccept = "Nog niet geaccepteerd";
                if (AcceptedByEmployee != null)
                {
                    nameAccept = AcceptedByEmployee.Firstname + " " + AcceptedByEmployee.Lastname;
                }

                string name = employee.Firstname + " " + employee.Lastname;
                string dateStart = row.datetimestart.ToShortDateString();
                string dateEnd = row.datetimeend.ToShortDateString();
                string TimeStart = row.datetimestart.ToShortTimeString();
                string TimeEnd = row.datetimeend.ToShortTimeString();

                requests.Add(new RequestModel
                {
                    RequestId = row.id,
                    Employeename = name,
                    EmployeeAcceptedbyName = nameAccept,
                    stringDateStart = dateStart,
                    stringDateEnd = dateEnd,
                    stringTimeStart = TimeStart,
                    stringTimeEnd = TimeEnd,
                    Status = row.status.ToEnum<RequestStatus>(),
                    Type = row.request_type.ToEnum<RequestType>()
                });
            }


            return View(requests);
        }

    }
}
