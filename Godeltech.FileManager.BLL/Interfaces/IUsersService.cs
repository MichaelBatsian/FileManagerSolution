using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.FileManager.BLL.DTO;

namespace Godeltech.FileManager.BLL.Interfaces
{
    public interface IUsersService
    {
        UsersDTO GetUser(string login,string password);
    }
}
