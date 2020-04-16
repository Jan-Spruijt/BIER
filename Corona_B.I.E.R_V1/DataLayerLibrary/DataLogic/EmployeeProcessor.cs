using Corona_B.I.E.R_V1.DataAccess;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1;
using System.Collections.Generic;

namespace Corona_B.I.E.R_V1.DataLogic
{
    public class EmployeeProcessor
    {
        public static void CreateEmployee(string firstname, string prefix, string lastname, string city, string postalCode,
                                        string address, string profilePicturePath, string email, string phone, string salt,
                                        string password, string profession, string role)
        {
            EmployeeDataModel data = new EmployeeDataModel
            {

                Firstname = firstname,
                Lastnameprefix = prefix,
                Lastname = lastname,
                City = city,
                PostalCode = postalCode,
                Address = address,
                ProfilePicturePath = profilePicturePath,
                Email = email,
                Phone = phone,
                Salt = salt,
                PasswordHash = password,
                Profession = profession,
                Role = role

            };
            string sql = @"INSERT INTO employee (firstname, lastnamePrefix, lastname, city, postalCode, address, profilePicturePath, email, phone,
                                                  salt, passwordHash, profession, role)
                            VALUES(@Firstname, @Lastnameprefix, @Lastname, @City, @PostalCode, @Address, @ProfilePicturePath, @Email,
                                    @Phone ,@Salt ,@PasswordHash ,@Profession ,@Role);";
            SQLDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeDataModel> LoadEmployees()
        {
            string sql = "SELECT firstname, lastnamePrefix, lastname, city, postalCode, address, profilePicturePath, email," +
                         "phone, salt, passwordHash, profession, role FROM employee;";
            return SQLDataAccess.LoadData<EmployeeDataModel>(sql);

        }

        public static EmployeeDataModel GetUserByEmail(string email)
        {
            string sql = $"SELECT * FROM employee WHERE email = '{email}';";
            return SQLDataAccess.LoadFirstData<EmployeeDataModel>(sql);
        }
    }
}
