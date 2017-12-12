using Godeltech.FileManager.BLL.Interfaces;
using Godeltech.FileManager.DAL.Entities;
using Godeltech.FileManager.DAL.Interfaces;

namespace Godeltech.FileManager.BLL.ImplServices
{
    public class AuthService:IAuthentication
    {
        private readonly IUnitOfWork _rootRepository;

        public AuthService(IUnitOfWork unitOfWork)
        {
            _rootRepository = unitOfWork;
        }
        public bool IsUser(string login, string password)
        {
            var user =_rootRepository
                        .Users
                        .Get(new Users(){Login = login,Password = password});
            return user != null;
        }

    }
}
