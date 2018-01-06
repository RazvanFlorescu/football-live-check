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
    }
}