using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CTK.Controllers
{
    public class WeatherAPIController : ApiController
    {
        // GET: api/WeatherAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WeatherAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WeatherAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WeatherAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WeatherAPI/5
        public void Delete(int id)
        {
        }
    }
}
