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


namespace Corona_B.I.E.R_V1.Controllers
{
    public class ProfileController : Controller
    {
        
        public IActionResult Index(EmployeeModel model)
        {
            EmployeeRole Role = model.Role;
            if(Role.ToString() == "User")
            {
                Employee(model);
            }
            else
            {
                Admin(model);
            }
            return View();
        }

        
        public IActionResult Admin(EmployeeModel model)
        {
            ViewData["Data"] = model;

            string Firstname = model.Firstname;
            string Prefix = model.Prefix;
            string Lastname = model.Lastname;
            string City = model.City;
            string Postalcode = model.Postalcode;
            string Address = model.Address;
            string ProfilePicturePath = model.ProfilePicturePath;
            string Email = model.Email;
            string Phone = model.Phone;
            string Password = model.Password;
            string Profession = model.Profession;
            EmployeeRole Role = model.Role;
            return View();
        }
        
        public IActionResult Employee(EmployeeModel model)
        {

                ViewData["Data"] = model;

            string Firstname = model.Firstname;
            string Prefix = model.Prefix;
            string Lastname = model.Lastname;
            string City = model.City;
            string Postalcode = model.Postalcode;
            string Address = model.Address;
            string ProfilePicturePath = model.ProfilePicturePath;
            string Email = model.Email;
            string Phone = model.Phone;
            string Password = model.Password;
            string Profession = model.Profession;

            return View();
        }


    }
}
