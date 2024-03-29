﻿using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace E_Service.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(CuserModel user)
        {
            //call to service
            
            var token = AuthService.Authenticate(user);
            if (token != null)
            {

                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Invalid Email Or Password");
        }

        [Route("api/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                var rs = AuthService.Logout(token);
                if (rs)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Sucessfully logged out");
                }

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid token to logout");
        }
    }
}
