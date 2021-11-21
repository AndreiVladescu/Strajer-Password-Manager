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
        public static Logger logger = new Logger("log");
        static void Main(string[] args)
        {

            tcpListener.Start();
            logger.WriteLine("Server online");
            int numberOfClientsYouNeedToConnect = 5; /*int.Parse(Console.ReadLine());*/
            for (int i = 0; i < numberOfClientsYouNeedToConnect; i++)
            {
                Thread newThread = new Thread(new ThreadStart(Listeners));
                newThread.Start();
            }
            logger.WriteLine("Server closed");
        }
        static void Listeners()
        {

            Socket socketForClient = tcpListener.AcceptSocket();
            if (socketForClient.Connected)
            {
                Console.WriteLine("Client:" + socketForClient.RemoteEndPoint + " now connected to server.");
                logger.WriteLine("Client:" + socketForClient.RemoteEndPoint + " now connected to server.");
                NetworkStream networkStream = new NetworkStream(socketForClient);
                StreamWriter streamWriter = new StreamWriter(networkStream);
                StreamReader streamReader = new StreamReader(networkStream);

                ////here we send message to client
                //Console.WriteLine("type your message to be recieved by client:");
                //string theString = Console.ReadLine();
                //streamWriter.WriteLine(theString);
                ////Console.WriteLine(theString);
                //streamWriter.Flush();


                try
                {
                    //here we recieve client's text if any.
                    while (socketForClient.Connected)
                    {
                        string theString = streamReader.ReadLine();
                        Console.WriteLine("Message recieved by client:" + theString);
                        logger.WriteLine("Message recieved by client:" + theString);
                        if (theString == "exit")
                            break;
                        else if (theString == "login")
                        {
                            string userName = streamReader.ReadLine();
                            string password = streamReader.ReadLine();
                            if (sqlManager.Login(userName, password))
                            {
                                Console.WriteLine("User has logged succesfully");
                                logger.WriteLine("User has logged succesfully");
                            }
                            else
                            {
                                Console.WriteLine("User login failed");
                                logger.WriteLine("User login failed");
                            }
                                
                        }

                    }
                    streamReader.Close();
                    networkStream.Close();
                    streamWriter.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Client " + socketForClient.RemoteEndPoint.ToString() + " disconnected");
                    logger.WriteLine("Client " + socketForClient.RemoteEndPoint.ToString() + " disconnected");
                }


            }
            socketForClient.Close();
        }
        
    }
}
