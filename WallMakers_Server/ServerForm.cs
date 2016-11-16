using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallMakers_Server
{
    public partial class ServerForm : Form
    {
        Thread serverThread;
        Server server;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            try
            {
                server.listener.Stop();
                //serverThread.Abort();
                //serverThread.Interrupt();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            server = new Server();
            serverThread = new Thread(server.Run);
            serverThread.Start();
            //serverThread.Join();
        }






        //onödigt skit nedanför denna rad
        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

    }
}
