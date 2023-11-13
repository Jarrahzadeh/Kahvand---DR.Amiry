using System;
using System.IO;
using System.Net.Sockets;

namespace Ophthalmology.Utility.Connection
{
    public class Client
    {
        private readonly TcpClient _tcpClient;

        public Client(TcpClient tcpClient)
        {
            _tcpClient = tcpClient;
        }

        public Client(string clientIp, int port) : this(new TcpClient(clientIp, port)) { }

        public string IP
        {
            get
            {
                var ip = _tcpClient.Client.RemoteEndPoint.ToString();
                var items = ip.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                return items[0];
            }
        }

        public void Send(string msg)
        {
            var writer = new StreamWriter(_tcpClient.GetStream());
            writer.Write(msg);
            writer.Flush();
        }
    }
}
