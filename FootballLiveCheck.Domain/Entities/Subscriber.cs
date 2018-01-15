namespace FootballLiveCheck.Domain.Entities
{
    public class Subscriber : DomainEntity
    {
        public string PhoneNumber { get; set; }

        public int MatchId { get; set; }

        public virtual Match SubscribedMatch { get; set; }

        private Subscriber() { }

        public static Subscriber CreateSubscriber(string phoneNumber, Match match)
        {
            return new Subscriber{
                PhoneNumber = phoneNumber,
                SubscribedMatch = match
            };
        }
    }
}
