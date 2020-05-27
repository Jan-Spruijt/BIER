using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.ExtensionMethods;
using Corona_B.I.E.R_V1.Models;
using DataLayerLibrary.DataLogic;
using Microsoft.AspNetCore.Mvc;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class IncidentStepController : Controller
    {
        public IActionResult CreateStep(int id)
        {
            ViewData["id"] = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateStep(IncidentStepModel data, int id)
        {
            if (ModelState.IsValid)
            {
                IncidentStepProcessor.CreateStep(
                    HttpContext.GetCurrentEmployeeModel().Id,
                    data.id,
                    data.stepnumber,
                    data.context,
                    data.title
                );
                return RedirectToAction("DetailsIncident", "Incident", new { id });
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
                title = stepData.title,
                datetimeStart = stepData.datetimeStart,
                datetimeEnd = stepData.datetimeEnd,
                employee = employees,
                employee_id_createdby = stepData.employee_id_createdby,
                employee_id_endedby = stepData.employee_id_endedby,
                id = stepData.id,
                incident_id = stepData.incident_id,
                status = stepData.status
            };
            return View(stepDetails);
        }

        public IActionResult AddEmployeeToStep(int id)
        {
            IncidentStepEmployeeprocessor.AddEmployeeToStep(HttpContext.GetCurrentEmployeeModel().Id, id);
            return RedirectToAction("DetailsStep", new { id });
        }

        public IActionResult RemoveEmployeeFromStep(int id)
        {
            IncidentStepEmployeeprocessor.RemoveEmployeeFromStep(id, HttpContext.GetCurrentEmployeeModel().Id);
            return RedirectToAction("DetailsStep", new { id });
        }

        public IActionResult StartStep(int id)
        {
            IncidentStepProcessor.StartStep(id, HttpContext.GetCurrentEmployeeModel().Id);
            return RedirectToAction("DetailsStep", new { id });
        }

        public IActionResult CloseStep(int id)
        {
            IncidentStepProcessor.CloseStep(id, HttpContext.GetCurrentEmployeeModel().Id);
            return RedirectToAction("DetailsStep", new { id });
        }

        public IActionResult DeleteStep(int id, int incident_Id)
        {
            IncidentStepProcessor.DeleteStep(id);
            return RedirectToAction("DetailsIncident", "Incident", new {id = incident_Id});
        }
    }
}