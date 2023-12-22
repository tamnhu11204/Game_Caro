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
    public partial class SignUp : Form
    {
        ConnectionFireBase cf;
        public SignUp()
        {
            InitializeComponent();
            cf = new ConnectionFireBase();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            var data = new tbPlayer
            {
                Username = txb_Username.Text,
                Password = txb_Password.Text,
                Win = 0,
                Lose=0
            };
            cf.Insert(data);
        }
    }
}
