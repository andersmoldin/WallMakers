using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WallMakers_Server
{
    public class ClientHandler
    {
        public TcpClient tcpclient;
        private Server myServer;

        public string Username { get; set; }

        //public Player thisPlayer;

        public ClientHandler(TcpClient c, Server server)
        {
            tcpclient = c;
            this.myServer = server;
        }

        public void Run()
        {
            try
            {
                string message = "";
                while (!message.Equals("quit"))
                {
                    NetworkStream n = tcpclient.GetStream();
                    message = new BinaryReader(n).ReadString();
                    myServer.Broadcast(this, message);
                    Console.WriteLine(message);
                }

                myServer.DisconnectClient(this);
                tcpclient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string InitiateUsername()
        {
            string username = "";

            try
            {
                NetworkStream n = tcpclient.GetStream();
                BinaryWriter w = new BinaryWriter(n);
                w.Write("Ange användarnamn:");
                username = new BinaryReader(n).ReadString();

                //myServer.Broadcast(this, message);
                //Console.WriteLine(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return username;
        }
    }
}
