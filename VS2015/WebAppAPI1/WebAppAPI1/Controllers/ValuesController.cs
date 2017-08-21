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

        // GET api/values/retrievevalues
        [HttpGet]
        [ActionName("RetrieveValues")]
        public IEnumerable<string> Get()
        {
            return new string[] { "retrieve value1", "Retrieve value2" };
        }

        // GET api/values/retrievebyid/5
        [HttpGet]
        [ActionName("RetrieveById")]
        public string Get(int id)
        {
            //return "value";
            return "RetrieveById: " + GetPrivate();
        }

        // GET api/values
        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<string> GetIt()
        {
            return new string[] { "Getit value1", "getit value2" };
        }

        // GET api/values/5
        [HttpGet]
        [ActionName("Get")]
        public string GetIt(int id)
        {
            //return "value";
            return "GetIt: " + GetPrivate();
        }

        [NonAction]
        // needed to stop GetPrivate() from matching with Get()
        public string GetPrivate()
        {
            return "value from GetPrivate";
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
