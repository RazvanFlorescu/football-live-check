using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.League.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.League.CommandHandlers
{
    public class DeleteLeagueCommandHandler : DatabaseHandler, ICommandHandler<DeleteLeagueCommand>
    {
        private readonly ILeagueRepository leagueRepository;

        public DeleteLeagueCommandHandler(IMapper mapper, ILeagueRepository leagueRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(leagueRepository);
            this.leagueRepository = leagueRepository;
        }

        public void Handle(DeleteLeagueCommand command)
        {
            EnsureArg.IsNotNull(command);
            var commmandEntity = Mapper.Map<Domain.Entities.League>(command.LeagueModel);
            leagueRepository.Delete(commmandEntity);
            leagueRepository.SaveChanges();
        }
    }
}