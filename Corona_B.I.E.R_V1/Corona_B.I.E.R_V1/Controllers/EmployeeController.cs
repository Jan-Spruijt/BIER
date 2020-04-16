using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.Models;
using Microsoft.AspNetCore.Mvc;
using LogicLayerLibrary;
using LogicLayerLibrary.ExtensionMethods;

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
                string salt = PasswordHashingLogic.GenerateSalt();
                string PasswordHash = PasswordHashingLogic.GeneratePasswordHash(employee.Password, salt);
                EmployeeProcessor.CreateEmployee(
                    employee.Firstname,
                    employee.Prefix,
                    employee.Lastname,
                    employee.City,
                    employee.Postalcode,
                    employee.Address,
                    employee.ProfilePicturePath,
                    employee.Email,
                    employee.Phone,
                    salt,
                    PasswordHash,
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
                    Profession = row.Profession,
                    Role = row.Role.ToEnum<EmployeeRole>()
                });
            }
            return View(employees);
        }

        public IActionResult LoginEmployee()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginEmployee(LoginEmployeeModel login)
        {
            EmployeeDataModel userData = EmployeeProcessor.GetUserByEmail(login.Email);
            bool isValid = PasswordHashingLogic.ValidateUser(login.Password, userData.Salt, userData.PasswordHash);

            if (isValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}