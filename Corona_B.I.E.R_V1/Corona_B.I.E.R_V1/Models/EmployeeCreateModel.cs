using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Corona_B.I.E.R_V1.Models
{
    public class EmployeeCreateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vul een voornaam in")]
        [Display(Name = "Voornaam")]
        public string Firstname { get; set; }

        [Display(Name = "Tussenvoegsel")]
        public string Prefix { get; set; }

        [Display(Name = "Achternaam")]
        [Required(ErrorMessage = "Vul een achternaam in")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Vul een plaats in")]
        [Display(Name = "Plaats")]
        public string City { get; set; }

        [Required(ErrorMessage = "Vul een postcode in")]
        [Display(Name = "Postcode")]
        [DataType(DataType.PostalCode)]
        public string Postalcode { get; set; }

        [Required(ErrorMessage = "Vul een adres in")]
        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Profielfoto")]
        //   [DataType(DataType.ImageUrl)]
        public IFormFile ProfilePicture { get; set; }


        [Display(Name = "E-mailadres")]
        [Required(ErrorMessage = "Vul een e-mailadres in.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vul een geldig e-mailadres in")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bevestig uw E-mailadres")]
        [Display(Name = "Bevestig e-mailadres")]
        [Compare("Email", ErrorMessage = "Opgegeven e-mails matchen niet")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Telefoon")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Vul een geldig telefoonummer in")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Vul een wachtwoord in")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Wachtwoord moet minimaal 8 characters lang zijn")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bevestig uw wachtwoord")]
        [Display(Name = "Bevestig wachtwoord")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Opgegeven wachtwoorden matchen niet")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Vul een of meerdere vaardigheden in")]
        [Display(Name = "Vaardigheden")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "Vul de rechten in")]
        [Display(Name = "Rechten")]
        public EmployeeRole Role { get; set; }

    }
}
