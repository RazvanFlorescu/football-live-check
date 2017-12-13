using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.League.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.League.CommandsHandlers
{
    public class CreateLeagueCommandHandler : DatabaseHandler, ICommandHandler<CreateLeagueCommand>
    {
        private readonly ILeagueRepository leagueRepository;

        public CreateLeagueCommandHandler(IMapper mapper, ILeagueRepository leagueRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(leagueRepository);
            this.leagueRepository = leagueRepository;
        }

        public void Handle(CreateLeagueCommand command)
        {
            EnsureArg.IsNotNull(command);
            var commmandEntity = Mapper.Map<Domain.Entities.League>(command.LeagueModel);
            leagueRepository.Add(commmandEntity);
            leagueRepository.SaveChanges();
        }
    }
}