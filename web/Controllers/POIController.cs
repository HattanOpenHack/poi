using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using poi.Models;
using poi.Data;

namespace poi.Controllers
{
    [Produces("application/json")]
    [Route("api/poi")]
    public class POIController : ControllerBase
    {

        [HttpGet(Name = "GetAllPOIs")]
        [Produces("application/json", Type = typeof(POI))]
        public List<POI> GetAll()
        {
            return new List<POI>{
                new POI{
                    TripId="123",
                    PoiType = POIType.HardAcceleration,
                    Timestamp = DateTime.Now,
                    Deleted = false,
                    Latitude = 0,
                    Longitude =0
                }
            };
        }

       
    }
}