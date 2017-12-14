using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.User.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.User.CommandHandlers
{
    public class UpdateUserCommandHandler : DatabaseHandler, ICommandHandler<UpdateUserCommand>
    {
        private readonly IUserRepository userRepository;
        public UpdateUserCommandHandler(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(userRepository);
            this.userRepository = userRepository;
        }

        public void Handle(UpdateUserCommand command)
        {
            EnsureArg.IsNotNull(command);
            var commmandEntity = Mapper.Map<Domain.Entities.User>(command.UserModel);
            userRepository.Update(commmandEntity);
            userRepository.SaveChanges();
        }
    }
}