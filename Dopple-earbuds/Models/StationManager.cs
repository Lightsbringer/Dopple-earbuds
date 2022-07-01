using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.APIDTOs;

namespace WebApplication3.Models
{
    public class StationManager : ApiHandler
    {
        List<StationEntity> stations = new List<StationEntity>();
        public StationManager(List<StationEntity> stations)
        {
            this.stations = stations;
        }

        public IEnumerable<StationEntity> Get()
        {
            return stations;
        }

        //public IActionResult StationReport(int ID) => Models.StationReport;
    }
}
