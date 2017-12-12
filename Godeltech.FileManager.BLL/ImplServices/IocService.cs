using Godeltech.FileManager.BLL.Infrastructure.Ninject;
using Godeltech.FileManager.DAL.Interfaces;

namespace Godeltech.FileManager.BLL.ImplServices
{
    public class IocService
    {
        protected IUnitOfWork UnitOfWork;
        protected IocService()
        {
            NinjectKernel.InitializeKernel(new ServiceModule());
            UnitOfWork = NinjectKernel.Resolve<IUnitOfWork>();
        }
    }
}
