using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DEPTTechnicalTest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DEPTTechnicalTest.Controllers
{
    public class AirQualityController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index(string city)
        {
            Results res = null;
            if (!(city is null))
             res = await GetAirQuality(String.IsNullOrEmpty(city) ? "" : city );

            return View(res);
        }


        public static async Task<Results> GetAirQuality(String city)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            String strBuilder = "" ;
            if (!String.IsNullOrEmpty(city)) strBuilder= "city=" + city;

            //Add new things here --------------------------------------------------------------------------------------------

            String questionmark = "";
            if (strBuilder.Length > 0) questionmark = "?";

                string jsonResult = await client.GetStringAsync("https://api.openaq.org/v1/measurements" + questionmark + strBuilder);

            var res = JsonConvert.DeserializeObject<Results>(jsonResult);
            return res;
        }
    }
}
