using System.Net;

namespace FootballLiveCheck.DbSynchronizer.Shared
{
    public class URLToJSONConverter
    {
        public static string GetJSONString(string url)
        {
            using (var wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                return json;
            }
        }
    }
}