using Autofac;
using FootballLiveCheck.CqrsCore.DependencyInjection;
using FootballLiveCheck.CqrsCore.Dispatchers;
using FootballLiveCheck.Domain.Interfaces;
using FootballLiveCheck.Infrastructure.Dispatchers;
using FootballLiveCheck.Infrastructure.Hangfire;

namespace FootballLiveCheck.Infrastructure.DependencyInjection
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<QueryDispatcher>().As<IQueryDispatcher>();
            builder.RegisterType<CommandDispatcher>().As<ICommandDispatcher>();
            builder.RegisterType<EventDispatcher>().As<IEventDispatcher>();
            builder.RegisterType<AutofacDependencyScope>().As<IDependencyScope>();
            builder.RegisterType<HangfireHelper>().As<IJobsHelper>();
        }
    }
}