﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class DateDataModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime datetimeStart { get; set; }
        public DateTime datetimeEnd { get; set; }
        public string Type {get; set;}
    }
}
