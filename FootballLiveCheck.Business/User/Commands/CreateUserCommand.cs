using EnsureThat;
using FootballLiveCheck.Business.User.Models;
using FootballLiveCheck.CqrsCore.Commands;

namespace FootballLiveCheck.Business.User.Commands
{
    public class CreateUserCommand : ICommand
    {
        public CreateUserCommand(UserModel userModel)
        {
            EnsureArg.IsNotNull(userModel);
            UserModel = userModel;
        }

        public UserModel UserModel { get; }
    }
}
// e ca si cum ai da un json null sau ceva