using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public class Potion : Items
    {
        public Potion(string name, int hpRestored, int apRestored, double weight, int value) : base(name, weight, value)
        {
            HPRestored = hpRestored;
            APRestored = apRestored;
        }
        public int HPRestored { get; set; }
        public int APRestored { get; set; }
    }
}
