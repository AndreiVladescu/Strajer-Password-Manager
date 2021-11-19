using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                string outputString;
                // read the data from the host and display it
                {
                    //outputString = ClientMain.client.streamReader.ReadLine();
                    //Console.WriteLine("Message Recieved by server:" + outputString);
                    //Console.WriteLine("Type your message to be recieved by server:");
                    Console.WriteLine("type:");
                    string str = textBox1.Text;
                    ClientMain.client.streamWriter.WriteLine(str);
                    ClientMain.client.streamWriter.Flush();
                    if (str == "exit")
                    {
                        ClientMain.client.CloseConnection();
                    }

                }
            }
            catch
            {
                Console.WriteLine("Exception reading from Server");
            }
        }
    }
}
