using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Caro
{
    internal class tbPlayer
    {
        public string Username {  get; set; }
        public string Password { get; set; }
        public string Fullname {  get; set; }
        public int Age {  get; set; }
        public int Win {  get; set; }
        public int Lose { get; set; }

        internal static bool IsEqual(tbPlayer resUser, tbPlayer curUser)
        {
            throw new NotImplementedException();
        }
    }
}
