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

namespace RatonLibrary
{
    public static class World
    {
        public static bool exit = false;
        public static int index = 0;

        public static List<string> rooms = new List<string>() { "Hollow Fairy Trunk","Giant Gnome Garden", "Fire Creek Castle",
                                                                "Shawdow Sirened Swamps", "Mystic Melody Forest","Hallway/Path: Harmony Hallows",
                                                                "Hallway/Path: Squeaks Shakey Bridge", "Rusty Rogers Chili Can",
                                                                "Swiss Roll Burrows", "Marios MatchBox Bank", "Luigis Pizzaria Pizza Box",
                                                                "PopTart Plaza", "ToolBox Tavern", "Me Nifridge Melts",
                                                                "Hallway/Path: Outlet Oasis", "Wall Cavity Falls", "Gutter Express",
                                                                "Hallway/Path: Marios Casino Car Park", "Man Hole Hotel", "HoneySuckle Shrub Herbs" };

        /// <Movement>
        /// TODO: nodes? linked list? step thru rooms NESW...
        /// example start: public static LinkedList<string> rooms = new LinkedList<string>()
        /// </Movement>

        public static List<string> mobs = new List<string>() { "Fire Fox", "The Owl-Vengers", "Weasel Wicked", "Hellbent Hawk",
                                                               "King Kobra", "Kilik", "Leviathan", "Seraph", "BloodHound", 
                                                               "Kerberus", "Goliath", "Ether Drake", "Tiyana Vek", "Pekka", "FrossMoth" };
        
        public static List<string> weapons = new List<string>() { "Wretched Blade", "Pest Axe", "Stuarts Bow", "Whirly Twirly Saw", "Shield of Circa",
                                                                  "Tythen Arrows", "MaulHammer", "KreigsNein", "JawaBomb", "Vibro Sword", "FlameThrower", "Gas Bong" };

        public static List<string> potions = new List<string>() { "Healing", "Arcane" };

        public static List<string> treasures = new List<string>() { "Pebble", "Fire Paper", "Music Box" };

        public static List<string> items = new List<string>() { "Holy-Water", "Shaman Bone Dust", "Rabied Worm", "Skullhead Key" };
      
    }
    
}
