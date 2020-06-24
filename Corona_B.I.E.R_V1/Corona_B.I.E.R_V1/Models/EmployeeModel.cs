using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Corona_B.I.E.R_V1.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Display(Name = "Voornaam")]
        public string Firstname { get; set; }
        [Display(Name = "Tussenvoegsel")]
        public string Prefix { get; set; }
        [Display(Name = "Achternaam")]
        public string Lastname { get; set; }
        [Display(Name = "Stad")]
        public string City { get; set; }
        [Display(Name = "Postcode")]
        public string Postalcode { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        public string ProfilePicturePath { get; set; }
        [Display(Name = "E-Mailadres")]
        public string Email { get; set; }
        [Display(Name = "Telefoonnummer")]
        public string Phone { get; set; }
        public string Password { get; set; }
        [Display(Name = "Vaardigheden")]
        public string Profession { get; set; }
        [Display(Name = "Rol")]
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
