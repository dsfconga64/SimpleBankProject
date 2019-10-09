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
    public class AddressController : ApiController
    {
        ApiResponse apiResponse = new ApiResponse();
        // GET: api/Address
        public IHttpActionResult Get()
        {
            try
            {
                var addMng = new AddressManagement();
                var apiResponse = new ApiResponse();

                apiResponse.Data = addMng.RetrieveAll();

                return Ok(apiResponse);

            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // GET: api/Address/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                var addMng = new AddressManagement();
                var apiResponse = new ApiResponse();

                var address = new Address
                {
                    AddresId = id
                };

                address = addMng.RetrieveById(address);

                apiResponse.Data = address;

                return Ok(apiResponse);

            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // POST: api/Address
        public IHttpActionResult Post(Address address)
        {
            try
            {
                var addMng = new AddressManagement();

                addMng.Create(address);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Address Created";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // PUT: api/Address/5
        public IHttpActionResult Put(Address address)
        {
            try
            {
                var addMng = new AddressManagement();
                addMng.Update(address);

                apiResponse.Message = "Address updated";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // DELETE: api/Address/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var addMng = new AddressManagement();

                var address = new Address
                {
                    AddresId = id
                };

                addMng.Delete(address);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Address Delted";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }
    }
}
