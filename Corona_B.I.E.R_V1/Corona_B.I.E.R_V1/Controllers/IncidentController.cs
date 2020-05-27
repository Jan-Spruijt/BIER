using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.ExtensionMethods;
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
                    HttpContext.GetCurrentEmployeeModel().Id
                );
                return RedirectToAction("ViewIncidents");
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

            var sortedIncidents = incidents.OrderBy(q => q.Status.ToString().Length).ThenByDescending(q => q.DateTimeStart);
            return View(sortedIncidents);
        }
        public IActionResult DetailsIncident(int id)
        {
            int count = 0;
            var incidentData = IncidentProcessor.LoadIncidentById(id);
            var incidentEmployeeData = IncidentEmployeeProcessor.LoadEmployeesByIncidentId(id);
            var incidentStepData = IncidentStepProcessor.LoadStepsByIncidentId(id);
            List<IncidentStepModel> steps = new List<IncidentStepModel>();
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var step in incidentStepData)
            {
                count++;
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
                    stepnumber = count
                }
                );
            }

            foreach (var employee in incidentEmployeeData)
            {
                var data = EmployeeProcessor.GetUserById(employee.Employee_Id);
                employees.Add( new EmployeeModel
                    {
                        Firstname = data.Firstname,
                        Lastname = data.Lastname,
                        ProfilePicturePath = data.ProfilePicturePath,
                        Id = data.ID
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
                steps = steps,
                employees = employees
            };
            return View(incidentDetails);
        }

        public IActionResult CloseIncident(int id)
        {
            IncidentProcessor.CloseIncident(
                id,
                HttpContext.GetCurrentEmployeeModel().Id
            );

            return RedirectToAction("ViewIncidents", "Incident");
        }

        public IActionResult AddEmployeeToIncident(int id)
        {
            IncidentEmployeeProcessor.AddEmployeeToIncident(id, HttpContext.GetCurrentEmployeeModel().Id);
            return RedirectToAction("DetailsIncident", new { id });
        }

        public IActionResult RemoveEmployeeFromIncident(int id)
        {
            var stepData = IncidentStepProcessor.LoadStepsByIncidentId(id);
            foreach (var step in stepData)
            {
                var stepEmployeeData = IncidentStepEmployeeprocessor.LoadEmployeesFromStepId(step.id);
                foreach (var employee in stepEmployeeData)
                {
                    if (employee.id == HttpContext.GetCurrentEmployeeModel().Id)
                    {
                        IncidentStepEmployeeprocessor.RemoveEmployeeFromStep(step.id, HttpContext.GetCurrentEmployeeModel().Id);
                    }
                }
            }
            IncidentEmployeeProcessor.RemoveEmployeeFromIncident(id, HttpContext.GetCurrentEmployeeModel().Id);
            return RedirectToAction("DetailsIncident", new { id=id });
        }

        public IActionResult DeleteIncident(int id)
        {
            var steps = IncidentStepProcessor.LoadStepsByIncidentId(id);
            var incidentEmployees = IncidentEmployeeProcessor.LoadEmployeesByIncidentId(id);
            foreach (var employee in incidentEmployees)
            {
                IncidentEmployeeProcessor.RemoveEmployeeFromIncident(id, employee.Employee_Id);
            }
            foreach (var step in steps)
            {
                IncidentStepProcessor.DeleteStep(step.id);
            }
            IncidentProcessor.DeleteIncident(id);
            return RedirectToAction("ViewIncidents");
        }
    }
}
