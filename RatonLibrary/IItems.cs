﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public interface IItems
    {
        string Name { get; set; }
        double Weight { get; set; }
        int Value { get; set; }
    }
}
