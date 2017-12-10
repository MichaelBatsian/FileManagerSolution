using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.FileManager.DAL.Interfaces;
using Godeltech.FileManager.DAL.Repositories;
using Ninject.Modules;

namespace Godeltech.FileManager.BLL.Infrastructure.Ninject
{
    public class ServiceModule:NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IUnitOfWork)).To(typeof(UnitOfWorkEF)).InSingletonScope();
        }
    }
}
