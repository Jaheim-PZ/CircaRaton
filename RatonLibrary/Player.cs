using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public class Player : Character
    {
        public Player(int level, int hp, int ap) : base(hp,ap)
        {
            Level = level;
        }
        public int Level { get; set; }
    }

   
}
