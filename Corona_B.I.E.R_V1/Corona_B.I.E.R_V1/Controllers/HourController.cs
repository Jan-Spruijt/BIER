﻿using System;
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
                return RedirectToAction("RegisterHour", "Hour");
            }

            return View();
        }


       /*public IActionResult Delete()
        {
            if (ModelState.IsValid)
            {
                HourProcessor.DeleteHours(id);
                return RedirectToAction("RegisterHour", "Hour");
            }
            return View();
        }*/

        public IActionResult ViewHours()
        {
            var data = HourProcessor.LoadHours();
            List<ViewHourModel> hours = new List<ViewHourModel>();
            foreach (var row in data)
            {
                hours.Add(new ViewHourModel
                {
                    Id = row.ID,
                    Employee_ID = row.Employee_Id,
                    StandbyHours = row.StandbyHours,
                    IncidentHours = row.IncidentHours,
                    TimeStamp = row.TimeStamp
                    

                });
            }
            

            return View(hours);
        }


        /*
        // GET: api/Hour
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Hour/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hour
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Hour/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
