using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AuthService
    {
        public static TokenModel Authenticate(CuserModel user)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, CuserModel>();
                c.CreateMap<CuserModel,User>();
                c.CreateMap<Token, TokenModel>();
                c.CreateMap<TokenModel, Token>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(user);
            var result = DataAccessFactory.AuthDataAccess().Authenticate(data);
            var token = mapper.Map<TokenModel>(result);
            return token;
            

        }
        public static bool IsAuthenticated(string token)
        {
            var rs = DataAccessFactory.AuthDataAccess().IsAuthenticated(token);
            return rs;
        }
    }
}
