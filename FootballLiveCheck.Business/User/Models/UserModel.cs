using FootballLiveCheck.Business.Team.Models;

namespace FootballLiveCheck.Business.User.Models
{
    public class UserModel : BaseModel
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Picture { get; set; }
    }
}