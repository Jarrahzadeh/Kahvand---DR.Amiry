using System.Configuration;

namespace Ophthalmology.Utility.Helpers
{
    internal class ConfigurationHelper
    {
        internal static string GetValue(string key)
        {
            return !string.IsNullOrEmpty(key) ?
                ConfigurationManager.AppSettings[key] :
                string.Empty;
        }

        internal static string GetConnectionString(string name)
        {
            return !string.IsNullOrEmpty(name) ?
                ConfigurationManager.ConnectionStrings[name].ConnectionString :
                string.Empty;
        }
    }
}