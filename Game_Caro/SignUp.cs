using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class SignUp : Form
    {
        PlayerBLL bllPlayer;
        public SignUp()
        {
            InitializeComponent();
            bllPlayer = new PlayerBLL();
        }
        public bool checkInput()
        {
            if(txb_Username1.Text.Length == 0)
            {
                MessageBox.Show("Ban chua nhap day du thong tin!", "Thong bao"
                   , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_Username1.Focus();
                return false;
            }
            if (txb_Password1.Text.Length == 0)
            {
                MessageBox.Show("Ban chua nhap day du thong tin!", "Thong bao"
                   , MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_Password1.Focus();
                return false;
            }
            return true;
        }
        private void btn_SignUp1_Click(object sender, EventArgs e)
        {
            if(checkInput())
            {
                tbPlayer p = new tbPlayer();
                p.Username = txb_Username1.Text;
                p.Password = txb_Password1.Text;
                p.Win = 0;
                p.Lose = 0;
                if(bllPlayer.InsertPlayer(p))
                {
                    MessageBox.Show("Sign up sucessfully!");
                }
                else
                {
                    MessageBox.Show("Error! Try again, please!");
                }
            }
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
            this.Close();
        }
    }
}
