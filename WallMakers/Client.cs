using System;
using System.Collections.Generic;
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

        public void Start(object ip)
        {
            //client = new TcpClient("192.168.25.160", 6666);
            client = new TcpClient(ip.ToString(), 6666);

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
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}
