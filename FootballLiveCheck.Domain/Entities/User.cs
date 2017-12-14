namespace FootballLiveCheck.Domain.Entities
{
    public class User : BaseEntity
    {
        private User()
        {
        }

        public string Username { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Picture { get; private set; }

        public static User CreateUser(string userName, string name, string email, string picture)
        {
            return new User
            {
                Username = userName,
                Name = name,
                Email = email,
                Picture = picture
            };
        }
    }
}