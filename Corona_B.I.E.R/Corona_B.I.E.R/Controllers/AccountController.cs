using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Corona_B.I.E.R.Models;
using Microsoft.AspNetCore.Http;



namespace Corona_B.I.E.R.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            ViewData["Message"] = "Your login page.";
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public string Login123(string Username, string Password)
        {
            if (Username == "123" && Password == "123")
            {
                string End = "oke";
                return End;
            }
            else
            {
                string End = "vals";
                return End;
            }


        }


        /*
        public AccountViewModel(string username, string password)
        {
            Username = username;
            Password = password;
        }


        public string Login()
        {
            if (Username == "123" && Password == "123")
            {
                End = "oke";
                return End;
            }
            else
            {
                End = "vals";
                return End;
            }


        }
        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new LoginViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        */
    }
}