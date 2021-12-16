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
    [EnableCors("*", "*", "*")]
    public class CustomerServiceController : ApiController
    {
        [Route("api/CustomerService/All")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, HomeService.GetAll());
        }
       
        [Route("api/CustomerService/GetById/{id}")]
        [HttpGet]
        public HttpResponseMessage GetById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, HomeService.GetById(id));
        }
        [Route("api/CustomerService/WithComment/{id}")]
        [HttpGet]
        public HttpResponseMessage ById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, HomeService.GetOneService(id));
        }

        //[Route("api/CustomerService/ShowComments")]
        //[HttpGet]
        //public List<ServiceWithCommentModel> getAllServe()
        //{
        //    return HomeService.GetAllService();
        //}


        [Route("api/CustomerService/Search")]
        [HttpPost]
        public HttpResponseMessage Search(ServiceModel s)
        {
            string catagory = s.type;
            return Request.CreateResponse(HttpStatusCode.OK, HomeService.GetBySearch(catagory));
        }

        [Route("api/CustomerService/Checkout")]
        [HttpPost]
        public HttpResponseMessage Checkout(ServiceModel s, CorderModel o)
        {
            string add = o.delevery_address;
            int id = 1;
            HomeService.Checkout(s, add, id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        //[Route("api/CustomerService/Checkout")]
        //[HttpPost]
        //public void Checkout(ServiceModel s, CorderModel o)
        //{
        //    string add = o.delevery_address;
        //    int id = 9;
        //    HomeService.Checkout(s, add, id);
        //}







    }
}
