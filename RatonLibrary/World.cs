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

namespace RatonLibrary
{
    public static class World
    {
        public static bool exit = false;
        public static int index = 0;

        public static List<string> rooms = new List<string>() { "Hollow Fairy Trunk", "Giant Gnome Garden", "Fire Creek Castle", "Shawdow Sirened Swamps", "Mystic Melody Forest" };
        public static List<string> weapons = new List<string>() { "Wretched Blade", "Pest Axe",
                                                                  "Stuarts Bow", "Whirly Twirly Saw" };
        public static List<string> potions = new List<string>() { "Healing", "Arcane" };
        public static List<string> treasures = new List<string>() { "Pebble", "Fire Paper", "Music Box" };
        public static List<string> items = new List<string>() { "Holy-Water", "Shaman Bone Dust", "Rabied Worm", "Skullhead Key" };
        public static List<string> mobs = new List<string>() { "Fire Fox", "The Owl-Vengers", "Weasel Wicked", "Hellbent Hawk", "King Kobra" };
    }
}
