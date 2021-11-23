using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using SharedLibrary;

namespace Server
{
    class ServerMain
    {
        static IPAddress ipAd = IPAddress.Parse("192.168.0.101");
        static TcpListener tcpListener = new TcpListener(ipAd, 753);
        // Make sql server configuration here
        public static SQLManager sqlManager = new SQLManager("DESKTOP-D5T114U\\SQLEXPRESS", "Strajer Password Manager");
        // Loggging
        public static Logger logger = new Logger("log", true);
        static void Main(string[] args)
        {
            tcpListener.Start();
            logger.WriteLine("Server online");
            int numberOfClients = 10; /*int.Parse(Console.ReadLine());*/
            for (int i = 0; i < numberOfClients; i++)
            {
                Thread newThread = new Thread(new ThreadStart(Listeners));
                newThread.Start();
            }
        }
        static void Listeners()
        {

            Socket socketForClient = tcpListener.AcceptSocket();
            if (socketForClient.Connected)
            {
                logger.WriteLine("Client:" + socketForClient.RemoteEndPoint + " now connected to server.");
                NetworkStream networkStream = new NetworkStream(socketForClient);
                StreamWriter streamWriter = new StreamWriter(networkStream);
                StreamReader streamReader = new StreamReader(networkStream);

                ProcessRequest(ref socketForClient,ref networkStream, ref streamWriter, ref streamReader);
            }
            
            socketForClient.Close();
        }
        static void LoginFunction(string userName, string password, ref StreamWriter streamWriter)
        {
            if (sqlManager.Login(userName, password))
            {
                logger.WriteLine("User has logged succesfully");
                streamWriter.WriteLine(PacketHeader.LoginResponsePositive);
            }
            else
            {
                logger.WriteLine("User login failed");
                streamWriter.WriteLine(PacketHeader.LoginResponseNegative);
            }
            streamWriter.Flush();
        }
        static void ProcessRequest(ref Socket socketForClient, ref NetworkStream networkStream, 
            ref StreamWriter streamWriter, ref StreamReader streamReader)
        {
            try
            {
                // Here we recieve client's text if any.
                while (socketForClient.Connected)
                {
                    string recvMessageEncoded = streamReader.ReadLine();
                    Packet recvPacket = Packet.ReconstructPacket(recvMessageEncoded);
                    logger.WriteLine("Message recieved by client:" + recvPacket.GetUnifiedDecodedMessage());
                    switch (recvPacket.GetHeader())
                    {
                        case PacketHeader.LogoutRequest:
                            {
                                throw (new Exception("Client disconnected"));
                            }
                        case PacketHeader.LoginRequest:
                            {
                                string userName = recvPacket.GetDecodedMessage()[0];
                                string password = recvPacket.GetDecodedMessage()[1];
                                LoginFunction(userName, password, ref streamWriter);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Unrecognised command");
                                break;
                            }
                    }
                }
                streamReader.Close();
                networkStream.Close();
                streamWriter.Close();
            }
            catch (Exception exception)
            {
                logger.WriteLine("Client " + socketForClient.RemoteEndPoint.ToString() + " disconnected");
            }
        }
        
    }
}
