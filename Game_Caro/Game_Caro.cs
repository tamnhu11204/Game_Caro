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
            MessageBox.Show("End game!!!");
        }
        void ChessBoard_PlayerMarked(object sender,ButtonCLickEvent e)
        {
            timerCountDown.Start();
            pnl_ChessBoard.Enabled=false;
            progressBar.Value = 0;
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT,"", e.CLickedPoint));
            Listen();
        }
        void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
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
        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();

            if (progressBar.Value >= progressBar.Maximum)
            {
                EndGame();
            }
        }

        private void playWithFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
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
                    break;

                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        progressBar.Value =0;
                        progressBar.Enabled = true;
                        timerCountDown.Start();
                        ChessBoard.OtherPlayerMark(data.Point);
                    }));
                    break;

                case (int)SocketCommand.UNDO:
                    break;

                case (int)SocketCommand.END_GAME:
                    break;

                case (int)SocketCommand.QUIT:
                    break;

                default:
                    break;
            }

            Listen();
        }
        #endregion
    }
}
