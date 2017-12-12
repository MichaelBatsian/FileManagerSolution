using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.FileManager.BLL.Interfaces;
using Godeltech.FileManager.BLL.ImplServices;
using Ninject.Modules;

namespace Godeltech.Applications.FileManagerCon.Services.Ninject
{
    internal class ServicesBindings:NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IUsersService)).To(typeof(UsersService)).InSingletonScope();
            Bind(typeof(ICatalogsService)).To(typeof(AuthService)).InSingletonScope();

        }
    }
}
