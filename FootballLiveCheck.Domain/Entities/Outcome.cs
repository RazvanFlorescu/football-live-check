namespace FootballLiveCheck.Domain.Entities
{
    public class Outcome : DomainEntity
    {

        private Outcome()
        {
        }

        public string Winner { get; private set; }

        public string Type { get; private set; }

        public bool AfterExtraTime { get; private set; }

        public static Outcome Create(string winner, string type, bool afterExtraTime)
        {
            return new Outcome
            {
                Winner = winner,
                Type = type,
                AfterExtraTime = afterExtraTime
            };
        }
    }
}