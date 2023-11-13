using System.Net;
using System.Net.Sockets;

namespace Ophthalmology.Utility.Helpers
{
    public class NetworkHelper
    {
        public static string GetHostName()
        {
            return Dns.GetHostName();
        }

        public static string GetIpAddress()
        {
            var hostName = GetHostName();
            var ipHostEntry = Dns.GetHostEntry(hostName);
            foreach (var ipAddress in ipHostEntry.AddressList)
            {
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ipAddress.ToString();
                }
            }

            return string.Empty;
        }
    }
}
