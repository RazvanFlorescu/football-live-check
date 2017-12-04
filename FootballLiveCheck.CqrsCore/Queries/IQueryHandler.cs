namespace FootballLiveCheck.CqrsCore.Queries
{
    public interface IQueryHandler<TQuery, TResult>
        where TQuery : IQuery
        where TResult : IQueryResult
    {
        TResult Retrieve(TQuery query);
    }
}
