using System;

namespace FootballLiveCheck.CqrsCore.DependencyInjection
{
    public interface IDependencyScope
    {
        T Resolve<T>();

        object Resolve(Type serviceType);
    }
}
