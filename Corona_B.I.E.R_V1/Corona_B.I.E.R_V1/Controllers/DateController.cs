using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.Models;
using DataLayerLibrary.DataLogic;
using Microsoft.AspNetCore.Mvc;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class DateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewDates()
        {
            var data = DateProcessor.LoadDates();
            List<DateModel> dates = new List<DateModel>();
            foreach (var row in data)
            {
                dates.Add(new DateModel
                {
                    Id = row.Id,
                    Title = row.Title,
                    Description = row.Description,
                    Start = row.datetimeStart,
                    End = row.datetimeEnd,
                    Type = row.Type
                });
            }
            return View(dates);
        }
    }
}