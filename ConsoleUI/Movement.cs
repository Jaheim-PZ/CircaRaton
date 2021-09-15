/**
* 02021
* CSC 153
* Rebecca Garcia, Jaheim Patterson
* TextAdventure
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
