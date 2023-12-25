using GameCaro;
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

namespace Game_Caro
{
    public partial class Game_Caro : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;

        SocketManager socket;
        #endregion
        public Game_Caro()
        {
            InitializeComponent();

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
            //MessageBox.Show("End game!!!");
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

        void Quit()
        {
            DialogResult r = MessageBox.Show("Do you want to exit this cute game?", "Question?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
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
            Quit();
        }

        private void Game_Caro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to quit?", "Confirmation",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch
                {

                }

            }    
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
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
            this.Hide();
            
        }
    }
}
