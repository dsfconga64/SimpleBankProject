using ConsoleApp1;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class CreditController : ApiController
    {
        ApiResponse apiResponse = new ApiResponse();
        public IHttpActionResult Get()
        {
            try
            {
                var credMng = new CreditMangement();
                var apiResponse = new ApiResponse();

                apiResponse.Data = credMng.RetrieveAll();

                return Ok(apiResponse);

            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
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
