using System;

namespace FootballLiveCheck.Domain
{
    public class DomainHelper
    {
        public static DateTime UnixTimeStampToDateTime(string unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            var secondsDouble = Convert.ToDouble(unixTimeStamp);
            var secondsLong = Convert.ToInt64(secondsDouble);
            return DateTimeOffset.FromUnixTimeMilliseconds(secondsLong).DateTime;
        }
    }
}