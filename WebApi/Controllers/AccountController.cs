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
    public class AccountController : ApiController
    {
        ApiResponse apiResponse = new ApiResponse();
        // GET: api/Account
        public IHttpActionResult Get()
        {
            try
            {
                var accMng = new AccountManagement();
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
        public IHttpActionResult Get(int id)
        {
            try
            {
                var accMng = new AccountManagement();

                var account = new Account
                {
                    AccountId = id
                };

                account = accMng.RetrieveById(account);

                apiResponse = new ApiResponse();

                apiResponse.Data = account;


                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // POST: api/Account
        public IHttpActionResult Post(Account account)
        {
            try
            {
                var accMng = new AccountManagement();

                accMng.Create(account);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Account Created";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {

                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // PUT: api/Account/5
        public IHttpActionResult Put(Account account)
        {
            try
            {
                var accMng = new AccountManagement();

                accMng.Update(account);

                apiResponse.Message = "Account updated";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));
            }
        }

        // DELETE: api/Account/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var accMng = new AccountManagement();

                var account = new Account
                {
                    AccountId = id
                };

                accMng.Update(account);

                apiResponse = new ApiResponse();

                apiResponse.Message = "Customer updated";

                return Ok(apiResponse);
            }
            catch (BusinessException bex)
            {
                return InternalServerError(new Exception(bex.ExceptionId + "--" + bex.AppMessage.Message));

            }
        }
    }
}
