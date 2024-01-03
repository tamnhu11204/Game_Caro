using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace Game_Caro
{
    public partial class PlayVsComputer : Form
    {
        public string Username;
        private System.Windows.Forms.Button[,] Map;
        private static int columns, rows;

        private int player;
        private bool gameover;
        private bool vsComputer;
        private int[,] vtMap;
        private Stack<Chess> chesses;
        private Chess chess;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctbAvatar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLAN;

        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
        private System.Windows.Forms.Label label1;
        public PlayVsComputer(string username)
        {
            columns = 20;
            rows = 20;

            vsComputer = false;
            gameover = false;
            player = 1;
            Map = new System.Windows.Forms.Button[rows + 2, columns + 2];
            vtMap = new int[rows + 2, columns + 2];
            chesses = new Stack<Chess>();
            InitializeComponent();

            this.Username = username;

            BuildTable();
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ZSYPCgwNgtDZLgNkwTsJyN6Z6tc6IKfG8gJNJL6S",
            BasePath = "https://game-caro-f1c0c-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void BuildTable()
        {
            for (int i = 2; i <= rows; i++)
                for (int j = 1; j <= columns; j++)
                {
                    Map[i, j] = new System.Windows.Forms.Button();
                    Map[i, j].Parent = pnl_ChessBoard;
                    Map[i, j].Top = i * Contain.edgeChess;
                    Map[i, j].Left = j * Contain.edgeChess;
                    Map[i, j].Size = new System.Drawing.Size(Contain.edgeChess - 1, Contain.edgeChess - 1);
                    Map[i, j].BackColor = Color.Snow;

                    Map[i, j].MouseLeave += pnl_ChessBoard_MouseLeave;
                    Map[i, j].MouseEnter += pnl_ChessBoard_MouseEnter;
                    Map[i, j].Click += pnl_ChessBoard_Click;

                }
        }

        private void tmCooldown_Tick(object sender, EventArgs e)
        {
            progressBar.PerformStep();
            if (progressBar.Value >= progressBar.Maximum)
            {
                Gameover();
            }
        }

        private void menuUndo_Click(object sender, EventArgs e)
        {


            Chess template = new Chess();
            template = chesses.Pop();
            template.lb.Image = null;
            vtMap[template.X, template.Y] = 0;

            template = chesses.Pop();
            template.lb.Image = null;
            vtMap[template.X, template.Y] = 0;

            progressBar.Value = 0;
            player = 1;

        }

        private void menuQuit_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to quit this cute game?", "Question?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void Check_pices()
        {
            vsComputer = true;
            gameover = false;
            progressBar.Value = 0;
            timerCountDown.Stop();
            pnl_ChessBoard.Controls.Clear();

            picb_IconXO.Image = Properties.Resources.IconO;
            txtb_Player.Text = Username;
            txtb_Player.Text = this.Username;
            menu.Parent = pnl_ChessBoard;
            player = 1;
            Map = new System.Windows.Forms.Button[rows + 2, columns + 2];
            vtMap = new int[rows + 2, columns + 2];
            chesses = new Stack<Chess>();

            BuildTable();
        }
        private void PlayWithComputer(object sender, EventArgs e)
        {
            Check_pices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_pices();
        }

        private void Gameover()
        {
            timerCountDown.Stop();
            gameover = true;
            backgroundgameover();
        }

        private void backgroundgameover()
        {
            for (int i = 2; i <= rows; i++)
                for (int j = 1; j <= columns; j++)
                {
                    Map[i, j].BackColor = Color.Gray;
                }
        }

        private void ChangePlayer()
        {
            if (player == 1)
            {
                player = 2;
                txtb_Player.Text = "Player2";
                picb_IconXO.Image = Properties.Resources.IconX;

            }
            else
            {
                player = 1;
                txtb_Player.Text = "Player1";
                picb_IconXO.Image = Properties.Resources.IconO;
            }
        }
        async void UpdateWin(string uname)
        {
            try
            {
                FirebaseResponse res = await client.GetAsync(@"Player " + uname);
                tbPlayer pl = new tbPlayer();
                Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                pl.Password = data.ElementAt(3).Value;
                pl.Age = int.Parse(data.ElementAt(0).Value);
                pl.Fullname = data.ElementAt(1).Value;
                pl.Username = data.ElementAt(4).Value;
                pl.Win = int.Parse(data.ElementAt(5).Value) + 1;
                pl.Lose = int.Parse(data.ElementAt(2).Value);
                var update = await client.UpdateAsync(@"Player " + pl.Username, pl);
            }
            catch(Exception) 
            {
                MessageBox.Show("Error!");
            }
            
        }
        async void UpdateLose(string uname)
        {
            try
            {
                FirebaseResponse res = await client.GetAsync(@"Player " + uname);
                tbPlayer pl = new tbPlayer();
                Dictionary<string, string> data = JsonConvert.DeserializeObject<Dictionary<string, string>>(res.Body.ToString());
                pl.Password = data.ElementAt(3).Value;
                pl.Age = int.Parse(data.ElementAt(0).Value);
                pl.Fullname = data.ElementAt(1).Value;
                pl.Username = data.ElementAt(4).Value;
                pl.Win = int.Parse(data.ElementAt(5).Value);
                pl.Lose = int.Parse(data.ElementAt(2).Value) + 1;
                var update = await client.UpdateAsync(@"Player " + pl.Username, pl);
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }
        private void Check(int x, int y)
        {
            int i = x - 1, j = y;
            int column = 1, row = 1, mdiagonal = 1, ediagonal = 1;
            while (vtMap[x, y] == vtMap[i, j] && i >= 0)
            {
                column++;
                i--;
            }
            i = x + 1;
            while (vtMap[x, y] == vtMap[i, j] && i <= rows)
            {
                column++;
                i++;
            }
            i = x; j = y - 1;
            while (vtMap[x, y] == vtMap[i, j] && j >= 0)
            {
                row++;
                j--;
            }
            j = y + 1;
            while (vtMap[x, y] == vtMap[i, j] && j <= columns)
            {
                row++;
                j++;
            }
            i = x - 1; j = y - 1;
            while (vtMap[x, y] == vtMap[i, j] && i >= 0 && j >= 0)
            {
                mdiagonal++;
                i--;
                j--;
            }
            i = x + 1; j = y + 1;
            while (vtMap[x, y] == vtMap[i, j] && i <= rows && j <= columns)
            {
                mdiagonal++;
                i++;
                j++;
            }
            i = x - 1; j = y + 1;
            while (vtMap[x, y] == vtMap[i, j] && i >= 0 && j <= columns)
            {
                ediagonal++;
                i--;
                j++;
            }
            i = x + 1; j = y - 1;
            while (vtMap[x, y] == vtMap[i, j] && i <= rows && j >= 0)
            {
                ediagonal++;
                i++;
                j--;
            }

            if (row >= 5 || column >= 5 || mdiagonal >= 5 || ediagonal >= 5)
            {
                Gameover();
                if (player == 1)
                {
                    MessageBox.Show("You win!!");
                    UpdateWin(this.Username);

                }
                else
                {
                    MessageBox.Show("You lost!!");
                    UpdateLose(this.Username);
                }
            }

        }

        #region AI

        private int[] Attack = new int[7] { 0, 9, 54, 162, 1458, 13112, 118008 };
        private int[] Defense = new int[7] { 0, 3, 27, 99, 729, 6561, 59049 };

        public object ChessBoard { get; private set; }

        private void PutChess(int x, int y)
        {
            player = 0;
            progressBar.Value = 0;
            Map[x + 1, y].Image = Properties.Resources.x;


            vtMap[x, y] = 2;
            Check(x, y);

            chess = new Chess(Map[x + 1, y], x, y);
            chesses.Push(chess);
        }

        private void CptFindChess()
        {
            if (gameover) return;
            long max = 0;
            int imax = 1, jmax = 1;
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                    if (vtMap[i, j] == 0)
                    {
                        long temp = Caculate(i, j);
                        if (temp > max)
                        {
                            max = temp;
                            imax = i; jmax = j;
                        }
                    }
            }
            PutChess(imax, jmax);
        }
        private long Caculate(int x, int y)
        {
            return EnemyChesses(x, y) + ComputerChesses(x, y);
        }
        private long ComputerChesses(int x, int y)
        {
            int i = x - 1, j = y;
            int column = 0, row = 0, mdiagonal = 0, ediagonal = 0;
            int sc_ = 0, sc = 0, sr_ = 0, sr = 0, sm_ = 0, sm = 0, se_ = 0, se = 0;
            while (vtMap[i, j] == 2 && i >= 0)
            {
                column++;
                i--;
            }
            if (vtMap[i, j] == 0) sc_ = 1;
            i = x + 1;
            while (vtMap[i, j] == 2 && i <= rows)
            {
                column++;
                i++;
            }
            if (vtMap[i, j] == 0) sc = 1;
            i = x; j = y - 1;
            while (vtMap[i, j] == 2 && j >= 0)
            {
                row++;
                j--;
            }
            if (vtMap[i, j] == 0) sr_ = 1;
            j = y + 1;
            while (vtMap[i, j] == 2 && j <= columns)
            {
                row++;
                j++;
            }
            if (vtMap[i, j] == 0) sr = 1;
            i = x - 1; j = y - 1;
            while (vtMap[i, j] == 2 && i >= 0 && j >= 0)
            {
                mdiagonal++;
                i--;
                j--;
            }
            if (vtMap[i, j] == 0) sm_ = 1;
            i = x + 1; j = y + 1;
            while (vtMap[i, j] == 2 && i <= rows && j <= columns)
            {
                mdiagonal++;
                i++;
                j++;
            }
            if (vtMap[i, j] == 0) sm = 1;
            i = x - 1; j = y + 1;
            while (vtMap[i, j] == 2 && i >= 0 && j <= columns)
            {
                ediagonal++;
                i--;
                j++;
            }
            if (vtMap[i, j] == 0) se_ = 1;
            i = x + 1; j = y - 1;
            while (vtMap[i, j] == 2 && i <= rows && j >= 0)
            {
                ediagonal++;
                i++;
                j--;
            }
            if (vtMap[i, j] == 0) se = 1;

            if (column == 4) column = 5;
            if (row == 4) row = 5;
            if (mdiagonal == 4) mdiagonal = 5;
            if (ediagonal == 4) ediagonal = 5;

            if (column == 3 && sc == 1 && sc_ == 1) column = 4;
            if (row == 3 && sr == 1 && sr_ == 1) row = 4;
            if (mdiagonal == 3 && sm == 1 && sm_ == 1) mdiagonal = 4;
            if (ediagonal == 3 && se == 1 && se_ == 1) ediagonal = 4;

            if (column == 2 && row == 2 && sc == 1 && sc_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (column == 2 && mdiagonal == 2 && sc == 1 && sc_ == 1 && sm == 1 && sm_ == 1) column = 3;
            if (column == 2 && ediagonal == 2 && sc == 1 && sc_ == 1 && se == 1 && se_ == 1) column = 3;
            if (row == 2 && mdiagonal == 2 && sm == 1 && sm_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (row == 2 && ediagonal == 2 && se == 1 && se_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (ediagonal == 2 && mdiagonal == 2 && sm == 1 && sm_ == 1 && se == 1 && se_ == 1) column = 3;

            long Sum = Attack[row] + Attack[column] + Attack[mdiagonal] + Attack[ediagonal];

            return Sum;
        }



        private void pnl_ChessBoard_MouseLeave(object sender, EventArgs e)
        {
            if (gameover)
                return;

        }

        private void pnl_ChessBoard_Click(object sender, EventArgs e)
        {
            if (gameover)
                return;
            System.Windows.Forms.Button lb = (System.Windows.Forms.Button)sender;
            int x = lb.Top / Contain.edgeChess - 1, y = lb.Left / Contain.edgeChess;

            if (vsComputer)
            {
                player = 1;
                progressBar.Value = 0;
                timerCountDown.Start();
                lb.Image = Properties.Resources.o;

                vtMap[x, y] = 1;
                Check(x, y);
                CptFindChess();
            }
            chess = new Chess(lb, x, y);
            chesses.Push(chess);

        }

        private void pnl_ChessBoard_MouseEnter(object sender, EventArgs e)
        {
            if (gameover)
                return;
        }

        private long EnemyChesses(int x, int y)
        {
            int i = x - 1, j = y;
            int sc_ = 0, sc = 0, sr_ = 0, sr = 0, sm_ = 0, sm = 0, se_ = 0, se = 0;
            int column = 0, row = 0, mdiagonal = 0, ediagonal = 0;
            while (vtMap[i, j] == 1 && i >= 0)
            {
                column++;
                i--;
            }
            if (vtMap[i, j] == 0) sc_ = 1;
            i = x + 1;
            while (vtMap[i, j] == 1 && i <= rows)
            {
                column++;
                i++;
            }
            if (vtMap[i, j] == 0) sc = 1;
            i = x; j = y - 1;
            while (vtMap[i, j] == 1 && j >= 0)
            {
                row++;
                j--;
            }
            if (vtMap[i, j] == 0) sr_ = 1;
            j = y + 1;
            while (vtMap[i, j] == 1 && j <= columns)
            {
                row++;
                j++;
            }
            if (vtMap[i, j] == 0) sr = 1;
            i = x - 1; j = y - 1;
            while (vtMap[i, j] == 1 && i >= 0 && j >= 0)
            {
                mdiagonal++;
                i--;
                j--;
            }
            if (vtMap[i, j] == 0) sm_ = 1;
            i = x + 1; j = y + 1;
            while (vtMap[i, j] == 1 && i <= rows && j <= columns)
            {
                mdiagonal++;
                i++;
                j++;
            }
            if (vtMap[i, j] == 0) sm = 1;
            i = x - 1; j = y + 1;
            while (vtMap[i, j] == 1 && i >= 0 && j <= columns)
            {
                ediagonal++;
                i--;
                j++;
            }
            if (vtMap[i, j] == 0) se_ = 1;
            i = x + 1; j = y - 1;
            while (vtMap[i, j] == 1 && i <= rows && j >= 0)
            {
                ediagonal++;
                i++;
                j--;
            }
            if (vtMap[i, j] == 0) se = 1;

            if (column == 4) column = 5;
            if (row == 4) row = 5;
            if (mdiagonal == 4) mdiagonal = 5;
            if (ediagonal == 4) ediagonal = 5;

            if (column == 3 && sc == 1 && sc_ == 1) column = 4;
            if (row == 3 && sr == 1 && sr_ == 1) row = 4;
            if (mdiagonal == 3 && sm == 1 && sm_ == 1) mdiagonal = 4;
            if (ediagonal == 3 && se == 1 && se_ == 1) ediagonal = 4;

            if (column == 2 && row == 2 && sc == 1 && sc_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (column == 2 && mdiagonal == 2 && sc == 1 && sc_ == 1 && sm == 1 && sm_ == 1) column = 3;
            if (column == 2 && ediagonal == 2 && sc == 1 && sc_ == 1 && se == 1 && se_ == 1) column = 3;
            if (row == 2 && mdiagonal == 2 && sm == 1 && sm_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (row == 2 && ediagonal == 2 && se == 1 && se_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (ediagonal == 2 && mdiagonal == 2 && sm == 1 && sm_ == 1 && se == 1 && se_ == 1) column = 3;
            long Sum = Defense[row] + Defense[column] + Defense[mdiagonal] + Defense[ediagonal];
            return Sum;
        }


        void NewGame()
        {
            progressBar.Value = 0;
            timerCountDown.Stop();
            undoToolStripMenuItem.Enabled = true;
            BuildTable();
        }

      

        private void PlayVsComputer_Load(object sender, EventArgs e)
        {
            try                 
            {
                client = new FireSharp.FirebaseClient(config);
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
            Check_pices();
        }
        #endregion

        private void playWithFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_Caro game_Caro = new Game_Caro(Username);
            game_Caro.ShowDialog();
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home(Username);
            h.ShowDialog();
            this.Close();
        }

        public class Chess
        {
            public System.Windows.Forms.Button lb;
            public int X;
            public int Y;
            public Chess()
            {
                lb = new System.Windows.Forms.Button ();
            }
            public Chess(System.Windows.Forms.Button _lb, int x, int y)
            {
                lb = new System.Windows.Forms.Button();
                lb = _lb;
                X = x;
                Y = y;
            }
        }

    }
}

