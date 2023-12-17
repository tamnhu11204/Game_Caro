using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
        public string AutoID()
        {
            return ("select concat ('P',right(concat('000000',isnull(right(max(ID),5),0)+1),5))\r\nfrom PLAYER where ID like 'P%'").ToString();
        }
        public bool InsertPlayer(tbPlayer player)
        {
            
            string sqlStr = @"insert into PLAYER values(@ID,@USERNAME,@PASSWORD,@WIN,@LOSE)";
            SqlConnection con=dc.getConnect();
            player.ID=AutoID();
            player.Win = 0;
            player.Lose = 0;
            try
            {
                cmd = new SqlCommand(sqlStr, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = player.ID;
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = player.Username;
                cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = player.Password;
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
    }
}
