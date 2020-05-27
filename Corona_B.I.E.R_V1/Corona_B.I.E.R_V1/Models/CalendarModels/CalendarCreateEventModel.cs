using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models.CalendarModels
{
    public class CalendarCreateEventModel
    {

        public int Event_ID { get; set; }
        [Required]
        [Display(Name = "Werknemer")]
        public int Employee_ID { get; set; }
        public List<EmployeeCalendarModel> Employees { get; set; }
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Display(Name = "Beschrijving")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Begindatum")]
        [DataType(DataType.Date)]
        public DateTime DateStart { get; set; }
        [Required]
        [Display(Name = "Begintijd")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        [RegularExpression(@"((([0-1][0-9])|(2[0-3]))(:[0-5][0-9])(:[0-5][0-9])?)", ErrorMessage = "Tijd moet tussen 00:00 en 23:59 zijn")]
        public TimeSpan TimeStart { get; set; }
        [Required]
        [Display(Name = "Einddatum")]
        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }
        [Required]
        [Display(Name = "Eindtijd")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh\\:mm}")]
        [RegularExpression(@"((([0-1][0-9])|(2[0-3]))(:[0-5][0-9])(:[0-5][0-9])?)", ErrorMessage = "Tijd moet tussen 00:00 en 23:59 zijn")]
        public TimeSpan TimeEnd { get; set; }
        public string Type { get; set; }
    }
}
