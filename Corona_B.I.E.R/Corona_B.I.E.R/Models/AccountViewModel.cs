using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Corona_B.I.E.R.Controllers;

namespace Corona_B.I.E.R.Models
{
    public class AccountViewModel
    {
        //123
        public string Username { get; 
            set; }
        public string Password { get; 
            set; }
        public string End { get; 
            set; }

    }
}