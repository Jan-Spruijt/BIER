using System;
using System.Collections.Generic;
using System.Net;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.ExtensionMethods;
using Corona_B.I.E.R_V1.Models;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Microsoft.AspNetCore.Mvc;
using LogicLayerLibrary;
using LogicLayerLibrary.ExtensionMethods;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class RequestController : Controller
    {
        public IActionResult SelectRequest()
        {

            return View();
        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SelectRequest(RequestModel RequestType)
        {
            if (RequestType.Type == Models.RequestType.Exchange)
            {
                return RedirectToAction("ExchangeRequest", "Request");
            }if (RequestType.Type == Models.RequestType.Vacation)
            {
                return RedirectToAction("VacationRequest", "Request");
            }if (RequestType.Type == Models.RequestType.Absence)
            {
                return RedirectToAction("AbsenceRequest", "Request");
            }
            return View();
        }

        public IActionResult AbsenceRequest()
        {

            return View();
        }
        public IActionResult ExchangeRequest()
        {

            return View();
        }
        public IActionResult VacationRequest()
        {

            return View();
        }


        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AbsenceRequest(RequestModel request)
        {
            if (ModelState.IsValid)
            {
                DateTime Datestart = request.DateStart;
                TimeSpan TimeStart = request.TimeStart;

                DateTime DateEnd = request.DateEnd;
                TimeSpan TimeEnd = request.TimeEnd;

                DateTime DateTimeStart = Datestart + TimeStart;
                DateTime DateTimeEnd = DateEnd + TimeEnd;

                RequestProcessor.CreateExchangeRequest(
                    HttpContext.GetCurrentEmployeeModel().Id,
                    DateTimeStart,
                    DateTimeEnd,
                    request.Status.ToString(),
                    RequestType.Absence.ToString(),
                    request.Reason

                );
                return RedirectToAction("ViewRequests", "Request");
            }

            return View();
        }

       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExchangeRequest(RequestModel request)
        {
            if (ModelState.IsValid)
            {
                DateTime Datestart = request.DateStart;
                TimeSpan TimeStart = request.TimeStart;

                TimeSpan TimeEnd = request.TimeEnd;

                DateTime DateTimeStart = Datestart + TimeStart;
                DateTime DateTimeEnd = Datestart + TimeEnd;

                RequestProcessor.CreateExchangeRequest(
                    HttpContext.GetCurrentEmployeeModel().Id,
                    DateTimeStart,
                    DateTimeEnd,
                    request.Status.ToString(),
                    RequestType.Exchange.ToString(),
                    request.Reason

                );
                return RedirectToAction("ViewRequests", "Request");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VacationRequest(RequestModel request)
        {
            if (ModelState.IsValid)
            {


                RequestProcessor.CreateVacationRequest(
                    HttpContext.GetCurrentEmployeeModel().Id,
                    request.DateStart,
                    request.DateEnd,
                    request.Status.ToString(),
                    RequestType.Vacation.ToString()

                );
                return RedirectToAction("ViewRequests", "Request");
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            RequestDataModel request = RequestProcessor.GetRequestById(id);


            EmployeeDataModel employee = EmployeeProcessor.GetUserById(request.employee_id);

            string name = employee.Firstname + " " + employee.Lastname;

            DateTime dts = request.datetimestart;
            DateTime dte = request.datetimeend;

            DateTime datestart = dts.Date;
            DateTime dateend = dte.Date;
            TimeSpan timestart = dts.TimeOfDay;
            TimeSpan timeend = dte.TimeOfDay;


            RequestModel DetailsRequest = new RequestModel
            {
                Employeename = name,
                DateStart = datestart,
                DateEnd = dateend,
                TimeStart = timestart,
                TimeEnd = timeend,
                Reason = request.reason,
                Status = request.status.ToEnum<RequestStatus>()
            };

            return View(DetailsRequest);
        }

        public ActionResult Edit(int id)
        {

            RequestDataModel request = RequestProcessor.GetRequestById(id);

            DateTime dts = request.datetimestart;
            DateTime dte = request.datetimeend;

            DateTime datestart = dts.Date;
            DateTime dateend = dte.Date;
            TimeSpan timestart = dts.TimeOfDay;
            TimeSpan timeend = dte.TimeOfDay;


            RequestModel editRequest = new RequestModel
            {
                DateStart = datestart,
                DateEnd = dateend,
                TimeStart = timestart,
                TimeEnd = timeend,
                Reason = request.reason,
                Status = request.status.ToEnum<RequestStatus>()
            };

            return View(editRequest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, RequestModel request)
        {
            if (ModelState.IsValid)
            {

                DateTime Datestart = request.DateStart;
                TimeSpan TimeStart = request.TimeStart;

                DateTime DateEnd = request.DateEnd;
                TimeSpan TimeEnd = request.TimeEnd;

                DateTime DateTimeStart = Datestart + TimeStart;
                DateTime DateTimeEnd = DateEnd + TimeEnd;

                RequestProcessor.EditRequest(
                    id,
                    DateTimeStart,
                    DateTimeEnd,
                    request.Status.ToString(),
                    request.Reason
                );
                return RedirectToAction("ViewRequests", "Request");
            }

            return View();
        }

        public IActionResult Accept(int id)
        {
            if (ModelState.IsValid)
            {
                RequestProcessor.AcceptRequest(
                    id,
                    HttpContext.GetCurrentEmployeeModel().Id
                    
                );
                return RedirectToAction("ViewRequests", "Request");

            }

            return RedirectToAction("ViewRequests", "Request");
        }


        public IActionResult ViewRequests()
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