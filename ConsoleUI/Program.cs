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
using RatonLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StandardMesages.DisplayRato());
            Console.WriteLine(StandardMesages.UserName());
            Console.WriteLine(StandardMesages.PassWord());

            while (World.exit == false)
            {                               
                Console.WriteLine(StandardMesages.DisplayRoom(World.index));
                Console.Write(StandardMesages.DisplayMenuPrompt());
                
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                    case "rooms":
                        Console.WriteLine(StandardHeaders.HeaderRooms());
                        ForEach.DisplayValues(World.rooms);
                        break;
                    case "2":
                    case "weapons":
                        Console.WriteLine(StandardHeaders.HeaderWeapons());
                        ForEach.DisplayValues(World.weapons);
                        break;
                    case "3":
                    case "potions":
                        Console.WriteLine(StandardHeaders.HeaderPotions());
                        ForEach.DisplayValues(World.potions);
                        break;
                    case "4":
                    case "treasures":
                        Console.WriteLine(StandardHeaders.HeaderTreasures());
                        ForEach.DisplayValues(World.treasures);
                        break;
                    case "5":
                    case "items":
                        Console.WriteLine(StandardHeaders.HeaderItems());
                        ForEach.DisplayValues(World.items);
                        break;
                    case "6":
                    case "mobs":
                        Console.WriteLine(StandardHeaders.HeaderMobs());
                        ForEach.DisplayValues(World.mobs);
                        break;
                    case "7":
                    case "north":
                        Console.WriteLine(StandardHeaders.HeaderNorth());
                        Movement.MoveNorth(ref World.index);
                        break;
                    case "8":
                    case "south":
                        Console.WriteLine(StandardHeaders.HeaderSouth());
                        Movement.MoveSouth(ref World.index);
                        break;
                    case "9":
                    case "attack":
                        Console.WriteLine(StandardHeaders.HeaderAttack());
                        Console.WriteLine(Attack.DisplayAttackResults());
                        break;
                    case "10":
                    case "exit":
                        World.exit = true;
                        break;

                    default:
                        Console.WriteLine(StandardMesages.DisplayMenuError());
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
