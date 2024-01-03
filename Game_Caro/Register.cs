using GameCaro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Game_Caro
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ZSYPCgwNgtDZLgNkwTsJyN6Z6tc6IKfG8gJNJL6S",
            BasePath = "https://game-caro-f1c0c-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
        }
        private  void btn_SignUp_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(txb_Username.Text) ||
                string.IsNullOrWhiteSpace(txb_Password.Text) ||
                string.IsNullOrWhiteSpace(txb_Fullname.Text) ||
                string.IsNullOrWhiteSpace(txb_Age.Text))
            {
                MessageBox.Show("Please provide all of the required information!");
                return;
            }
            #endregion
            int i = 0;
            FirebaseResponse res =  client.Get(@"Player " + txb_Username.Text);
            if (res.ResultAs<tbPlayer>() == null)
            {
                i = 0;
            }
            else i = 1;

            if (i==0)
            {
                tbPlayer user = new tbPlayer()
                {
                    Username = txb_Username.Text,
                    Password = txb_Password.Text,
                    Fullname = txb_Fullname.Text,
                    Age = int.Parse(txb_Age.Text),
                    Win = 0,
                    Lose = 0
                };
                SetResponse set = client.Set(@"Player " + txb_Username.Text, user);
                if (set.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show($"Successfully registered {txb_Username.Text}!", "Information!");
                }
            }
            else
            {
                tbPlayer.ShowError1();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn l = new LogIn();
            l.ShowDialog();
            this.Close();
        }

        private void btn_SignUp_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Exit_Click(sender, e);
        }
    }
}

