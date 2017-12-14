using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.User.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.User.CommandHandlers
{
    public class CreateUserCommandHandler : DatabaseHandler, ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository userRepository;
        public CreateUserCommandHandler(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(userRepository);
            this.userRepository = userRepository;
        }

        public void Handle(CreateUserCommand command)
        {
            EnsureArg.IsNotNull(command);
            var commmandEntity = Mapper.Map<Domain.Entities.User>(command.UserModel);
            userRepository.Add(commmandEntity);
            userRepository.SaveChanges();
        }
    }
}