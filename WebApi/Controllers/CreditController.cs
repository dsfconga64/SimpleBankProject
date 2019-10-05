using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CreditController : ApiController
    {
        // GET: api/Credit
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Credit/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Credit
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Credit/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Credit/5
        public void Delete(int id)
        {
        }
    }
}
