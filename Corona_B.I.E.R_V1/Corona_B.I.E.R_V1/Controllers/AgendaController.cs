using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayerLibrary.DataLogic;
using DataLayerLibrary.DataModels;
using Microsoft.AspNetCore.Mvc;
//

namespace Corona_B.I.E.R_V1.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Schedule()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
         List<EventsDataModel> events =  CalendarProcessor.LoadAllEvents();
            return new JsonResult (new{ Data = events });
        }

        public IActionResult CreateEvent()
        {
            return View();
        }
    }
}