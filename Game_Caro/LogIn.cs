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
        public LogIn()
        {
            InitializeComponent();
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
            this.Hide();
            Game_Caro game_Caro = new Game_Caro();
            game_Caro.ShowDialog();
            this.Close();
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
