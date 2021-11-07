using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public interface IItems
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Value { get; set; }
    }
}
