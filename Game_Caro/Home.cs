using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class Home : Form
    {
        public string Username;
        public Home(string username)
        {
            InitializeComponent();
            Username = username;
        }
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ZSYPCgwNgtDZLgNkwTsJyN6Z6tc6IKfG8gJNJL6S",
            BasePath = "https://game-caro-f1c0c-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void LogIn_Load(object sender, EventArgs e)
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
        private async void ShowInfo()
        {
            FirebaseResponse res = await client.GetAsync(@"Player/".Where(x => x.["Username"]==Username));
            tbPlayer pl = res.ResultAs<tbPlayer>();
            txb_Username.Text = pl.Username;
            txb_Password.Text = pl.Password;
            txb_Age.Text=pl.Age.ToString();
            txb_Fullname.Text = pl.Fullname;
            txb_Win.Text = pl.Win.ToString();
            txb_Lose.Text = pl.Lose.ToString();
        }
        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_Caro g=new Game_Caro(Username);
            g.ShowDialog();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to log out?", "Question?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                LogIn g = new LogIn();
                g.ShowDialog();
                this.Close();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }
    }
}
