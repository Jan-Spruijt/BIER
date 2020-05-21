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
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MySqlX.XDevAPI.Relational;

namespace Corona_B.I.E.R_V1.Controllers
{

    public class IncidentController : Controller
    {
        public IActionResult CreateIncident()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateIncident(IncidentModel incident)
        {
            if (ModelState.IsValid)
            {
                IncidentProcessor.CreateIncident(
                    incident.Title,
                    incident.Context,
                    incident.Customer,
                    incident.CustomerEmail,
                    10
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
            // veranderen nav viewmodel
        public IActionResult DetailsIncident(int id)
        {
            var incidentData = IncidentProcessor.LoadIncidentById(id);
            var incidentStepData = IncidentStepProcessor.LoadStepsByIncidentId(id);
            List<IncidentStepModel> steps = new List<IncidentStepModel>();
            foreach (var step in incidentStepData)
            {
               steps.Add(new IncidentStepModel
                   {
                       context = step.context,
                       datetimeEnd = step.datetimeEnd,
                       datetimeStart = step.datetimeStart,
                       employee_id_createdby = step.employee_id_createdby,
                       employee_id_endedby = step.employee_id_endedby,
                       id = step.id,
                       incident_id = step.incident_id,
                       status = step.status,
                       stepnumber = step.stepnumber
                   }
                   
               ); 

            }
            IncidentDetailsViewModel incidentDetails = new IncidentDetailsViewModel
            {
                id = id,
                Context = incidentData.Context,
                Customer = incidentData.Customer,
                CustomerEmail = incidentData.CustomerEmail,
                Title = incidentData.Title,
                Status = incidentData.Status,
                steps = steps
            };

            //var data = IncidentProcessor.LoadIncidentById(id);
            //IncidentModel incident = new IncidentModel
            //{
            //    ID = data.ID,
            //    Context = data.Context,
            //    Customer = data.Customer,
            //    CustomerEmail = data.CustomerEmail,
            //    DateTimeEnded = data.DateTimeEnd,
            //    DateTimeStart = data.DateTimeStart,
            //    Employee_ID_EndedBy = data.Employee_ID_EndedBy,
            //    Employee_ID_CreatedBy = data.Employee_ID_CreatedBy,
            //    Status = data.Status,
            //    Title = data.Title
            //};
            return View(incidentDetails);
        }


        public IActionResult CloseIncident(int id)
        {
            IncidentProcessor.CloseIncident(
                id,
                11
            );
        
            return RedirectToAction("ViewIncidents", "Incident");
        }

        public IActionResult GoToDetails(int id)
        {
            return RedirectToAction("CloseIncident", new { Id = id });
        }

        public IActionResult CreateStep(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStep(IncidentStepModel data, int id)
        {
            if (ModelState.IsValid)
            {
                IncidentStepProcessor.CreateStep(
                    11,
                    data.id,
                    data.stepnumber,
                    data.context,
                    data.title
                    );
                RedirectToAction("ViewIncidents");
            }

            return View();
        }
    }
}
