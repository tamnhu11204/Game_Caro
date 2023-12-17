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
        void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timerCountDown.Start();
            progressBar.Value = 0;
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
                socket.CreateServer();

                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        try
                        {
                            Listen();
                            break;
                        }
                        catch
                        {

                        }
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            else
            {
                Thread listenThread = new Thread(() =>
                {
                    Listen();
                });
                listenThread.IsBackground = true;
                listenThread.Start();

                socket.Send("Thông tin từ Client");
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
            string data = (string)socket.Receive();

            MessageBox.Show(data);
        }

        #endregion

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
