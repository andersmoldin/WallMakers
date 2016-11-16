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
        const int xSize = 15;
        const int ySize = 15;
        Room[,] grid = new Room[xSize, ySize];



        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    //grid[x, y]

                    Room room = new Room();

                    // Sätt koordinater 
                    room.Y = y;
                    room.X = x;

                    // Sätt ut knappen rätt i Forms 
                    room.Location = new System.Drawing.Point(12 * x, 12 * y);

                    // Ge den ett “unikt” namn 
                    room.Name = "label" + x + y;

                    // Storlek på knappen 
                    room.Size = new System.Drawing.Size(12, 12);
                    room.TabIndex = 0;
                    room.Text = "A";//$"{ room.X} { room.Y}";
                    //room.UseVisualStyleBackColor = true;

                    // Sätt samma event för alla knappar 
                    //newBtn.Click += new System.EventHandler(this.GameButton_Click);

                    // Lägg till knappen I Forms 
                    this.Controls.Add(room);
                }
            }

        }

        private string PrintGameboard()
        {
            string temp = "";

            return temp;
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

        private void textBoxIPadress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGameboard_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
