using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro
{
    public class PlayerBLL
    {
        PlayerDAL dalPlayer;
        public PlayerBLL()
        {
            dalPlayer=new PlayerDAL();
        }
        public DataTable getAllPlayer()
        {
            return dalPlayer.getAllPlayer();
        }
        public bool InsertPlayer(tbPlayer p)
        {
            return dalPlayer.InsertPlayer(p);
        }
        public bool CheckPassword(string x,string y)
        {
            return dalPlayer.CheckPassword(x,y);
        }
    }
}
