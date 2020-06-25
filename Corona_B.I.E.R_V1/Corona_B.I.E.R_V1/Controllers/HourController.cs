using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Corona_B.I.E.R_V1.Models;
using System.IO;
using System.Security.Claims;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using LogicLayerLibrary;
using LogicLayerLibrary.ExtensionMethods;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using DataLayerLibrary.DataLogic;
using Corona_B.I.E.R_V1.ExtensionMethods;



namespace Corona_B.I.E.R_V1.Controllers
{
    [Authorize]
    public class HourController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public HourController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult RegisterHour()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterHour(RegisterHourModel Hour)
        {
            if (ModelState.IsValid)
            {
                HourProcessor.RegisterHour(
                    HttpContext.GetCurrentEmployeeModel().Id,
                    Hour.StandbyHours,
                    Hour.IncidentHours    
                );
                return RedirectToAction("ViewHours");
            }

            return View();
        }




        public IActionResult ViewHours()
        {
            if (HttpContext.GetCurrentEmployeeModel().Role.ToString() == "Admin")
            {
                var data = HourProcessor.LoadHours();
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


                    }) ;
                }
                return View(hours);
            }
            else
            {
                var data = HourProcessor.LoadHours(HttpContext.GetCurrentEmployeeModel().Id);
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

        public IActionResult Delete(int id)
        {
            HourProcessor.DeleteHours(id);
            return RedirectToAction("ViewHours");
        }

    }
}
