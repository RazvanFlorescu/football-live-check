using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Team.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.Team.CommandHandlers
{
    public class DeleteTeamCommandHandler : DatabaseHandler, ICommandHandler<DeleteTeamCommand>
    {
        private readonly ITeamRepository teamRepository;
        public DeleteTeamCommandHandler(IMapper mapper, ITeamRepository teamRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(teamRepository);
            this.teamRepository = teamRepository;
        }

        public void Handle(DeleteTeamCommand command)
        {
            var commmandEntity = Mapper.Map<Domain.Entities.Team>(command.TeamModel);
            teamRepository.Delete(commmandEntity);
            teamRepository.SaveChanges();
        }
    }
}
