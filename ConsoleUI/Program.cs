/**
* 02021
* CSC 153
* Rebecca Garcia, Jaheim Patterson, Travis Bivins
* TextAdventure
*/




using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RatonLibrary;

namespace ConsoleUI
{
    class Program
    {
        static string username;
        static void Main(string[] args)
        {
            //Console.WriteLine(Writer.WriteMobs(),Writer.WriteItems(),Writer.WritePotions(),Writer.WriteRooms(),Writer.WriteTreasure(),Writer.WriteWeapons());

            //Console.WriteLine(Reader.ReadMobs(),Reader.ReadItems(),Reader.ReadPotions(),Reader.ReadRooms(),Reader.ReadTreasure(),Reader.ReadWeapons());
            
            Console.WriteLine(StandardMesages.DisplayRato());
            Console.WriteLine(username = StandardMesages.UserName());
            StandardMesages.PassWord();
            StandardMesages.playerClass();
 
            while (World.exit == false)
            {
                Console.WriteLine(StandardMesages.DisplayRoom(World.index));
                Console.Write(StandardMesages.DisplayMenuPrompt(username));
             
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                    case "rooms":
                        Console.WriteLine(StandardHeaders.HeaderRooms());
                        foreach(string room in World.rooms)
                        {
                            Console.WriteLine(room);

                        }
                        break;
                    case "2":
                    case "weapons":
                        Console.WriteLine(StandardHeaders.HeaderWeapons());
                        foreach (string weapon in World.weapons)
                        {
                            Console.WriteLine(weapon);
                        }
                        break;
                    case "3":
                    case "potions":
                        Console.WriteLine(StandardHeaders.HeaderPotions());
                        foreach (string potion in World.potions)
                        {
                            Console.WriteLine(potion);
                        }
                        break;
                    case "4":
                    case "treasures":
                        Console.WriteLine(StandardHeaders.HeaderTreasures());
                        foreach (string treasure in World.treasures)
                        {
                            Console.WriteLine(treasure);
                        }
                        break;
                    case "5":
                    case "items":
                        Console.WriteLine(StandardHeaders.HeaderItems());
                        foreach (string item in World.items)
                        {
                            Console.WriteLine(item);

                        }
                        break;
                    case "6":
                    case "mobs":
                        Console.WriteLine(StandardHeaders.HeaderMobs());
                        foreach (string mob in World.mobs)
                        {
                            Console.WriteLine(mob);

                        }
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
                    case "east":
                        Console.WriteLine(StandardHeaders.HeaderEast());
                        Console.WriteLine("(10/20/2021) *TODO*: rooms East");
                        break;
                    case "10":
                    case "west":
                        Console.WriteLine(StandardHeaders.HeaderWest());
                        Console.WriteLine("(10/20/2021) *TODO*: rooms West");
                        break;
                    case "11":
                    case "attack":
                        Console.WriteLine(StandardHeaders.HeaderAttack());
                        Console.WriteLine(Attack.DisplayAttackResults());
                        break;
                    case "12":
                    case "exit":
                        World.exit = true;
                        break;

                    default:
                        Console.WriteLine(StandardMesages.DisplayMenuError());
                        break;
                }
                Console.WriteLine("");
                Application.Run(new demoForm());


            }
        }
    }
}
