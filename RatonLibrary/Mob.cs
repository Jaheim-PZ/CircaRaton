using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public class Mob: Character
    {
        public Mob(string mobname, string location, int hp, int ap) : base(hp, ap)
        {
            MobName = mobname;
            Location = location;
        }
        public string MobName { get; set; }
        public string Location { get; set; }

    }
}
