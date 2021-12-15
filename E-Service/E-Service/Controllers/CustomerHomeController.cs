using BEL;
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
    [EnableCors("*","*","*")]
    public class CustomerHomeController : ApiController
    {
        [Route("api/CustomerHome/AllServices")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, HomeService.GetAll());
        }
        [Route("api/CustomerHome/Profile")]
        [HttpGet]
        public HttpResponseMessage MyProfile()
        {
            int user_id = 2;
            return Request.CreateResponse(HttpStatusCode.OK, CuserService.MyProfileInfo(user_id));
        }

        [Route("api/CustomerHome/EditProfile/{id}")]
        [HttpGet]
        public HttpResponseMessage EditProfile(int id)
        {
            //int user_id = 2;
            return Request.CreateResponse(HttpStatusCode.OK, CuserService.MyProfileInfo(id));
        }
        [Route("api/CustomerHome/UpdateProfile")]
        [HttpPost]
        public HttpResponseMessage Edit(CuserModel user)
        {
            CuserService.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/CustomerHome/MyOrder")]
        [HttpGet]
        public HttpResponseMessage MyOrder()
        {
            int user_id = 5;
            return Request.CreateResponse(HttpStatusCode.OK, CuserService.MyOrder(user_id));
        }
        [Route("api/CustomerHome/Details/{id}")]
        [HttpGet]
        public HttpResponseMessage MyOrderDetails(int id)
        {

            return Request.CreateResponse(HttpStatusCode.OK, CuserService.OrderDetails(id));
        }
        [Route("api/CustomerHome/AddComment")]
        [HttpPost]
        public HttpResponseMessage AddComment(CommentModel com)
        {
            HomeService.AddComment(com);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
