using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Game_Caro
{
    public class PlayerDAL
    {
        DataConnection dc;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        public PlayerDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllPlayer()
        {
            string sqlStr = "select * from PLAYER";
            SqlConnection con=dc.getConnect();
            adapter = new SqlDataAdapter(sqlStr, con);
            con.Open();
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertPlayer(tbPlayer player)
        {
            
            string sqlStr = @"insert into PLAYER(USERNAME,PASSWORDS,WIN,LOSE) values (@USERNAME,@PASSWORDS,@WIN,@LOSE)";
            SqlConnection con=dc.getConnect();
            try
            {
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = player.Username;
                cmd.Parameters.Add("@PASSWORDS", SqlDbType.VarChar).Value = player.Password;
                cmd.Parameters.Add("@WIN", SqlDbType.Int).Value = player.Win;
                cmd.Parameters.Add("@LOSE", SqlDbType.VarChar).Value = player.Lose;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool CheckPassword(string x, string y)
        {
            string sqlStr = "select * from PLAYER where USERNAME=@USERNAME and PASSWORDS=@PASSWORD";
            SqlConnection con=dc.getConnect();
            cmd = new SqlCommand(sqlStr, con);
            con.Open();
            cmd.Parameters.AddWithValue("@USERNAME", x);
            cmd.Parameters.AddWithValue("@PASSWORDS", y);
            SqlDataReader dr = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
            con.Close();
            if (dr.HasRows)
            {
                return true;
            }
            else { return false; }
        }
    }
}
