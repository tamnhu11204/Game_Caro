using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Game_Caro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private List<Player> player;

        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }

        private int currentPlayer;

        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        private TextBox playerName;

        public TextBox PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private PictureBox playerPiece;

        public PictureBox PlayerPiece
        {
            get { return playerPiece; }
            set { playerPiece = value; }
        }
        private List<List<Button>> matrix;

        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        private Stack<PlayInfo> playTimeLine;
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox piece)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerPiece = piece;

            this.Player = new List<Player>()
            {
                new Player("Player1", Properties.Resources.IconX),
                new Player("Player2", Properties.Resources.IconO)
            };
            playTimeLine = new Stack<PlayInfo>();
            CurrentPlayer = 0;

            ChangePlayer();
        }
        #endregion

        #region Methods        
        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Const.chessBoardHeight; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Const.chessBoardWidth; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Const.chessWidth,
                        Height = Const.chessHeight,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += Btn_Click;
                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Const.chessHeight);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            Piece(btn);

            playTimeLine.Push(new PlayInfo(GetChessPoint(btn), currentPlayer));

            CurrentPlayer= CurrentPlayer ==1 ? 0 : 1;


            ChangePlayer();
            if (playerMarked != null)
                playerMarked(this, new EventArgs());
            if (isEndGame(btn))
            {
                EndGame();
            }
        }

        private void Piece(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Piece;


        }

        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            PlayerPiece.Image = Player[CurrentPlayer].Piece;
        }
        private void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        public bool Undo()
        {
            if (playTimeLine.Count<=0)
                return false;
            PlayInfo oldPoint = playTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];

            btn.BackgroundImage = null;




            if (playTimeLine.Count<=0)
            {

                currentPlayer = 0;
            }
            else
            {
                oldPoint= playTimeLine.Peek();
                currentPlayer=oldPoint.CurrentPlayer ==1 ? 0 : 1;
            }

            ChangePlayer();
            return true;
        }
        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Const.chessBoardWidth; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 5;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Const.chessBoardHeight; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Const.chessBoardWidth- point.X; i++)
            {
                if (point.Y + i >= Const.chessBoardHeight || point.X + i >= Const.chessBoardWidth)
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Const.chessBoardWidth|| point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Const.chessBoardWidth- point.X; i++)
            {
                if (point.Y + i >= Const.chessBoardHeight || point.X - i < 0)
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        #endregion

    }
}
