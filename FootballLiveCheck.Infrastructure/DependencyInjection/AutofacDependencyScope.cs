using System;
using Autofac;
using FootballLiveCheck.CqrsCore.DependencyInjection;

namespace FootballLiveCheck.Infrastructure.DependencyInjection
{
    public class AutofacDependencyScope : IDependencyScope
    {
        private readonly ILifetimeScope scope;

        public AutofacDependencyScope(ILifetimeScope scope)
        {
            this.scope = scope;
        }

        public T Resolve<T>()
        {
            return scope.Resolve<T>();
        }

        public object Resolve(Type serviceType)
        {
            return scope.Resolve(serviceType);
        }
    }
}
