
using System.Reflection;
using Autofac;
using FootballLiveCheck.DbSynchronizer.Mappers;
using FootballLiveCheck.DbSynchronizer.Synchronizers;
using FootballLiveCheck.Domain.Interfaces;
using Module = Autofac.Module;

namespace FootballLiveCheck.DbSynchronizer.Autofac
{
    public class DbSynchronizerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = Assembly.GetAssembly(typeof(TeamMapper));
            builder.RegisterGeneric(typeof(EntitySynchronizer<,>)).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(assembly).Where(t => t.Name.EndsWith("Mapper")).AsImplementedInterfaces();
        }
    }
}