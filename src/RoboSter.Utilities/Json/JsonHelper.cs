using System.Globalization;
using Newtonsoft.Json;

namespace RoboSter.Utilities.Json
{
    public static class JsonHelper
    {
        public static readonly JsonSerializerSettings DefaultSerializerSettings =
            new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
                Culture = CultureInfo.InvariantCulture
            };

        public static T Deserialize<T>(this string str) => 
            JsonConvert.DeserializeObject<T>(str, DefaultSerializerSettings);

        public static string ToJson(this object obj) => 
            JsonConvert.SerializeObject(obj, DefaultSerializerSettings);
    }
}