using Corona_B.I.E.R_V1.DataAccess;
using DataLayerLibrary.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayerLibrary.DataLogic
{
    public class CalendarProcessor
    {
        public static List<EventsDataModel> LoadAllEvents()
        {
            string sql = "SELECT * FROM schedule;";
            return SQLDataAccess.LoadData<EventsDataModel>(sql);
        }
    }
}
