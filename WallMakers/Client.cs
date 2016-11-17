using Newtonsoft.Json;
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
using System.Windows.Forms;

namespace WallMakers
{
    public class Client
    {
        public TcpClient client;
        ClientForm form;

        public Client(ClientForm form)
        {
            this.form = form;
        }

        public void Start(object ip)
        {
            client = new TcpClient("192.168.25.160", 6666);
            //client = new TcpClient(ip.ToString(), 6666);

            Thread listenerThread = new Thread(Listen);
            listenerThread.Start();

            

            //listenerThread.Join();  //oklart
        }

        public void Listen()
        {
            string message = "";

            try
            {
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    //Console.WriteLine("Other: " + message);
                    RefreshGameBoard gameboard = JsonConvert.DeserializeObject<RefreshGameBoard>(message);

                    form.PrintGameBoard(gameboard.players);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        
    }
}
