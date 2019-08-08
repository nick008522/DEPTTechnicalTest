using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DEPTTechnicalTest.Models;
using Newtonsoft.Json;

namespace DEPTTechnicalTest.Services
{
    public class AirQualityRepository
    {
        public async Task<List<Measurement>> GetMeasurementForACityAsync(String city)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            String strBuilder = "";
            if (!String.IsNullOrEmpty(city)) strBuilder = "city=" + city;

            //Add new things here --------------------------------------------------------------------------------------------

            String questionmark = "";
            if (strBuilder.Length > 0) questionmark = "?";

            string jsonResult = await client.GetStringAsync("https://api.openaq.org/v1/measurements" + questionmark + strBuilder);

            var res = JsonConvert.DeserializeObject<Results>(jsonResult);
            return res.results;
        }
    }
}
