using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public class Character
    {
        public Character(int hp, int ap)
        {
            HP = hp;
            AP = ap;
        }
        public int HP { get; set; }
        public int AP { get; set; }

    }
   
}
