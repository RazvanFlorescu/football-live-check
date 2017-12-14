using EnsureThat;
using FootballLiveCheck.Business.User.Models;
using FootballLiveCheck.CqrsCore.Commands;

namespace FootballLiveCheck.Business.User.Commands
{
    public class UpdateUserCommand : ICommand
    {
        public UpdateUserCommand(UserModel userModel)
        {
            EnsureArg.IsNotNull(userModel);
            UserModel = userModel;
        }

        public UserModel UserModel { get; }
    }
}