using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using FootballLiveCheck.Data;
using FootballLiveCheck.DbSynchronizer.Autofac;
using FootballLiveCheck.Infrastructure.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FootballLiveCheck.Infrastructure.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceProvider AddAutofac(this IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new DataModule());
            builder.RegisterModule(new BusinessModule());
            builder.RegisterModule(new InfrastructureModule());
            builder.RegisterModule(new DbSynchronizerModule());

            builder.Populate(services);

            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }

        public static IServiceCollection AddEfCore(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}