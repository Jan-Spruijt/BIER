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
        [Required(ErrorMessage = "Vul een voornaam in")]
        [Display(Name = "Voornaam")]
        public string Firstname { get; set; }

        [Display(Name = "Tussenvoegsel")]
        public string Prefix { get; set; }

        [Display(Name = "Achternaam")]
        [Required(ErrorMessage = "Vul een achternaam in")]
        public string Lastname { get; set; }
        
        [Required]
        [Display(Name = "Plaats")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Postcode")]
        [DataType(DataType.PostalCode)]
        public string Postalcode { get; set; }

        [Required]
        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Profielfoto")]
     //   [DataType(DataType.ImageUrl)]
        public string ProfilePicturePath { get; set; }
    

        [Display(Name = "E-mailadres")]
        [Required(ErrorMessage = "Vul een e-mailadres in.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vul een geldig e-mailadres in")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Bevestig e-mailadres")]
        [Compare("Email", ErrorMessage = "Opgegeven e-mails matchen niet")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Telefoon")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Vul een geldig telefoonummer in")]
        public string Phone { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Wachtwoord moet minimaal 8 characters lang zijn")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Bevestig wachtwoord")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Opgegeven wachtwoorden matchen niet")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Vaardigheden")]
        public string Profession { get; set; }

        [Required]
        [Display(Name = "Rechten")]
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
