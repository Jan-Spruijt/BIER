using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Corona_B.I.E.R_V1.DataModels;
using Corona_B.I.E.R_V1.Models;
using DataLayerLibrary.DataModels;
using LogicLayerLibrary.ExtensionMethods;

namespace Corona_B.I.E.R_V1.ExtensionMethods
{
    public static class HourModelExtensions
    {
        public static void MapDataModel(this ViewHourModel HourModel, HourDataModel dataModel)
        {
            HourModel.Id = dataModel.ID;
            HourModel.Employee_ID = dataModel.Employee_Id;
            HourModel.StandbyHours = dataModel.StandbyHours;
            HourModel.IncidentHours = dataModel.IncidentHours;
            HourModel.TimeStamp = dataModel.TimeStamp;



    }
}
}