using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.Models;
using DataLayerLibrary.DataLogic;
using Microsoft.AspNetCore.Mvc;
using LogicLayerLibrary;
using LogicLayerLibrary.ExtensionMethods;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class IncidentController : Controller
    {
        public IActionResult CreateIncident()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public IActionResult CreateIncident(IncidentModel incident)
        {
            if (ModelState.IsValid)
            {
                IncidentProcessor.CreateIncident(
                    incident.Title,
                    incident.Context,
                    incident.Customer,
                    incident.CustomerEmail,
                    1
                );
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public IActionResult ViewIncidents()
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

            return View(incidents);
        }

        public IActionResult Edit(int id)
        {
            IncidentProcessor.UpdateIncidentData(id, 11, DateTime.Now, "closed");
            return RedirectToAction("ViewIncidents");
        }
    }
}
