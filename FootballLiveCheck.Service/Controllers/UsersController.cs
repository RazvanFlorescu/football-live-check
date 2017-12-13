using System;
using FootballLiveCheck.Business.User.Commands;
using FootballLiveCheck.Business.User.Models;
using FootballLiveCheck.Business.User.Queries;
using FootballLiveCheck.Business.User.QueryResults;
using FootballLiveCheck.CqrsCore.Dispatchers;
using FootballLiveCheck.Service.Common;
using Microsoft.AspNetCore.Mvc;

namespace FootballLiveCheck.Service.Controllers
{
    [Route("api/users")]
    public class UsersController : BaseController
    {
        public UsersController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(
            commandDispatcher, queryDispatcher)
        {
        }

        [HttpPost("")]
        public IActionResult CreateUser([FromBody] UserModel userModel)
        {
            var command = new CreateUserCommand(userModel);
            CommandDispatcher.Handle(command);
            return Ok();
        }

        [HttpGet("")]
        public IActionResult GetAllUsers()
        {
            var query = new GetAllUsersQuery();
            var result = QueryDispatcher.Retrive<GetAllUsersQueryResult, GetAllUsersQuery>(query);
            return Ok(result);
        }

        [HttpGet("{UserId}")]
        public IActionResult GetUserById([FromRoute] Guid userId)
        {
            var query = new GetUserByIdQuery(userId);
            var result = QueryDispatcher.Retrive<GetUserByIdQueryResult, GetUserByIdQuery>(query);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }


        [HttpDelete("")]
        public IActionResult DeleteUser([FromBody] UserModel userModel)
        {
            var command = new DeleteUserCommand(userModel);
            CommandDispatcher.Handle(command);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromBody] UserModel userModel)
        {
            var command = new UpdateUserCommand(userModel);
            CommandDispatcher.Handle(command);
            return Ok();
        }
    }
}