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
        public ServerForm()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Server server = new Server();
            Thread serverThread = new Thread(server.Run);
            serverThread.Start();
            serverThread.Join();
        }
    }
}
