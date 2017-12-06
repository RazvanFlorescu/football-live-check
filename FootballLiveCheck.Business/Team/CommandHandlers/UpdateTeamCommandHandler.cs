using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.Team.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.Team.CommandHandlers
{
    public class UpdateTeamCommandHandler : DatabaseHandler, ICommandHandler<UpdateTeamCommand>
    {
        private readonly ITeamRepository teamRepository;
        public UpdateTeamCommandHandler(IMapper mapper, ITeamRepository teamRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(teamRepository);
            this.teamRepository = teamRepository;
        }

        public void Handle(UpdateTeamCommand command)
        {
            var commmandEntity = Mapper.Map<Domain.Entities.Team>(command.TeamModel);
            teamRepository.Update(commmandEntity);
            teamRepository.SaveChanges();
        }
    }
}
