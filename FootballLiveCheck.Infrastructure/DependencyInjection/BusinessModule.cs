using Autofac;
using FootballLiveCheck.Business;
using Module = Autofac.Module;

namespace FootballLiveCheck.Infrastructure.DependencyInjection
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var businessLayer = typeof(BusinessLayer).Assembly;

            builder.RegisterAssemblyTypes(businessLayer).Where(t => t.Name.EndsWith("CommandHandler"))
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(businessLayer).Where(t => t.Name.EndsWith("QueryHandler"))
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(businessLayer).Where(t => t.Name.EndsWith("EventHandler"))
                .AsImplementedInterfaces();
        }
    }
}