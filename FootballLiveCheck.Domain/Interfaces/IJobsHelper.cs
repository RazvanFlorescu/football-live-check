using System;
using System.Linq.Expressions;

namespace FootballLiveCheck.Domain.Interfaces
{
    public interface IJobsHelper
    {
        void AddOrUpdateRecurringJob(string jobName, Expression<Action> jobExpression, string cronExpression);
        void AddDailyRecurringJob(string jobName, Expression<Action> jobExpression);
        void AddMinutelyRecurringJob(string jobName, Expression<Action> jobExpression);
    }
}