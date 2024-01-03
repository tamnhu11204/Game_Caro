using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public class tbPlayer
    {
        public string Username {  get; set; }
        public string Password { get; set; }
        public string Fullname {  get; set; }
        public int Age {  get; set; }
        public int Win {  get; set; }
        public int Lose { get; set; }

        private static string error="Username does not exist!";
        private static string error1 = "Username existed! Please use another username.";
        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
        }
        public static void ShowError1()
        {
            System.Windows.Forms.MessageBox.Show(error1);
        }
        public static bool IsEqual(tbPlayer resUser, tbPlayer curUser)
        {
            if(resUser == null || curUser == null)
                return false;

            if(resUser.Username!=curUser.Username) 
            {
                error = "Username does not exist!";
                return false; 
            }

            else if (resUser.Password != curUser.Password)
            {
                error = "Username and password does not match!";
                return false;
            }
            return true;
        }
        public static bool CheckUsername(tbPlayer pl1,tbPlayer pl2)
        {
            if(pl1==null|| pl2==null)
                return false;
            if (pl1.Username == pl2.Username)
            {
                error1= "Username existed! Please use another username.";
                return false;
            }
            else
            {
                return true;
            }
            return true;
        }
    }
}
