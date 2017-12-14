using AutoMapper;
using EnsureThat;
using FootballLiveCheck.Business.User.Commands;
using FootballLiveCheck.CqrsCore.Commands;
using FootballLiveCheck.Domain.Repositories;

namespace FootballLiveCheck.Business.User.CommandHandlers
{
    public class DeleteUserCommandHandler : DatabaseHandler, ICommandHandler<DeleteUserCommand>
    {
        private readonly IUserRepository userRepository;
        public DeleteUserCommandHandler(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            EnsureArg.IsNotNull(userRepository);
            this.userRepository = userRepository;
        }

        public void Handle(DeleteUserCommand command)
        {
            EnsureArg.IsNotNull(command);
            var commmandEntity = Mapper.Map<Domain.Entities.User>(command.UserModel);
            userRepository.Delete(commmandEntity);
            userRepository.SaveChanges();
        }
    }
}