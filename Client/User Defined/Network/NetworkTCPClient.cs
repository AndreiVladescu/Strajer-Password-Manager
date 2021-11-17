using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public class NetworkTCPClient
    {
        public NetworkStream networkStream;
        public TcpClient socketForServer;
        public StreamReader streamReader;
        public StreamWriter streamWriter;
        public NetworkTCPClient()
        {
            try
            {
                socketForServer = new TcpClient("192.168.0.101", 8001);
            }
            catch
            {
                Console.WriteLine(
                "Failed to connect to server at {0}:999", "192.168.0.101");
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
           
        }
    }
}
