using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class LoginEmployeeModel
    {
        //[Display(Name = "E-mailadres")]
        //[Required(ErrorMessage = "Vul een e-mailadres in.")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "Vul een geldig e-mailadres in")]
        public string Email { get; set; }
        //[Required]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
