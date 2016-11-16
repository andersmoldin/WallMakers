using Pruttokoll;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WallMakers_Server
{
    public class Server
    {
        List<ClientHandler> clients = new List<ClientHandler>();
        List<Player> players = new List<Player>();

        public TcpListener listener;

        public void Run()
        {
            listener = new TcpListener(IPAddress.Any, 6666);
            Debug.WriteLine("Hej");
            try
            {
                listener.Start();

                while (true)
                {
                    TcpClient c = listener.AcceptTcpClient();


                    ClientHandler newClient = new ClientHandler(c, this);
                    clients.Add(newClient);

                    Thread clientThread = new Thread(newClient.Run);
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                //if (listener != null)
                //    listener.Stop();
                Debug.WriteLine("Klart");
            }
        }

        public void Broadcast(ClientHandler client, string message)
        {
            foreach (ClientHandler tmpClient in clients)
            {
                if (tmpClient != client)
                {
                    NetworkStream n = tmpClient.tcpclient.GetStream();
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write(client.Username + ": " + message);
                    w.Flush();
                }
                else if (clients.Count() == 1)
                {
                    NetworkStream n = tmpClient.tcpclient.GetStream();
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write(client.Username + ": " + "Sorry, you are alone...");
                    w.Flush();
                }
            }
        }

        public void DisconnectClient(ClientHandler client)
        {
            clients.Remove(client);
            Console.WriteLine("Client X has left the building...");
            Broadcast(client, "Client X has left the building...");
        }
    }
}
