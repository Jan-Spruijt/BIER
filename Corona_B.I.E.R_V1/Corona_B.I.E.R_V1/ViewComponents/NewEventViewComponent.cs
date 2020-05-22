using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.Models;
using Microsoft.AspNetCore.Mvc;
using Corona_B.I.E.R_V1.ExtensionMethods;
using Org.BouncyCastle.Asn1.Cmp;
using Corona_B.I.E.R_V1.Models.CalendarModels;

namespace Corona_B.I.E.R_V1.ViewComponents
{
    public class NewEventViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CalendarCreateEventModel createEventModel = new CalendarCreateEventModel();
            createEventModel.Employees = new List<EmployeeCalendarModel>();
            var data = EmployeeProcessor.LoadEmployees();    
            foreach (var row in data)
            {
               createEventModel.Employees.Add(new EmployeeCalendarModel
                {
                    id = row.ID,
                    Firstname = row.Firstname,
                    Prefix = row.Lastnameprefix,
                    Lastname = row.Lastname,     
                    ProfilePicturePath = row.ProfilePicturePath,         
                });
            }
            return View(createEventModel);
        }
    }
}
