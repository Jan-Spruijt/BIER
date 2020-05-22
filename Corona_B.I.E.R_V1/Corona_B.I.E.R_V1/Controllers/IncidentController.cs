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
                    11
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
            return View(incidentDetails);
        }

        //public IActionResult GoToDetails(int id)
        //{
        //    return RedirectToAction("CloseIncident", new { Id = id });
        //}

        public IActionResult CloseIncident(int id)
        {
            IncidentProcessor.CloseIncident(
                id,
                11
            );

            return RedirectToAction("ViewIncidents", "Incident");
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
                return RedirectToAction("ViewIncidents", "Incident");
            }
            return View();
        }

        public IActionResult DetailsStep(int id)
        {
            var stepData = IncidentStepProcessor.LoadStepById(id);
            var StepEmployeeData = IncidentStepEmployeeprocessor.LoadEmployeesFromStepId(id);
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var employee in StepEmployeeData)
            {
                var employeeData = EmployeeProcessor.GetUserById(employee.employee_id);
                employees.Add(new EmployeeModel
                {
                    Address = employeeData.Address,
                    City = employeeData.City,
                    Firstname = employeeData.Firstname,
                    ProfilePicturePath = employeeData.ProfilePicturePath,
                    Profession = employeeData.Profession,
                    Lastname = employeeData.Lastname,
                    Email = employeeData.Email,
                    Id = employeeData.ID,
                    Phone = employeeData.Phone
                }
                );
            }
            IncidentStepDetailsViewModel stepDetails = new IncidentStepDetailsViewModel
            { 
                context = stepData.context,
                datetimeStart = stepData.datetimeStart,
                datetimeEnd = stepData.datetimeEnd,
                employee = employees,
                employee_id_createdby = stepData.employee_id_createdby,
                employee_id_endedby = stepData.employee_id_endedby,
                id = stepData.id,
                incident_id = stepData.incident_id,
                status = stepData.status,
                stepnumber = stepData.stepnumber,
            };
            return View(stepDetails);
        }

        public IActionResult AddEmployeeToStep(int id)
        {
            IncidentStepEmployeeprocessor.AddEmployeeToStep(11,id);
            return RedirectToAction("DetailsStep", new {id});
        }
    }
}
