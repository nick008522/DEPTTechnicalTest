using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DEPTTechnicalTest.Models;
using DEPTTechnicalTest.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DEPTTechnicalTest.Controllers
{
    public class AirQualityController : Controller
    {
        private static AirQualityRepository airQualityRepository = new AirQualityRepository();
        // GET: /<controller>/
        public async Task<IActionResult> Index(string city)
        {
            List<Measurement> res = await GetAirQuality(city);
            return View(res);
        }


        public static async Task<List<Measurement>> GetAirQuality(String city)
        {
            var measurements = await airQualityRepository.GetMeasurementForACityAsync(city);
            return measurements;
        }
    }
}
