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
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class IncidentController : Controller
    {
        public IActionResult CreateIncident()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public IActionResult CreateIncident(IncidentModel incident)
        {
            if (ModelState.IsValid)
            {
                
            }

            return View();
        }
    }
}
