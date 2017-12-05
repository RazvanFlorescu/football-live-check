using EnsureThat;
using FootballLiveCheck.Business.Team.Models;
using FootballLiveCheck.CqrsCore.Commands;

namespace FootballLiveCheck.Business.Team.Commands
{
    public class DeleteTeamCommand : ICommand
    {
        public DeleteTeamCommand(TeamModel teamModel)
        {
            EnsureArg.IsNotNull(teamModel);
            TeamModel = teamModel;
        }

        public TeamModel TeamModel { get;}
    }
}