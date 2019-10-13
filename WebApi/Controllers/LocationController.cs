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
    public class LocationController : ApiController
    {
        ApiResponse apiResponse = new ApiResponse();
        public IHttpActionResult Get()
        {
            try
            {
                var accMng = new LocationManagement();
                apiResponse = new ApiResponse();

                apiResponse.Data = accMng.RetrieveAll();

                return Ok(apiResponse);

            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // GET: api/Account/5
        public IHttpActionResult Get(string id)
        {
            try
            {
                var accMng = new LocationManagement();

                var location = new Location
                {
                    IdLocation = id
                };

                location = accMng.RetrieveById(location);

                apiResponse = new ApiResponse();

                apiResponse.Data = location;


                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // POST: api/Account
        public IHttpActionResult Post(Location location)
        {
            try
            {
                var accMng = new LocationManagement();

                accMng.Create(location);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Location Created";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // PUT: api/Account/5
        public IHttpActionResult Put(Location location)
        {
            try
            {
                var accMng = new LocationManagement();

                accMng.Update(location);

                apiResponse.Message = "Location updated";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // DELETE: api/Account/5
        public IHttpActionResult Delete(string id)
        {
            try
            {
                var accMng = new LocationManagement();

                var location = new Location
                {
                    IdLocation = id
                };

                accMng.Delete(location);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Location Deleted";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));

            }
        }
    }
}
