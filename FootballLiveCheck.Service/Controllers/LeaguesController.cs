using FootballLiveCheck.Business.League.Commands;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.League.Queries;
using FootballLiveCheck.Business.League.QueryResults;
using FootballLiveCheck.CqrsCore.Dispatchers;
using FootballLiveCheck.Service.Common;
using Microsoft.AspNetCore.Mvc;


namespace FootballLiveCheck.Service.Controllers
{
    [Route("api/leagues")]
    public class LeaguesController : BaseController
    {
        public LeaguesController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(
            commandDispatcher, queryDispatcher)
        {
        }

        [HttpPost("")]
        public IActionResult CreateLeague([FromBody] LeagueModel teamModel)
        {
            var command = new CreateLeagueCommand(teamModel);
            CommandDispatcher.Handle(command);
            return Ok();
        }

        [HttpGet("")]
        public IActionResult GetAllLeagues()
        {
            var query = new GetAllLeaguesQuery();
            var result = QueryDispatcher.Retrive<GetAllLeaguesQueryResult, GetAllLeaguesQuery>(query);
            return Ok(result);
        }

        //[HttpGet("{leagueId}")]
        //public IActionResult GetLeagueById([FromRoute] Guid leagueId)
        //{
        //    var query = new GetLeagueByIdQuery(leagueId);
        //    var result = QueryDispatcher.Retrive<GetLeagueByIdQueryResult, GetLeagueByIdQuery>(query);

        //    if (result == null)
        //        return BadRequest();

        //    return Ok(result);
        //}

        //[HttpGet("byLeague/{leagueId}")]
        //public IActionResult GetLeaguesByLeagueId([FromRoute] Guid leagueId)
        //{
        //    var query = new GetLeaguesByLeagueIdQuery(leagueId);
        //    var result = QueryDispatcher.Retrive<GetLeaguesByLeagueIdQueryResult, GetLeaguesByLeagueIdQuery>(query);

        //    if (result == null)
        //        return BadRequest();

        //    return Ok(result);
        //}


        //[HttpDelete("")]
        //public IActionResult DeleteLeague([FromBody] LeagueModel leagueModel)
        //{
        //    var command = new DeleteLeagueCommand(leagueModel);
        //    CommandDispatcher.Handle(command);
        //    return Ok();
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateLeague([FromBody]LeagueModel leagueModel)
        //{
        //    var command = new UpdateLeagueCommand(leagueModel);
        //    CommandDispatcher.Handle(command);
        //    return Ok();
        //}



    }
}