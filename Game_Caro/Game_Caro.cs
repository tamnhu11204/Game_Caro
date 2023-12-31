﻿using GameCaro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Firebase.Database.Query;

namespace Game_Caro
{ 
    public partial class Game_Caro : Form
    {
       
        private int flag=0;
        Home home;
        #region Properties
        public string Username;
        ChessBoardManager ChessBoard;
        
        SocketManager socket;
        public static int exit = 0;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ZSYPCgwNgtDZLgNkwTsJyN6Z6tc6IKfG8gJNJL6S",
            BasePath = "https://game-caro-f1c0c-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        #endregion
        public Game_Caro(string username, Home home)
        {
            InitializeComponent();
            this.Username = username;
            home= new Home(username);
            this.home= home;
            Control.CheckForIllegalCrossThreadCalls = false;
            ChessBoard = new ChessBoardManager(pnl_ChessBoard, txtb_Player, picb_IconXO);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            progressBar.Step = Const.countDownStep;
            progressBar.Maximum = Const.countDownTime;
            progressBar.Value = 0;
            timerCountDown.Interval = Const.countDownInterval;

            socket = new SocketManager();
            NewGame();


        }

        #region Methods
        void EndGame()
        {
            timerCountDown.Stop();
            pnl_ChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
        }
        void ChessBoard_PlayerMarked(object sender,ButtonCLickEvent e)
        {
            timerCountDown.Start();
            pnl_ChessBoard.Enabled=false;
            progressBar.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.CLickedPoint));
            undoToolStripMenuItem.Enabled = false;

            Listen();
        }
        
        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }


        void NewGame()
        {
           
            progressBar.Value = 0;
            timerCountDown.Stop();
            undoToolStripMenuItem.Enabled = true;
            ChessBoard.DrawChessBoard();
        }

       

        void Undo()
        {
            ChessBoard.Undo();
            progressBar.Value = 0;
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();

            if (progressBar.Value >= progressBar.Maximum)
            {
                EndGame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
            }
        }

        private void playWithFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();

            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnl_ChessBoard.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
            socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            exit=1;
           
            DialogResult r = MessageBox.Show("Are you sure you want to quit this cute game?", "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {

                

                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                    this.Dispose();
                    home.Dispose();
                    Application.Exit();
                }
                catch
                { }
              
            }
        }

        private void Game_Caro_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (exit==0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to quit this cute game?", "Confirmation", MessageBoxButtons.OKCancel);
                if (dialog == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (flag==1)
                    {
                        try
                        {
                            socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                        }
                        catch
                        { }

                    }
                    else
                    {
                        this.Dispose();
                        home.Dispose() ;
                       
                    }
                }
               
            } 
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            flag=1;
            socket.IP = txbIP.Text;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                pnl_ChessBoard.Enabled = true;
                socket.CreateServer();

                
            }
            else
            {
                socket.isServer = false;
                pnl_ChessBoard.Enabled= false;
                Listen();
            }

        }

        private void Game_Caro_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {

            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch(Exception e)
                {
                    
                };
            });

            listenThread.IsBackground= true;
            listenThread.Start();
        }
    

        private void ProcessData(SocketData data)
        {
            switch(data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;

                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnl_ChessBoard.Enabled = false;
                    }));
                    break;

                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        progressBar.Value =0;
                        progressBar.Enabled = true;
                        timerCountDown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);

                        undoToolStripMenuItem.Enabled = true;
                    }));
                    break;

                case (int)SocketCommand.UNDO:
                    Undo();
                    progressBar.Value = 0; // reset processBar
                    break;

                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("5 in a row");
                    break;

                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Time's up");
                    break;
                case (int)SocketCommand.QUIT:
                    timerCountDown.Stop();
                    MessageBox.Show("Player is quit");
                    break;

                default:
                    break;
            }

            Listen();
        }


        #endregion

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Dispose();
           home.ShowDialog();
           Application.Exit();

        }

        private void playWithComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            home.Dispose();
            PlayVsComputer playVsComputer = new PlayVsComputer(Username, home);
            playVsComputer.ShowDialog();
            Application.Exit();
        }

        private void Game_Caro_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
        }
    }
}
