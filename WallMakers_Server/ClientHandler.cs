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

                while (tcpclient.Connected)
                {
                    NetworkStream n = tcpclient.GetStream();
                    // Slipp Patrik
                    /*if ((IPAddress)tcpclient.Client.RemoteEndPoint() == "127.0.0.1")
                    {
                        tcpclient.Close();
                    }*/
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

                            thisPlayer = new Player(5, 5, 4/*username.username*/);
                            myServer.players.Add(thisPlayer);

                            RefreshGameBoard currentGameBoard = new RefreshGameBoard(myServer.players);
                            string currentGameBoardJson = JsonConvert.SerializeObject(currentGameBoard);
                            myServer.Broadcast(this, currentGameBoardJson);
                            break;
                        case "SetUserImage":
                            SetUserImage userImage = JsonConvert.DeserializeObject<SetUserImage>(message);


                            thisPlayer = new Player(5, 5, userImage.userImageIndex/*username.username*/);
                            myServer.players.Add(thisPlayer);

                            RefreshGameBoard refreshedGameBoard = new RefreshGameBoard(myServer.players);
                            string refreshedGameBoardJson = JsonConvert.SerializeObject(refreshedGameBoard);
                            myServer.Broadcast(this, refreshedGameBoardJson);
                            break;
                        default:
                            // ++ i failed attemps vid 5 failures addera ip till shitlist.
                            break;
                    }

                    Debug.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Här är vårt message: " + ex.Message);
            }
            finally
            {
                myServer.players.Remove(thisPlayer);
                myServer.clients.Remove(this);
                //myServer.DisconnectClient(this);
                tcpclient.Close();

                RefreshGameBoard refreshedGameBoard = new RefreshGameBoard(myServer.players);
                string refreshedGameBoardJson = JsonConvert.SerializeObject(refreshedGameBoard);
                myServer.Broadcast(this, refreshedGameBoardJson);
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
