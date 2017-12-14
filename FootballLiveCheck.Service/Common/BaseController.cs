using FootballLiveCheck.CqrsCore.Dispatchers;
using Microsoft.AspNetCore.Mvc;

namespace FootballLiveCheck.Service.Common
{
   // [Authorize]
    public class BaseController : Controller
    {
        protected IQueryDispatcher QueryDispatcher { get; }
        protected ICommandDispatcher CommandDispatcher { get; }

        public BaseController(IQueryDispatcher queryDispatcher)
        {
            QueryDispatcher = queryDispatcher;
        }

        public BaseController(ICommandDispatcher commandDispatcher)
        {
            CommandDispatcher = commandDispatcher;
        }

        public BaseController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {
            CommandDispatcher = commandDispatcher;
            QueryDispatcher = queryDispatcher;
        }
    }
}