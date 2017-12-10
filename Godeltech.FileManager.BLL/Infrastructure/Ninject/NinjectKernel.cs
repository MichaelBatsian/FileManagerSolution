using Ninject;
using Ninject.Modules;

namespace Godeltech.FileManager.BLL.Infrastructure.Ninject
{
    public class NinjectKernel
    {
        private static IKernel _ninjectKernel;
        public static void InitializeKernel(NinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }
}
