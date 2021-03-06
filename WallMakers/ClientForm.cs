﻿using System;
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
        const int xSize = 10;
        const int ySize = 10;
        Room[,] grid = new Room[xSize, ySize];
        List<Player> previousPrintOfPlayers = new List<Player>();

        public ClientForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = imageList1.Images.Keys;
        }
        public void PrintGameBoard(List<Player> players)
        {
            //for (int i = 0; i < xSize; i++)
            //{
            //    for (int j = 0; j < ySize; j++)
            //    {
            //        grid[i, j].Image = null;
            //    }
            //}
            foreach (var player in previousPrintOfPlayers)
            {
                grid[player.x, player.y].Image = null;
            }


            previousPrintOfPlayers = players.Select(p => new Player(p.x, p.y, p.imageIndex)).ToList();
            foreach (var player in players)
            {
                int x = player.y;
                int y = player.x;

                grid[x, y].Image = imageList1.Images[player.imageIndex];
            }

        }

        public void PrintGameBoard()
        {
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {

                    Room room = new Room();

                    grid[x, y] = room;
                    // Sätt koordinater 
                    room.Y = y;
                    room.X = x;

                    // Sätt ut knappen rätt i Forms 
                    room.Location = new System.Drawing.Point(65 * x, 72 * y);

                    // Ge den ett “unikt” namn 
                    room.Name = "room" + x + y;

                    // Storlek på knappen 
                    room.Size = new System.Drawing.Size(65, 72);
                    room.TabIndex = 0;
                    room.Text = "";//$"{ room.X} { room.Y}";
                    room.SizeMode = PictureBoxSizeMode.StretchImage;
                    //room.Load(@"C:\Users\Administrator\Downloads\Martin.png");
                    //room.UseVisualStyleBackColor = true;

                    // Sätt samma event för alla knappar 
                    //newBtn.Click += new System.EventHandler(this.GameButton_Click);

                    // Lägg till knappen I Forms 
                    this.Controls.Add(room);
                }
            }

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.Height = this.Controls[this.Controls.Count - 1].Bottom + 39;
            this.Width = this.Controls[this.Controls.Count - 1].Right + 16;

            //MessageBox.Show(this.Controls[this.Controls.Count - 1].Bottom.ToString());
        }



        private void btnCoupleUp_Click(object sender, EventArgs e)
        {
            PrintGameBoard();

            string IP = textBoxIPadress.Text;
            string username = textBox1.Text;

            var userImageIndex = comboBox1.SelectedIndex;

            myClient = new Client(this);
            Thread clientThread = new Thread(myClient.Start);
            clientThread.Start(IP);
            clientThread.Join();

            NetworkStream n = myClient.client.GetStream();

            SetUserName message = new SetUserName(username);
            SetUserImage msg = new SetUserImage(userImageIndex);

            string json = JsonConvert.SerializeObject(msg);

            BinaryWriter w = new BinaryWriter(n);

            w.Write(json);
            w.Flush();

            label1.Visible = false;
            label2.Visible = false;
            textBoxIPadress.Visible = false;
            textBox1.Visible = false;
            btnCoupleUp.Visible = false;
            comboBox1.Visible = false;

            btnUp.Visible = false;
            btnDown.Visible = false;
            btnLeft.Visible = false;
            btnRight.Visible = false;


        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            SendMovement(Enums.direction.Up);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            SendMovement(Enums.direction.Down);
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            SendMovement(Enums.direction.Left);
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            SendMovement(Enums.direction.Right);
        }

        private void SendMovement(Enums.direction direction)
        {
            NetworkStream n = myClient.client.GetStream();

            Move message = new Move(direction);

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

        private void ClientForm_KeyDown(object sender, KeyEventArgs e)
        {
            /*switch (e.KeyCode)
            {
                case Keys.Up:
                    MessageBox.Show("UP");
                    break;
                default:
                    break;
            }*/

        }

        protected override bool ProcessCmdKey (ref System.Windows.Forms.Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    SendMovement(Enums.direction.Left);
                    break;
                case Keys.Right:
                    SendMovement(Enums.direction.Right);
                    break;
                case Keys.Up:
                    SendMovement(Enums.direction.Up);
                    break;
                case Keys.Down:
                    SendMovement(Enums.direction.Down);
                    break;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myClient.client.Close();
        }
    }
}
