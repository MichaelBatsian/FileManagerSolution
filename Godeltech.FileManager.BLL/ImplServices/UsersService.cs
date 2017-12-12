using AutoMapper;
using Godeltech.FileManager.BLL.DTO;
using Godeltech.FileManager.BLL.Interfaces;
using Godeltech.FileManager.DAL.Entities;
using Godeltech.FileManager.DAL.Interfaces;

namespace Godeltech.FileManager.BLL.ImplServices
{
    public class UsersService:IUsersService
    {
        private readonly IUnitOfWork _database;

        public UsersService(IUnitOfWork database)
        {
            _database = database;
        }

        public UsersDTO GetUser(string login, string password)
        {
            var dbUser = _database.Users.Get(new Users()
            {
                Login = login,
                Password = password
            });
            Mapper.Initialize(cfg=>cfg.CreateMap<Users, UsersDTO>());
            return Mapper.Map<Users, UsersDTO>(dbUser);
        }
    }
}
