using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.Models;
using Corona_B.I.E.R_V1.Models.CalendarModels;
using DataLayerLibrary.DataLogic;
using Microsoft.AspNetCore.Mvc;

namespace Corona_B.I.E.R_V1.ViewComponents
{
    public class DashboardIncidentsViewComponent : ViewComponent
    {
        //public IViewComponentResult Invoke()
        //{
        //    CalendarCreateEventModel createEventModel = new CalendarCreateEventModel();
        //    createEventModel.Employees = new List<EmployeeCalendarModel>();
        //    var data = EmployeeProcessor.LoadEmployees();
        //    foreach (var row in data)
        //    {
        //        createEventModel.Employees.Add(new EmployeeCalendarModel
        //        {
        //            id = row.ID,
        //            Firstname = row.Firstname,
        //            Prefix = row.Lastnameprefix,
        //            Lastname = row.Lastname,
        //            ProfilePicturePath = row.ProfilePicturePath,
        //        });
        //    }
        //    return View(createEventModel);
        //}

        public IViewComponentResult Invoke()
        {
            var data = IncidentProcessor.LoadIncidents();
            List<IncidentModel> incidents = new List<IncidentModel>();
            foreach (var row in data)
            {
                incidents.Add(new IncidentModel
                    {
                        ID = row.ID,
                        Title = row.Title,
                        Context = row.Context,
                        Customer = row.Customer,
                        Employee_ID_CreatedBy = row.Employee_ID_CreatedBy,
                        Employee_ID_EndedBy = row.Employee_ID_EndedBy,
                        CustomerEmail = row.CustomerEmail,
                        DateTimeStart = row.DateTimeStart,
                        DateTimeEnded = row.DateTimeEnd,
                        Status = row.Status
                    }
                );
            }

            var sortedIncidents = incidents.Where(q => q.Status == "open").Take(3);
            return View(sortedIncidents);
        }
    }
}
