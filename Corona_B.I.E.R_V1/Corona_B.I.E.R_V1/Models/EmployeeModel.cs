using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Prefix { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Postalcode { get; set; }
        public string Address { get; set; }
        public string ProfilePicturePath { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Profession { get; set; }
        public EmployeeRole Role { get; set; }
        
    }

    public enum EmployeeRole
    {
        [Display(Name = "User")]
        User,
        [Display(Name = "Admin")]
        Admin
    }
}
