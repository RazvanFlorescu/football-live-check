using System.Collections.Generic;
using EnsureThat;
using FootballLiveCheck.Domain;
using Newtonsoft.Json;

namespace FootballLiveCheck.DbSynchronizer.Shared
{
    public class JSONDeserializer
    {

        public static T DeserializeAsSingleObject<T>(string json) where T : BaseJsonObject
        {
            EnsureArg.IsNotNull(json);
            return JsonConvert.DeserializeObject<T>(json);
        }
        public static ICollection<T> DeserializeAsList<T>(string json) where T : BaseJsonObject
        {
            EnsureArg.IsNotNull(json);
            return JsonConvert.DeserializeObject<ICollection<T>>(json);
        }
    }
}