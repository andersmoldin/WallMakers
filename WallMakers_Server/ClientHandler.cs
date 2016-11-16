﻿using Newtonsoft.Json;
using Pruttokoll;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Player thisPlayer;

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

                while (true)
                {
                    NetworkStream n = tcpclient.GetStream();

                    message = new BinaryReader(n).ReadString();

                    Message msg = JsonConvert.DeserializeObject<Message>(message);

                    switch (msg.type)
                    {
                        case "Move":
                            Move myMove = JsonConvert.DeserializeObject<Move>(message);

                            RefreshGameBoard result = myServer.MoveLogic(thisPlayer, myMove);

                            string json = JsonConvert.SerializeObject(result);
                            myServer.Broadcast(this, json);

                            break;
                        case "SetUserName":
                            SetUserName username = JsonConvert.DeserializeObject<SetUserName>(message);

                            thisPlayer = new Player(5, 5, username.username);
                            myServer.players.Add(thisPlayer);

                            RefreshGameBoard currentGameBoard = new RefreshGameBoard(myServer.players);
                            string currentGameBoardJson = JsonConvert.SerializeObject(currentGameBoard);
                            myServer.Broadcast(this, currentGameBoardJson);
                            break;
                        default:
                            break;
                    }

                    Debug.WriteLine(message);
                }
                myServer.players.Remove(thisPlayer);
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
