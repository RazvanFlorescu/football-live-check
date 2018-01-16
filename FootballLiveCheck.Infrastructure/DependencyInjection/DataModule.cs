using Autofac;
using FootballLiveCheck.Data;
using System.Reflection;
using Module = Autofac.Module;
namespace FootballLiveCheck.Infrastructure.DependencyInjection
{
    public class DataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(DataLayer).GetTypeInfo().Assembly).Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();

        }
    }
}