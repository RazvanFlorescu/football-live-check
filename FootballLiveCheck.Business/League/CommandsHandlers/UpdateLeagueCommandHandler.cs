using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.League.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.League.CommandHandlers
{
    public class UpdateLeagueCommandHandler : DatabaseHandler, ICommandHandler<UpdateLeagueCommand>
    {
        private readonly ILeagueRepository leagueRepository;

        public UpdateLeagueCommandHandler(IMapper mapper, ILeagueRepository leagueRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(leagueRepository);
            this.leagueRepository = leagueRepository;
        }

        public void Handle(UpdateLeagueCommand command)
        {
            EnsureArg.IsNotNull(command);
            var commmandEntity = Mapper.Map<Domain.Entities.League>(command.LeagueModel);
            leagueRepository.Update(commmandEntity);
            leagueRepository.SaveChanges();
        }
    }
}