using EnsureThat;
using FootballLiveCheck.Business.League.Models;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.CqrsCore.Commands;

namespace FootballLiveCheck.Business.League.Commands
{
    public class CreateLeagueCommand : ICommand
    {
        public CreateLeagueCommand(LeagueModel leagueModel)
        {
            EnsureArg.IsNotNull(leagueModel);
            LeagueModel = leagueModel;
        }

        public LeagueModel LeagueModel { get; }
    }
}