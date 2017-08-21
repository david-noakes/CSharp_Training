using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppAPI1.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values/showallvalues
        [HttpGet]
        public IEnumerable<string> ShowAllValues()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/showvaluebyid/5
        [HttpGet]
        public string ShowValueById(int id)
        {
            return "value";
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
