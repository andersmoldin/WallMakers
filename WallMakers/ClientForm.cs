using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pruttokoll;
using System.IO;
using Newtonsoft.Json;

namespace WallMakers
{
    public partial class ClientForm : Form
    {
        Client myClient;


        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCoupleUp_Click(object sender, EventArgs e)
        {
            myClient = new Client();
            Thread clientThread = new Thread(myClient.Start);
            clientThread.Start();
            //clientThread.Join();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            NetworkStream n = myClient.client.GetStream();

            Move message = new Move(Enums.direction.Left);

            string json = JsonConvert.SerializeObject(message);

            BinaryWriter w = new BinaryWriter(n);

            w.Write(json);
            w.Flush();
        }
    }
}
