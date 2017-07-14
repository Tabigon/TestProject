using System.Web.Http.Dependencies;
using Ninject;

namespace TestProject.Web.Infrastructure
{
    public class NinjectDependencyResolver : NinjectScope, IDependencyResolver
    {
        private IKernel _kernel;
        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            _kernel = kernel;
        }
        public IDependencyScope BeginScope()
        {
            return new NinjectScope(_kernel.BeginBlock());
        }
    }
}