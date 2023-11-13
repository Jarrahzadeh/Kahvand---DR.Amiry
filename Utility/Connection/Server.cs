using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;

namespace Ophthalmology.Utility.Connection
{
    public class Server
    {
        private readonly TcpListener _listener;
        private readonly Dictionary<string, Client> _clients;

        public Server(int port)
        {
            _listener = new TcpListener(port);
            _clients = new Dictionary<string, Client>();
        }

        public void Start()
        {
            _listener.Start();
        }

        public void Stop()
        {
            _listener.Stop();
        }

        public string ReadData()
        {
            if (!_listener.Pending())
                return string.Empty;

            try
            {
                var acceptTcpClient = _listener.AcceptTcpClient();
                var client = new Client(acceptTcpClient);

                if (_clients.ContainsKey(client.IP))
                {
                    _clients[client.IP] = client;
                }
                else
                {
                    _clients.Add(client.IP, client);
                }

                var reader = new StreamReader(acceptTcpClient.GetStream());
                var data = string.Empty;
                while (reader.Peek() > -1)
                {
                    data += Convert.ToChar(reader.Read());
                }
                
                return data;
            }
            catch
            {
                return string.Empty;
            }
        }

        public void SendToClient(string ip, string msg)
        {
            _clients[ip].Send(msg);
        }
    }
}