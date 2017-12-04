using FootballLiveCheck.CqrsCore.DependencyInjection;
using FootballLiveCheck.CqrsCore.Dispatchers;
using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.Infrastructure.Dispatchers
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IDependencyScope scope;

        public QueryDispatcher(IDependencyScope scope)
        {
            this.scope = scope;
        }

        public TResult Retrive<TResult, TQuery>(TQuery query)
            where TResult : IQueryResult
            where TQuery : class, IQuery
        {
            var queryHandler = scope.Resolve<IQueryHandler<TQuery, TResult>>();
            var result = queryHandler.Retrieve(query);
            return result;
        }
    }
}
