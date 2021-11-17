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
using System.Text.RegularExpressions;

namespace RatonLibrary
{
    public static class StandardMesages
    {
        public static string DisplayRato()
        {
            return " |----------------------------------------------------------------------|\n" +
                   " |                  .--,       .--,                                     |\n" +
                   " |                 ( (  }.---.{  ) )                                    |\n" +
                   " |                 '.__} X   x {__.'                                    |\n" +
                   " |                     {=  ^  =}                                        |\n" +
                   " |                      >  u  <                                         |\n" +
                   " |       ___________.''`-------`''.______________                       |\n" +
                   " |       /  o                            O      }                       |\n" +
                   " |       {    __              _ o               /                       |\n" +
                   " |       /   /   o  __ _  _  |_) _ _|_ _ __. O  }                       |\n" +
                   " |       {   |__ |  | (_ (_| | |(_| |_(_)| |    /         __            |\n" +
                   " |       /                                      }     _.-'  `.          |\n" +
                   " |       {______________o__________o____________/ .-~^        `~--'     |\n" +
                   " |                     ___)( )(___        `-.___.'                      |\n" +
                   " |                    (((__) (__)))                                     |\n" +
                   " |----------------------------------------------------------------------|";
        }

        public static string UserName()
        {
            Console.Write(" | Enter Thy Name Rodent!... ");
            string userName = Console.ReadLine();
            Console.WriteLine(" |Brace Yourself " + userName + " and Welcome to Rodentia!              ");
            Console.WriteLine(" | Press enter to continue on your journey...!                          |");
            Console.ReadLine();
            return userName;
        }

        public static string PassWord()
        {
            Console.Write(" | Enter Secret Entrance Code... ");
            string passWord = Console.ReadLine();
            int length = passWord.Length;



            if (!passWord.Any(char.IsDigit))
            {
                return " |TEST for LEngth";      
            }
            else if (passWord.Length < 6)
            {
                return " |You need a longer password";
            }
            else if (!passWord.Any(char.IsNumber))
            {
                return "Need a number";
            }
            else if (!passWord.Any(char.IsSymbol))
            {
                return "Needs special character";
            }
            else if (!passWord.Any(char.IsLower))
            {
                return "Needs a lowercase";
            }
            else if (!passWord.Any(char.IsUpper))
            { 
                return "Needs an uppercase"; 
            }
            else
            { 
                return "Good Soup!"; 
            }
        }


        public static string DisplayMenuPrompt(string username)
        {
                    
            return  "|         ~~~~{ S:>  CIRCA*RATON  <:3 }~~~~             |\n" +
                    "|-------------------------------------------------------|\n" +
                    "|         _    1) Display Rooms     (`-()_.-=-.         |\n" +
                    "|       (( )_, 2) Display Weapons    /66  ,  ,  )       |\n" +
                    "|.--.    { '/  3) Display Potions  =(o_/=//_(   /====== |\n" +
                    "|    )   / }== 4) Display Treasures   ~x     ~x         |\n" +
                    "|   (   / _/   5) Display Items                         |\n" +
                    "|    `-|   )_  6) Display Mobs      (( )_ (             |\n" +
                    "|      `''''`  7) Move North        <^___)_)            |\n" +
                    "|              8) Move South          ''''    (( )_ (   |\n" +
                    "|              9) Move East                   <*___)_)  |\n" +
                    "|             10) Move West       _____         ''''    |\n" +
                    "|             11) Attack         /|o  |                 |\n" +
                    "              12) EXIT          /o|  o|                 |\n" +
                    "|------------------------------/o_|_o_|-----------------|\n" +
                   $"\r\nSelect an Option, " + username + ": ";
        }

        public static string DisplayRoom(int index)
        {
            return $"You are in {World.rooms[index]}";
        }

        public static string DisplayMenuError()
        {
            return "Not a valid option!";
        }
    }
}
