using FootballLiveCheck.Business.Team.Commands;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.Business.Team.Queries;
using FootballLiveCheck.Business.Team.QueryResults;
using FootballLiveCheck.CqrsCore.Dispatchers;
using FootballLiveCheck.Service.Common;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FootballLiveCheck.Service.Controllers
{
    [Route("api/teams")]
    public class TeamsController : BaseController
    {
        public TeamsController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(
            commandDispatcher, queryDispatcher)
        {
        }

        [HttpPost("")]
        public IActionResult CreateTeam([FromBody] TeamModel teamModel)
        {
            var command = new CreateTeamCommand(teamModel);
            CommandDispatcher.Handle(command);
            return Ok();
        }

        [HttpGet("")]
        public IActionResult GetAllTeams()
        {
            var query = new GetAllTeamsQuery();
            var result = QueryDispatcher.Retrive<GetAllTeamsQueryResult, GetAllTeamsQuery>(query);
            return Ok(result);
        }

        [HttpGet("/{teamId}")]
        public IActionResult GetTeamById([FromRoute] Guid teamId)
        {
            var query = new GetTeamByIdQuery(teamId);
            var result = QueryDispatcher.Retrive<GetAllTeamsQueryResult, GetTeamByIdQuery>(query);
            return Ok(result);
        }


    }
}