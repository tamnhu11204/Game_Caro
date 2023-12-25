﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Diagnostics.Eventing.Reader;

namespace Game_Caro
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
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
        private bool CheckInput()
        {
            if (txb_Password.Text.Length == 0 || txb_Username.Text.Length == 0)
            {
                MessageBox.Show("Please provide all of the required information!");
                return false;
            }
            return true;
        }
        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                FirebaseResponse res=client.Get(@"Player/"+txb_Username.Text);
                tbPlayer ResUser=res.ResultAs<tbPlayer>();
                tbPlayer curUser = new tbPlayer() 
                { 
                    Username =txb_Username.Text,
                    Password =txb_Password.Text,
                };
                if(tbPlayer.IsEqual(ResUser,curUser))
                {
                    this.Hide();
                    Game_Caro game = new Game_Caro();
                    game.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }
    }
}
