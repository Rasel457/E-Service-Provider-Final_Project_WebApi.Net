using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class HomeService
    {
        public static List<ServiceModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Service, ServiceModel>();
                
            });
            var mapper = new Mapper(config);
            var d = DataAccessFactory.ServiceDataAccess();
            var data = mapper.Map<List<ServiceModel>>(d.GetAll());
            return data;
        }
         public static ServiceModel GetById(int id)
         {
             var config = new MapperConfiguration(c =>
             {
                 c.CreateMap<Service, ServiceModel>();
                 //c.CreateMap<Comment, CommentModel>();

             });
             var mapper = new Mapper(config);
             var da = DataAccessFactory.ServiceDataAccess();
             var data = mapper.Map<ServiceModel>(da.Get(id));
             return data;
        }

          public static ServiceWithCommentModel GetOneService(int id)
          {
              var config = new MapperConfiguration(c =>
              {
                  c.CreateMap<Service, ServiceWithCommentModel>();
                  c.CreateMap<Comment, CommentModel>();
                  c.CreateMap<User, CuserModel>();


              });
              var mapper = new Mapper(config);
              var da = DataAccessFactory.ServiceDataAccess();
              var data = mapper.Map<ServiceWithCommentModel>(da.Get(id));
              return data;
          }

         /* public static List<ServiceWithCommentModel> GetAllService()
          {
              var config = new MapperConfiguration(c =>
              {
                  c.CreateMap<Service, ServiceWithCommentModel>();
                  c.CreateMap<Comment, CommentModel>();

              });
              var mapper = new Mapper(config);
              var da = DataAccessFactory.ServiceDataAccess();
              var data = mapper.Map<List<ServiceWithCommentModel>>(da.GetAll());
              return data;
          }*/

        public static List<ServiceModel> GetBySearch(String catagory)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Service, ServiceModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ServiceDataAccess();
            var data = mapper.Map<List<ServiceModel>>(da.BySearch(catagory));
            return data;
        }

        public static void AddComment(CommentModel c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CommentModel, Comment>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Comment>(c);
            DataAccessFactory.CommentDataAccess().AddComment(data);
        }


    }
}
