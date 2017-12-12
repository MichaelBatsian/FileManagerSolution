using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.Applications.FileManagerCon.Presenters;
using Godeltech.Applications.FileManagerCon.Services.Ninject;
using Godeltech.FileManager.BLL.Interfaces;

namespace Godeltech.Applications.FileManagerCon.UI
{
    public class MainInterface
    {
        private readonly AuthPresenter _authPresenter;
      

        public MainInterface()
        {
            NinjectKernel.InitializeKernel(new ServicesBindings());
            _authPresenter = new AuthPresenter(NinjectKernel.
                                Resolve<IAuthentication>(),this);
        }

        public void RunIterface(string [] args)
        {
            var exit = true;

            while (exit)
            {
                Console.Write("Enter plogin ");
                string login = Console.ReadLine();
                Console.WriteLine("Enter password ");
                string password = Console.ReadLine();
                _authPresenter.AuthenticateUser(login, password);
            }
        }

        public void Authentication(Action auth)
        {
            auth();
        }



    }
}
