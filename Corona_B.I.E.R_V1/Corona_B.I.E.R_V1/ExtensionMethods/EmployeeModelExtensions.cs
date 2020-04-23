using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.Models;
using LogicLayerLibrary.ExtensionMethods;

namespace Corona_B.I.E.R_V1.ExtensionMethods
{
    public static class EmployeeModelExtensions
    {
        public static void MapDataModel(this EmployeeModel employeeModel, EmployeeDataModel dataModel)
        {
            employeeModel.Id = dataModel.ID;
            employeeModel.Firstname = dataModel.Firstname;
            employeeModel.Prefix = dataModel.Lastnameprefix;
            employeeModel.Lastname = dataModel.Lastname;
            employeeModel.City = dataModel.City;
            employeeModel.Postalcode = dataModel.PostalCode;
            employeeModel.Address = dataModel.Address;
            employeeModel.ProfilePicturePath = dataModel.ProfilePicturePath;
            employeeModel.Email = dataModel.Email;
            employeeModel.Phone = dataModel.Phone;
            employeeModel.Profession = dataModel.Profession;
            employeeModel.Role = dataModel.Role.ToEnum<EmployeeRole>();
        }
    }
}