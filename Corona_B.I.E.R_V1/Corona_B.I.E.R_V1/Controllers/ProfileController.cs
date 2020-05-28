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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Corona_B.I.E.R_V1.ExtensionMethods;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public ProfileController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            EmployeeModel employee = HttpContext.GetCurrentEmployeeModel();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ADMIN(EmployeeCreateModel employee)
        {

            if (ModelState.IsValid)
            {               
                EmployeeProcessor.EditEmployee(
                        employee.Firstname,
                        employee.Prefix,
                        employee.Lastname,
                        employee.City,
                        employee.Postalcode,
                        employee.Address,
                        //employee.ProfilePicturePath,
                        employee.Email,
                        employee.Phone,
                        //employee.Salt,
                        employee.Password,
                        employee.Profession,
                        "Admin",
                        HttpContext.GetCurrentEmployeeModel().Id);
                return RedirectToAction("Profile", "Profile");
            }
            return View();
        }

        public IActionResult Admin(EmployeeCreateModel model)
        {
                EmployeeModel employee = HttpContext.GetCurrentEmployeeModel();
                TempData["Data"] = employee;
            try
            {
                // string salt = PasswordHashingLogic.GenerateSalt();
                // string PasswordHash = PasswordHashingLogic.GeneratePasswordHash(employee.Password, salt);
                string uniqueFileName = null;

                if (employee.ProfilePicturePath != null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "img", "ProfilePictures");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfilePicture.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.ProfilePicture.CopyTo(new FileStream(filePath, FileMode.Create));
                    employee.ProfilePicturePath = filePath;
                }
            }
            catch
            {
                
            }
            return View();
        }

        public IActionResult Employee()
        {
            EmployeeModel employee = HttpContext.GetCurrentEmployeeModel();
            employee = HttpContext.GetCurrentEmployeeModel();
                TempData["Data"] = employee;
            try
            {
                string Role = " ";
                if (employee.Role == EmployeeRole.Admin)
                {
                    Role = "Admin";
                }
                else { Role = "User"; }
                EmployeeProcessor.EditEmployee(
                        employee.Firstname,
                        employee.Prefix,
                        employee.Lastname,
                        employee.City,
                        employee.Postalcode,
                        employee.Address,
                      //  employee.ProfilePicturePath,
                        employee.Email,
                        employee.Phone,
                        //employee.Salt,
                        employee.Password,
                        employee.Profession,
                        Role,
                        employee.Id);
            }
            catch
            {
                return View();
            }
            
            return View();
        }


        public IActionResult Profile(EmployeeModel model)
        {
            EmployeeModel employee = HttpContext.GetCurrentEmployeeModel();
            ViewData["Data"] = employee;
            return View();
        }

        public IActionResult Switch(EmployeeModel model)
        {

            if (ModelState.IsValid)
            {
                if (model.Role == EmployeeRole.Admin)
                {
                    return RedirectToAction("Admin", "Profile");
                }
                else if (model.Role == EmployeeRole.User)
                {
                    return RedirectToAction("Employee", "Profile");
                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult EditData(EmployeeModel employee)
        {
            
            //try
            //{
                string Role = " ";
                if (employee.Role == EmployeeRole.Admin)
                {
                    Role = "Admin";
                }
                else { Role = "User"; }
                EmployeeProcessor.EditEmployee(
                        employee.Firstname,
                        employee.Prefix,
                        employee.Lastname,
                        employee.City,
                        employee.Postalcode,
                        employee.Address,
                       // employee.ProfilePicturePath,
                        employee.Email,
                        employee.Phone,
                        //employee.Salt,
                        employee.Password,
                        employee.Profession,
                        Role,
                        employee.Id);
            //}
            //catch
            //{
            //    return RedirectToAction("Profile", "Profile");
            //}


            return RedirectToAction("Profile", "Profile");
        }
    }
}
