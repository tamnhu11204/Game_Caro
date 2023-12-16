using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Image piece;

        public Image Piece
        {
            get { return piece; }
            set { piece = value; }
        }

        public Player(string name, Image piece)
        {
            this.Name = name;
            this.Piece = piece;
        }
    }
}
