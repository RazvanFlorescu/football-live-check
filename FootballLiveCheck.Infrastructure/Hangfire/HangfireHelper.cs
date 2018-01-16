using System;
using System.Linq.Expressions;
using FootballLiveCheck.Domain.Interfaces;
using Hangfire;
using Hangfire.SqlServer;

namespace FootballLiveCheck.Infrastructure.Hangfire
{
    public class HangfireHelper : IJobsHelper
    {

        public HangfireHelper()
        {
           
            JobStorage.Current = new SqlServerStorage("Data Source=(local);MultipleActiveResultSets=true;Initial Catalog=FootballLiveCheckDev;Integrated Security=True");
            
        }
        public void AddOrUpdateRecurringJob(string jobName, Expression<Action> jobAction, string cronExpression)
        {
            RecurringJob.AddOrUpdate(jobName, jobAction, cronExpression);
        }

        public void AddDailyRecurringJob(string jobName, Expression<Action> jobExpression)
        {
            RecurringJob.AddOrUpdate(jobName, jobExpression, Cron.Daily);
        }

        public void AddMinutelyRecurringJob(string jobName, Expression<Action> jobExpression)
        {
            RecurringJob.AddOrUpdate(jobName, jobExpression, Cron.Minutely);
        }
    }
}