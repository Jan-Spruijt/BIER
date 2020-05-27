using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.ExtensionMethods;
using Corona_B.I.E.R_V1.Models;
using Corona_B.I.E.R_V1.Models.CalendarModels;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Microsoft.AspNetCore.Mvc;
//

namespace Corona_B.I.E.R_V1.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Schedule()
        {
            if (TempData["error"] != null)
            {
                ViewBag.Error = TempData["error"];
                TempData.Remove("error");
            }
            return View();
        }

        public JsonResult GetEvents()
        {
            List<EventDataModel> dataEvents = CalendarProcessor.LoadAllEvents();
            List<CalendarEventModel> events = new List<CalendarEventModel>();
            foreach(EventDataModel dataModel in dataEvents)
            {
                EmployeeModel employee = new EmployeeModel();
                employee.MapDataModel(EmployeeProcessor.GetUserById(dataModel.Employee_ID));
                events.Add(new CalendarEventModel
                {
                    ID = dataModel.ID,
                    Employee_id = dataModel.Employee_ID,
                    EmployeeName = employee.Firstname+" "+employee.Prefix+" "+employee.Lastname,
                    Title = dataModel.Title,
                    Description = dataModel.Description,
                    DatetimeStart = dataModel.DatetimeStart,
                    DatetimeEnd = dataModel.DatetimeEnd,
                    Type = dataModel.Type

                });
            }
            return new JsonResult(new { Data = events });
        }

        [HttpPost]
        public IActionResult CreateEvent(CalendarCreateEventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                DateTime beginDateTime = (eventModel.DateStart + eventModel.TimeStart);
                DateTime endDateTime = (eventModel.DateEnd + eventModel.TimeEnd);
                CalendarProcessor.CreateEvent(
                    eventModel.Employee_ID,
                    eventModel.Title,
                    eventModel.Description,
                    beginDateTime,
                    endDateTime,
                    "standby"
                    );
            }
            else
            {

            }
            return RedirectToAction("Schedule", "Agenda");
        }
        [HttpPost]
        public IActionResult UpdateEvent(CalendarCreateEventModel eventModel)
        {
            if (ModelState.IsValid)
            {
                DateTime beginDateTime = (eventModel.DateStart + eventModel.TimeStart);
                DateTime endDateTime = (eventModel.DateEnd + eventModel.TimeEnd);
                CalendarProcessor.UpdateEvent(
                    eventModel.Event_ID,
                    eventModel.Employee_ID,
                    eventModel.Title,
                    eventModel.Description,
                    beginDateTime,
                    endDateTime,
                    "standby"
                    );
            }          
            return RedirectToAction("Schedule", "Agenda");
        }

        public IActionResult DeleteEvent(int id)
        {
            CalendarProcessor.DeleteEvent(id);
            return RedirectToAction("Schedule", "Agenda");
        }
    }
}