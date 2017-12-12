using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.Applications.FileManagerCon.UI;
using Godeltech.FileManager.BLL.Interfaces;

namespace Godeltech.Applications.FileManagerCon.Presenters
{
    public class AuthPresenter
    {
        private readonly IAuthentication _authService;
        private readonly MainInterface _mainInterface;


        public AuthPresenter(IAuthentication authService, MainInterface mainInterface)
        {
            _authService = authService;
            _mainInterface = mainInterface;
        }

        public void AuthenticateUser(string login, string password)
        {
            if (_authService.IsUser(login, password))
            {
                
            }
            else
            {
                _mainInterface.Authentication(ViewsConsole.AccessDenided); 
            }
        }





    }
}
