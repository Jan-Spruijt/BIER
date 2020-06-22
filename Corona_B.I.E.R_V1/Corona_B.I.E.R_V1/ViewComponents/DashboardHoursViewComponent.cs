using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.ExtensionMethods;
using Corona_B.I.E.R_V1.Models;
using Corona_B.I.E.R_V1.Models.CalendarModels;
using DataLayerLibrary.DataLogic;
using Microsoft.AspNetCore.Mvc;

namespace Corona_B.I.E.R_V1.ViewComponents
{
    public class DashboardHoursViewComponent : ViewComponent
    {


        public IViewComponentResult Invoke()
        {
            var data = HourProcessor.LoadHoursDashboard(HttpContext.GetCurrentEmployeeModel().Id);
            List<ViewHourModel> hours = new List<ViewHourModel>();
            foreach (var row in data)
            {
                var employeedata = EmployeeProcessor.GetUserById(row.Employee_Id);
                hours.Add(new ViewHourModel
                {
                    Id = row.ID,
                    Employee_ID = row.Employee_Id,
                    FirstName = employeedata.Firstname,
                    LastName = employeedata.Lastname,
                    StandbyHours = row.StandbyHours,
                    IncidentHours = row.IncidentHours,
                    TimeStamp = row.TimeStamp


                });
            }
            return View(hours);
        }
    }
}
