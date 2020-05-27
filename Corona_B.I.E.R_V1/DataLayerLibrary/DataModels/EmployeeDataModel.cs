namespace Corona_B.I.E.R_V1.DataModels
{
    public class EmployeeDataModel
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastnameprefix { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string ProfilePicturePath { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Salt { get; set; }
        public string PasswordHash { get; set; }
        public string Profession { get; set; }
        public string Role { get; set; }
        public string Availability { get; set; }
        public int TotalLogins { get; set; }
        public string LastLogin { get; set; }

        public string GetSalt()
        {
            return Salt;
        }
    }
}
