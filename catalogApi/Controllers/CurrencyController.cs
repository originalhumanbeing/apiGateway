using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace catalogApi.Controllers
{
    [Route("api/currency")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/currency
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "usd", "inr", "jpy" };
        }
    } 
}
