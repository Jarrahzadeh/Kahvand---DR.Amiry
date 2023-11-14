using Newtonsoft.Json;

namespace Ophthalmology.Utility.Helpers
{
    public static class JsonHelper
    {
        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public static T DeSerialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
