using FootballLiveCheck.Business.Subscriber.Commands;
using FootballLiveCheck.Business.Subscriber.Models;
using FootballLiveCheck.CqrsCore.Dispatchers;
using FootballLiveCheck.Service.Common;
using Microsoft.AspNetCore.Mvc;

namespace FootballLiveCheck.Service.Controllers
{
    [Route("api/subscribe")]
    public class SubscribersController: BaseController
    {
        public SubscribersController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(
            commandDispatcher, queryDispatcher)
        {
        }

        [HttpPost("")]
        public IActionResult CreateTeam([FromBody] SubscriptionModel subscriptionModel)
        {
            var command = new CreateSubscriptionCommand(subscriptionModel);
            CommandDispatcher.Handle(command);
            return Ok();
        }
    }
}
