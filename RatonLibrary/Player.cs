using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading.Tasks;

namespace RatonLibrary
{
    public class Player : Character
    {
        public Player(int level, int hp, int ap) : base(hp,ap)
        {
            Level = level;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public int HitPoints { get; set; }
        public string CharacterClass { get; set; }
    }

   
}
