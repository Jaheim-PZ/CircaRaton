using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public class Items
    {
        public Items(string name, double weight, int value)
        {
            Name = name;
            Weight = weight;
            Value = value;
        }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Value { get; set; }
    }
}
