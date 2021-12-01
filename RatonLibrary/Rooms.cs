using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RatonLibrary
{
    public class Rooms
    {
       public string roomName { get; set; }

        

        public int HP { get; set; }

        

        public Rooms(string roomname, int hp)
        {
            roomName = roomname;

           

            HP = hp;

            
        }
    }
}
