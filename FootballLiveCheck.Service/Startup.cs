using System;
using AutoMapper;
using FootballLiveCheck.CqrsCore.DependencyInjection;
using FootballLiveCheck.DbSynchronizer.JSONObjects;
using FootballLiveCheck.DbSynchronizer.Synchronizers;
using FootballLiveCheck.Domain.Entities;
using FootballLiveCheck.Domain.Interfaces;
using FootballLiveCheck.Domain.Repositories;
using FootballLiveCheck.Infrastructure.Dispatchers;
using FootballLiveCheck.Infrastructure.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FootballLiveCheck.Service
{
    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("FootbalConnectionString");
            services.AddEfCore(connectionString);
            services.AddMvc();
            services.AddAutoMapper();
           
            return services.AddAutofac();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IDependencyScope scope)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
           
            app.SynchronizeDb(scope);
            app.UseMvc();
        }
    }
}