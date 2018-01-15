namespace FootballLiveCheck.Domain.Entities
{
    public class Arena : ApiEntity
    {
        public string Capacity { get; private set; }

        public string Name { get; private set; }

        public static Arena Create(int dbid, string name, string capacity)
        {
            return new Arena
            {
                DbId = dbid,
                Name = name,
                Capacity = capacity
            };
        }
    }
}