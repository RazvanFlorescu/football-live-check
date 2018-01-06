
using Autofac;
using FootballLiveCheck.DbSynchronizer.Synchronizers;
using FootballLiveCheck.Domain.Interfaces;

namespace FootballLiveCheck.DbSynchronizer.Autofac
{
    public class DbSynchronizerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(EntitySynchronizer<,>)).AsImplementedInterfaces();
        }
    }
}