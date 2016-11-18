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
        string message = "";
        private List<string> myQueue = new List<string>();
        readonly static object myLock = new object();

        public Client(ClientForm form)
        {
            this.form = form;
        }

        public void Start(object ip)
        {
            //client = new TcpClient("192.168.25.160", 6666);
            client = new TcpClient(ip.ToString(), 6666);

            Thread listenerThread = new Thread(Listen);
            Thread consumerThread = new Thread(Consume);

            listenerThread.Start();
            consumerThread.Start();

            //listenerThread.Join();  //oklart
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    
                    bool isJson = true;
                    try
                    {
                        //är det ett giltigt json?
                        var jsonobject = JsonConvert.DeserializeObject(message);
                    }
                    catch (Exception)
                    {

                        isJson = false;
                    }
                    if (isJson)
                    {
                        lock (myQueue)
                        {
                            myQueue.Add(message);
                            Monitor.Pulse(myQueue);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void Consume()
        {
            while (true)
            {
                RefreshGameBoard gameboard = null;
                lock (myQueue)
                {
                    while (myQueue.Count == 0)
                    {
                        Monitor.Wait(myQueue);
                    }
                    if (myQueue.Count > 0)
                    {
                        try
                        {
                            gameboard = JsonConvert.DeserializeObject<RefreshGameBoard>(myQueue.First());
                            myQueue.RemoveAt(0);
                        }
                        catch (Exception)
                        {
                            myQueue.RemoveRange(0, myQueue.Count);
                        }
                    }
                }

                if (gameboard != null)
                {
                    form.PrintGameBoard(gameboard.players);
                }
            }
        }


    }
}
