using EnsureThat;
using FootballLiveCheck.Business.User.Models;
using FootballLiveCheck.CqrsCore.Commands;

namespace FootballLiveCheck.Business.User.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public DeleteUserCommand(UserModel userModel)
        {
            EnsureArg.IsNotNull(userModel);
            UserModel = userModel;
        }

        public UserModel UserModel { get;}
    }
}