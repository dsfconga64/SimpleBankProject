using ConsoleApp1;
using Entities_POJO;
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
        public IHttpActionResult Get(int id)
        {
            try
            {
                var credMng = new CreditMangement();
                var apiResponse = new ApiResponse();

                var credit = new Credit
                {
                    CreditId = id
                };

                credit = credMng.RetrieveById(credit);

                apiResponse.Data = credit;

                return Ok(apiResponse);

            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // POST: api/Credit
        public IHttpActionResult Post(Credit credit)
        {
            try
            {
                var credMng = new CreditMangement();

                credMng.Create(credit);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Credit created";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // PUT: api/Credit/5
        public IHttpActionResult Put(Credit credit)
        {
            try
            {
                var credMng = new CreditMangement();

                credMng.Update(credit);

                apiResponse.Message = "Credit was updated";

                return Ok(apiResponse);

            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // DELETE: api/Credit/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var credMng = new CreditMangement();

                var credit = new Credit
                {
                    CreditId = id
                };

                credMng.Delete(credit);

                apiResponse.Message = "Credit deleted";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }
    }
}
