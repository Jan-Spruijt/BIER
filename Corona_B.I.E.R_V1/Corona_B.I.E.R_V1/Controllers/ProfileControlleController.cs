using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Corona_B.I.E.R_V1.Models;

namespace Corona_B.I.E.R_V1.Controllers
{
    public class ProfileControlleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}