using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.CqrsCore.Commands;

namespace FootballLiveCheck.Business.League.Commands
{
    public class UpdateLeagueCommand : ICommand
    {
        public UpdateLeagueCommand(LeagueModel leagueModel)
        {
            EnsureArg.IsNotNull(leagueModel);
            LeagueModel = leagueModel;
        }

        public LeagueModel LeagueModel { get; }
    }
}
