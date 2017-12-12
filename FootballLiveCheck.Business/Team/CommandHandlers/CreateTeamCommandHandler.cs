using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Team.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.Team.CommandHandlers
{
    public class CreateTeamCommandHandler: DatabaseHandler, ICommandHandler<CreateTeamCommand>
    {
        private readonly ITeamRepository teamRepository;
        public CreateTeamCommandHandler(IMapper mapper, ITeamRepository teamRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(teamRepository);
            this.teamRepository = teamRepository;
        }

        public void Handle(CreateTeamCommand command)
        {
            EnsureArg.IsNotNull(command);
            var commmandEntity = Mapper.Map<Domain.Entities.Team>(command.TeamModel);
            teamRepository.Add(commmandEntity);
            teamRepository.SaveChanges();
        }
    }
}
