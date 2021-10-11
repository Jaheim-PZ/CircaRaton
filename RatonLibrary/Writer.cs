using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RatonLibrary
{
    public static class Writer
    {
        public static string WriteMobs()
        {
            StreamWriter output;
            try
            {
                output = File.CreateText("mobs.csv");
               foreach(string mob in World.mobs)
                {
                    output.WriteLine($"{mob}");
                }
                output.Close();
                return "Testing";
            }
            catch(Exception ex)
            {
                string exceptionMessage = ex.Message;

                return exceptionMessage;

            }
        }
        public static string WriteRooms()
        {
            StreamWriter output;
            try
            {
                output = File.CreateText("rooms.csv");
                foreach (string room in World.rooms)
                {
                    output.WriteLine($"{room}");
                }
                output.Close();
                return "Testing";
            }
            catch (Exception ex)
            {
                string exceptionMessage = ex.Message;

                return exceptionMessage;

            }
        }
        public static string WriteWeapons()
        {
            StreamWriter output;
            try
            {
                output = File.CreateText("weapons.csv");
                foreach (string weapon in World.weapons)
                {
                    output.WriteLine($"{weapon}");
                }
                output.Close();
                return "Testing";
            }
            catch (Exception ex)
            {
                string exceptionMessage = ex.Message;

                return exceptionMessage;
            }
        }
        public static string WritePotions()
        {
            StreamWriter output;
            try
            {
                output = File.CreateText("potions.csv");
                foreach (string potion in World.potions)
                {
                    output.WriteLine($"{potion}");
                }
                output.Close();
                return "Testing";
            }
            catch (Exception ex)
            {
                string exceptionMessage = ex.Message;

                return exceptionMessage;
            }
        }
        public static string WriteTreasure()
        {
            StreamWriter output;
            try
            {
                output = File.CreateText("weapons.csv");
                foreach (string treasure in World.treasures)
                {
                    output.WriteLine($"{treasure}");
                }
                output.Close();
                return "Testing";
            }
            catch (Exception ex)
            {
                string exceptionMessage = ex.Message;

                return exceptionMessage;
            }
        }
        public static string WriteItems()
        {
            StreamWriter output;
            try
            {
                output = File.CreateText("items.csv");
                foreach (string item in World.items)
                {
                    output.WriteLine($"{item}");
                }
                output.Close();
                return "Testing";
            }
            catch (Exception ex)
            {
                string exceptionMessage = ex.Message;

                return exceptionMessage;
            }
        }
    }
}
