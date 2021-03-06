using System;
using System.IO;
using System.Net.Sockets;

namespace Client
{
    public class NetworkTCPClient
    {
        public NetworkStream networkStream;
        public TcpClient socketForServer;
        public StreamReader streamReader;
        public StreamWriter streamWriter;
        public void Configure(string serverIPAddress, int serverPort = 753)
        {
            try
            {
                socketForServer = new TcpClient(serverIPAddress, serverPort);
            }
            catch
            {
                Console.WriteLine(
                "Failed to connect to server at {0}:{1}", serverIPAddress, serverPort);
                return;
            }
            networkStream = socketForServer.GetStream();
            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);
        }
        public void CloseConnection()
        {
            networkStream.Close();
        }
        ~NetworkTCPClient()
        {
            CloseConnection();
        }
    }
}
