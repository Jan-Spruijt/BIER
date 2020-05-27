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

namespace Corona_B.I.E.R_V1.Controllers
{
    public class ProfileController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Admin(EmployeeCreateModel model)
        {
            ViewData["Data"] = model;

            string Firstname = model.Firstname;
            string Prefix = model.Prefix;
            string Lastname = model.Lastname;
            string City = model.City;
            string Postalcode = model.Postalcode;
            string Address = model.Address;
            //    string ProfilePicturePath = model.ProfilePicturePath;
            string Email = model.Email;
            string Phone = model.Phone;
            string Password = model.Password;
            string Profession = model.Profession;
            EmployeeRole Role = model.Role;
            return View();
        }

        public IActionResult Employee(EmployeeCreateModel model)
        {

            ViewData["Data"] = model;

            string Firstname = model.Firstname;
            string Prefix = model.Prefix;
            string Lastname = model.Lastname;
            string City = model.City;
            string Postalcode = model.Postalcode;
            string Address = model.Address;
            // string ProfilePicturePath = model.ProfilePicturePath;
            string Email = model.Email;
            string Phone = model.Phone;
            string Password = model.Password;
            string Profession = model.Profession;

            return View();
        }


        public IActionResult Profile(EmployeeModel model)
        {
            ViewData["Data"] = model;

            string Firstname = model.Firstname;
            string Prefix = model.Prefix;
            string Lastname = model.Lastname;
            string City = model.City;
            string Postalcode = model.Postalcode;
            string Address = model.Address;
            // string ProfilePicturePath = model.ProfilePicturePath;
            string Email = model.Email;
            string Phone = model.Phone;
            string Password = model.Password;
            string Profession = model.Profession;

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
    }
}
