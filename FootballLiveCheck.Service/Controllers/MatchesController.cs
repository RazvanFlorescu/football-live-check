using FootballLiveCheck.Business.League.Queries;
using FootballLiveCheck.Business.League.QueryResults;
using FootballLiveCheck.Business.Match.Queries;
using FootballLiveCheck.Business.Match.QueryResults;
using FootballLiveCheck.CqrsCore.Dispatchers;
using FootballLiveCheck.Service.Common;
using Microsoft.AspNetCore.Mvc;

namespace FootballLiveCheck.Service.Controllers
{
    [Route("api/matches")]
    public class MatchesController : BaseController
    {
        public MatchesController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(
            commandDispatcher, queryDispatcher)
        {
        }
        [HttpGet("live")]
        public IActionResult GetLiveMatches()
        {
            var query = new GetAllLiveMatchesQuery();
            var result = QueryDispatcher.Retrive<GetAllLiveMatchesQueryResult, GetAllLiveMatchesQuery>(query);
            return Ok(result);
        }

        [HttpGet("upcoming/{leagueId}")]
        public IActionResult GetUpcomingMatchesByLeagueId([FromRoute] int leagueId)
        {
            var query = new GetUpcomingMatchesByLeagueIdQuery(leagueId);
            var result = QueryDispatcher.Retrive<GetUpcomingMatchesByLeagueIdQueryResult, GetUpcomingMatchesByLeagueIdQuery>(query);
            return Ok(result);
        }

        [HttpGet("fulltime/{leagueId}")]
        public IActionResult GetFulltimeMatchesByLeagueId([FromRoute] int leagueId)
        {
            var query = new GetFulltimeMatchesByLeagueIdQuery(leagueId);
            var result = QueryDispatcher.Retrive<GetFulltimeMatchesByLeagueIdQueryResult, GetFulltimeMatchesByLeagueIdQuery>(query);
            return Ok(result);
        }

    }
}