using System;
using System.Collections.Generic;
using System.Text;
using Corona_B.I.E.R_V1.DataAccess;
using Corona_B.I.E.R_V1.DataModels;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class RequestProcessor
    {

        public static List<RequestDataModel> LoadRequests()
        {
            string sql = "SELECT * FROM requests;";
            return SQLDataAccess.LoadData<RequestDataModel>(sql);

        }

    }
}
