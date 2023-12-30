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

        public static void ShowError()
        {
            System.Windows.Forms.MessageBox.Show(error);
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
    }
}
