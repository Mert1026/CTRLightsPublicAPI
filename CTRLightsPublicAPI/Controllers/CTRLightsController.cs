using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore;
using CTRLightsPublicAPI.Data.Models;
using Npgsql;
using CTRLightsPublicAPI.Data;

namespace CTRLightsPublicAPI.Controllers
{
    [Route("api/ctrlights")]
    [ApiController]
    public class CTRLightsController : Controller
    {
        private AppDbContext _context = new AppDbContext();

        [HttpGet("getTrafficLights")]
        public async Task<ActionResult> GetTrafficLights()
        {
            List<TrafficLights> trafficLights = [.. _context.TrafficLights];

            if (trafficLights.Count <= 0)
            {
                return Ok(new { TrafficLightsList = trafficLights, message = "No traffic lights registered!" });
            }
            else
            {
                return Ok(new { TrafficLightsList = trafficLights, message = "Success!" });
            }
        }

        [HttpGet("getAirQuality")]
        public async Task<ActionResult> GetAirQuality()
        {
            List<AirQuality> airQuality = [.. _context.AirQuality];

            if (airQuality.Count <= 0)
            {
                return Ok(new { AirQualityList = airQuality, message = "No information registered!" });
            }
            else
            {
                return Ok(new { AirQualityList = airQuality, message = "Success!" });
            }
        }
    }
}
