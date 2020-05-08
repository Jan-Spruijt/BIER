using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataLogic;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.ExtensionMethods;
using Corona_B.I.E.R_V1.Models;
using Microsoft.AspNetCore.Http;

namespace Corona_B.I.E.R_V1.WebLogic
{
    public class CurrentUser
    {
        public static EmployeeModel GetCurrentEmployeeModel(HttpContext httpContext)
        {
            Claim email = httpContext.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email);
            if (email == null) return null;
            EmployeeDataModel dataModel = EmployeeProcessor.GetUserByEmail(email.Value);
            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.MapDataModel(dataModel);
            return employeeModel;
        }
    }
}
