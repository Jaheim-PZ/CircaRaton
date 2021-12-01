/**
* 02021
* CSC 153
* Rebecca Garcia, Jaheim Patterson, Travis Bivins
* TextAdventure
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleUI
{
    public static class Movement
    {
        public static void MoveNorth(ref int index)
        {
            if (index < 4)
            {
                index++;
            }
        }

        public static void MoveSouth(ref int index)
        {
            if (index > 0)
            {
                index--;
            }
        }

        public static void MoveEast(ref int index)
        {
            if (index > 0)
            {
                index--;
            }
        }

        public static void MoveWest(ref int index)
        {
            if (index > 0)
            {
                index--;
            }
        }
    }
}
