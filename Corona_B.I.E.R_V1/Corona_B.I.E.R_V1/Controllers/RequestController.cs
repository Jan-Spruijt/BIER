using System;
using System.Collections.Generic;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.Models;
using DataLayerLibrary.DataLogic;
using Microsoft.AspNetCore.Mvc;
using LogicLayerLibrary;
using LogicLayerLibrary.ExtensionMethods;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class RequestController : Controller
    {

        public IActionResult NewRequest()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NewRequest(RequestModel request)
        {
            if (ModelState.IsValid)
            {
                RequestProcessor.CreateRequest(
                    request.EmployeeId,
                    request.DateStart,
                    request.DateEnd,
                    request.Status.ToString(),
                    request.Type.ToString(),
                    request.Reason

                );
                return RedirectToAction("ViewRequests", "Request");
            }

            return View();
        }



        public IActionResult ViewRequests()
        {
            var data = RequestProcessor.LoadRequests();
            List<RequestModel> requests = new List<RequestModel>();
            foreach (var row in data)
            {
                EmployeeDataModel employee = EmployeeProcessor.GetUserById(row.employee_id);
                string name = employee.Firstname + " " + employee.Lastname;
                string date = Convert.ToString(row.datetimestart + " " + row.datetimeend);
                
                requests.Add(new RequestModel
                    {
                        Employeename = name,
                        EmployeeIdAcceptedby = row.employee_id_acceptedby,
                        Date = date,
                        Status = row.status.ToEnum<RequestStatus>(),
                        Type = row.request_type.ToEnum<RequestType>()
                });
            }


            return View(requests);
        }
    }
}