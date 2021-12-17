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
    public class CuserService
    {
        public static CuserModel MyProfileInfo(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, CuserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CuserDataAccess();
            var data = mapper.Map<CuserModel>(da.MyProfileInfo(id));
            return data;
        }
        public static void Edit(CuserModel user)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CuserModel, User>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(user);
            DataAccessFactory.CuserDataAccess().Edit(data);

        }
        //public static void Delete(int id)
        //{
        //    DataAccessFactory.CuserDataAccess().Delete(id);
        //}

        public static List<CorderModel> MyOrder(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, CorderModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CorderDataAccess();
            var data = mapper.Map<List<CorderModel>>(da.MyOrderInfo(id));
            return data;
        }

        public static OrderWithOrderDetailsModel OrderDetails(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderWithOrderDetailsModel>();
                c.CreateMap<Order_Details, OrderDetailsModel>();
                c.CreateMap<Service, ServiceModel>();
                c.CreateMap<Employee, EmployeeModel>();
                c.CreateMap<User, CuserModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CorderDataAccess();
            var data = mapper.Map<OrderWithOrderDetailsModel>(da.MyOrderDetails(id));
            return data;
        }
    }
}
