using FootballLiveCheck.CqrsCore.Queries;

namespace FootballLiveCheck.CqrsCore.Dispatchers
{
    public interface IQueryDispatcher
    {
        TResult Retrive<TResult, TQuery>(TQuery query)
            where TResult : IQueryResult
            where TQuery : class, IQuery;
    }
}
