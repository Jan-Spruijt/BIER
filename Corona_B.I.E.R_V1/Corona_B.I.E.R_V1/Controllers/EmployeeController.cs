using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.Models;
using Microsoft.AspNetCore.Mvc;
using LogicLayerLibrary;
using LogicLayerLibrary.ExtensionMethods;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Corona_B.I.E.R_V1.ExtensionMethods;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public EmployeeController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult RegisterEmployee()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegisterEmployee(EmployeeCreateModel employee)
        {
            if (ModelState.IsValid)
            {
                string salt = PasswordHashingLogic.GenerateSalt();
                string PasswordHash = PasswordHashingLogic.GeneratePasswordHash(employee.Password, salt);
                string uniqueFileName = null;
                if (employee.ProfilePicture != null)
                {
                  string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img", "ProfilePictures");
                  uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.ProfilePicture.FileName;
                  string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                  employee.ProfilePicture.CopyTo(new FileStream(filePath, FileMode.Create));

                }
                EmployeeProcessor.CreateEmployee(
                    employee.Firstname,
                    employee.Prefix,
                    employee.Lastname,
                    employee.City,
                    employee.Postalcode,
                    employee.Address,
                    uniqueFileName,
                    employee.Email,
                    employee.Phone,
                    salt,
                    PasswordHash,
                    employee.Profession,
                    employee.Role.ToString()
                );
                return RedirectToAction("ViewEmployees", "Employee");
            }

            return View();
        }
        [Authorize(Policy = "Admin")]
        public IActionResult ViewEmployees()
        {
            var data = EmployeeProcessor.LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    Id = row.ID,
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
            if (@User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            return View();
        }
        public IActionResult LogOutEmployee()
        {
            if (@User.Identity.IsAuthenticated)
            {
                HttpContext.SignOutAsync();
            }
            return RedirectToAction("LoginEmployee", "Employee");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoginEmployee(LoginEmployeeModel login)
        {
            if (ModelState.IsValid)
            {
                EmployeeDataModel employeeData = EmployeeProcessor.GetUserByEmail(login.Email);
                if (employeeData != null)
                {
                    if (PasswordHashingLogic.ValidateUser(login.Password, employeeData.Salt, employeeData.PasswordHash))
                    {
                        var employeeClaims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.Email, employeeData.Email),
                            new Claim(ClaimTypes.Role , employeeData.Role )
                        };

                        var employeeIdentity = new ClaimsIdentity(employeeClaims, "Employee Identity");
                        var employeePrincipal = new ClaimsPrincipal(new[] { employeeIdentity });

                        HttpContext.SignInAsync(employeePrincipal);
                        return RedirectToAction("Dashboard", "Home");

                    }
                }
                else
                {
                    ModelState.AddModelError("incorrectLogin", "The provided email and password do not match.");
                }
            }

            return View();
        }
    }
}