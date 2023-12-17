using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class LogIn : Form
    {
        PlayerBLL bllPlayer;
        public LogIn()
        {
            InitializeComponent();
            bllPlayer = new PlayerBLL();
        }

        private bool infoCheck()
        {
            if(txb_Username.Text.Length == 0 || txb_Password.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }    
            return true;
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string x=txb_Username.Text;
            string y=txb_Password.Text;
            if (bllPlayer.CheckPassword(x,y))
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
            
        }
    }
}
