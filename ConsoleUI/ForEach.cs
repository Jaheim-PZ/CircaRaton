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

namespace ConsoleUI
{
    public class ForEach
    {
        public static void DisplayValues(List<string> input)
        {
            foreach (string item in input)
            {
                Console.WriteLine(item);
            }
        }

        public int PasswordUpper(string str)
        {
            int upperCase = 0;

            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    upperCase++;
                }
            }

            return upperCase;
        }

        public int PasswordLower(string str)
        {
            int lowerCase = 0;

            foreach (char ch in str)
            {
                if (char.IsLower(ch))
                {
                    lowerCase++;
                }
            }

            return lowerCase;
        }


        //public int PasswordSpecial(string str)
        //{
        //    int specialCase = 0;

        //    foreach (char ch in str)
        //    {
        //        if (ch != "@" )
        //        {
        //            specialCase++;
        //        }
        //    }

        //    return specialCase;
        //}


    }
}
