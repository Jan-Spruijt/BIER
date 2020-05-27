using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Corona_B.I.E.R_V1.Models;

namespace Corona_B.I.E.R_V1.Controllers
{


    public class HourController : ControllerBase
    {
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
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        // GET: api/Hour
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Hour/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hour
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Hour/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
