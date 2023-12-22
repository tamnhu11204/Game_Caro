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
    internal class ConnectionFireBase
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ZSYPCgwNgtDZLgNkwTsJyN6Z6tc6IKfG8gJNJL6S",
            BasePath = "https://game-caro-f1c0c-default-rtdb.firebaseio.com/"
        };
        public async void Insert(tbPlayer pl)
        {
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            SetResponse response = await client.SetTaskAsync("InformationPlayer" + pl.Username, pl);
            tbPlayer result = response.ResultAs<tbPlayer>();
            MessageBox.Show("Data inserted " + result.Username);
        }
        
        
    }
}
