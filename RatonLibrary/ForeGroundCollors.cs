using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    class ForeGroundCollors
    {
        static void Main(string[] args)
        {
            // Get the list of available colors
            // that can be changed
            ConsoleColor[] consoleColors
                = (ConsoleColor[])ConsoleColor
                      .GetValues(typeof(ConsoleColor));

            // Display the list
            // of available console colors
            Console.WriteLine("List of available "
                              + "Console Colors:");
            foreach (var color in consoleColors)
                Console.WriteLine(color);
        }
    }
}
