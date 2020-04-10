using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.Extensionmethods;
using Corona_B.I.E.R_V1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult RegisterEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterEmployee(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeProcessor.CreateUser(
                    employee.Firstname,
                    employee.Prefix,
                    employee.Lastname,
                    employee.City,
                    employee.Postalcode,
                    employee.Address,
                    employee.ProfilePicturePath,
                    employee.Email,
                    employee.Phone,
                    employee.Password,
                    employee.Profession,
                    employee.Role.ToString()
                );
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        public IActionResult ViewEmployees()
        {
            var data = EmployeeProcessor.LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {

                    Firstname = row.Firstname,
                    Prefix = row.Lastnameprefix,
                    Lastname = row.Lastname,
                    City = row.City,
                    Postalcode = row.PostalCode,
                    Address = row.Address,
                    ProfilePicturePath = row.ProfilePicturePath,
                    Email = row.Email,
                    Phone = row.Phone,
                    Password = row.PasswordHash,
                    Profession = row.Profession,
                    Role = row.Role.ToEnum<EmployeeRole>()
                });
            }
            return View(employees);
        }
    }
}