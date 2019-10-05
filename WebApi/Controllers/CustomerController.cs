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
    [ExceptionFilter]
    public class CustomerController : ApiController
    {
        ApiResponse apiResponse = new ApiResponse();
        // GET: api/Customer
        public IHttpActionResult Get()
        {
            apiResponse = new ApiResponse();

            var cxMng = new CustomerManagement();

            apiResponse.Data = cxMng.RetrieveAll();

            return Ok(apiResponse);
        }

        // GET: api/Customer/5
        public IHttpActionResult Get(string id)
        {


            try
            {
                var cxMng = new CustomerManagement();
                var customer = new Customer
                {
                    Id = id
                };

                customer = cxMng.RetrieveById(customer);

                apiResponse = new ApiResponse();

                apiResponse.Data = customer;

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId +"--"+ bex.AppMessage.Message));
            }
        }

        // POST: api/Customer
        public IHttpActionResult Post(Customer customer)
        {
            try
            {
                var cxMng = new CustomerManagement();
                cxMng.Create(customer);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Customer created";

                return Ok(apiResponse);

            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId +"--"+bex.AppMessage.Message));
            }
        }

        //PUT: api/Customer/5
        public IHttpActionResult Put(Customer customer)
        {
            try
            {
                var cxMng = new CustomerManagement();
                cxMng.Update(customer);
                apiResponse = new ApiResponse();

                apiResponse.Message = "Customer was updated";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        //// DELETE: api/Customer/5
        public IHttpActionResult Delete(string id)
        {
            try
            {
                var cxMng = new CustomerManagement();

                var customer = new Customer
                {
                    Id = id
                };

                cxMng.Delete(customer);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Customer Deleted";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }
    }
}
