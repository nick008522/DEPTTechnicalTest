using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DEPTTechnicalTest.Services;
using Newtonsoft.Json;
using DEPTTechnicalTest.Models;

namespace DEPTTechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirQualityRestAPIController : ControllerBase
    {
        private AirQualityRepository airQualityRepository = new AirQualityRepository();
        [Route("city/{city}")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetStringAsync(string city)
        {
            var measurements = await airQualityRepository.GetMeasurementForACityAsync(city);
            var json = JsonConvert.SerializeObject(measurements);
            return Ok(json);
        }
    }
}
