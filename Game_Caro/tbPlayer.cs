using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    internal class tbPlayer
    {
        public tbPlayer (string user, string pass, string full)
        {
            Username = user;
            Password = pass;
            Fullname = full;
        }
        public string Username {  get; set; }
        public string Password { get; set; }
        public string Fullname {  get; set; }
        public int Age {  get; set; }
        public int Win {  get; set; }
        public int Lose { get; set; }
        public static bool IsEqual(tbPlayer resUser, tbPlayer curUser)
        {
            if(resUser == null||curUser==null)
                return false;
            if(resUser.Username!=curUser.Username) 
            {
                MessageBox.Show("Username does not exist!");
                return false; 
            }
            if (resUser.Username != curUser.Username&&resUser.Password != curUser.Password)
            {
                MessageBox.Show("Username and password does not match!");
                return false;
            }
            return true;
        }
    }
}
