using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.APIDTOs;

namespace WebApplication3.Models
{
    public class StationReport
    {
        public int stationId { get; set; }
        public string StatusStation { get; set; }

        public StationReport(StationEntity station)
        {
            this.stationId = station.StationId;

            this.StatusStation = station.StatusStation;
        }

    }
}
