using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RatonLibrary
{
    public class Potion : IItems
    {
        public Potion(int hpRestored, int apRestored)
        {
            HPRestored = hpRestored;
            APRestored = apRestored;
        }
        public int HPRestored { get; set; }
        public int APRestored { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Value { get; set; }
    }
}
