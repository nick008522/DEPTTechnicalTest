using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DEPTTechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirQualityRestAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "this", "is", "hard", "coded" };
        }
    }
}
