using Microsoft.AspNetCore.Mvc;
using CTRLightsPublicAPI.Data.Models;
using CTRLightsPublicAPI.Data;

namespace CTRLightsPublicAPI.Controllers
{
    [Route("api/ctrlights")]
    [ApiController]
    public class CTRLightsController : ControllerBase
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

        [HttpGet("getAirQualities")]
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

        [HttpGet("getAdminsProfiles")]
        public async Task<ActionResult> GetAdminsProfiles()
        {
            List<AdminUsers> adminUsers = [.. _context.AdminUsers];

            if (adminUsers.Count <= 0)
            {
                return Ok(new { AdminUsersList = adminUsers, message = "No information registered!" });
            }
            else
            {
                return Ok(new { AdminUsersList = adminUsers, message = "Success!" });
            }
        }

        [HttpGet("getEspDevices")]
        public async Task<ActionResult> GetEspDevices()
        {
            List<EspDevice> espDevices = [.. _context.EspDevice];

            if (espDevices.Count <= 0)
            {
                return Ok(new { EspDevicesList = espDevices, message = "No information registered!" });
            }
            else
            {
                return Ok(new { EspDevicesList = espDevices, message = "Success!" });
            }
        }
    }
}
