using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public class MobInformation
    {
        public static string MobInfo()
        {
            Mob FireFox = new Mob("Fire Fox", "Marios MatchBox Bank", 35, 25);
            Mob OwlVengers = new Mob("The Owl-Vengers", "Gutter Express", 250, 20);
            Mob WeaselWicked = new Mob("Weasel Wicked", "Swill Roll Burrows", 75, 10);
            Mob HellbentHawk = new Mob("Hellbent Hawk", "Shadow Sirened Swamps", 50, 35);
            Mob KingKobra = new Mob("King Kobra", "Mystic Melody Forest", 20, 75);
            Mob Kilik = new Mob("Kilik", " Wall Cavity Falls", 100, 50);
            Mob Leviathan = new Mob("Leviathan", "Me Nifridge Melts", 350, 10);
            Mob Seraph = new Mob("Seraph", "Gutter Express", 70, 15);
            Mob BloodHound = new Mob("Bloodhound", "Giant Gnome Garden", 50, 50);
            Mob Kerberus = new Mob("Kerberus", "Man Mole Hotel", 125, 75);
            Mob Goliath = new Mob("Goliath", "Fire Creek Castle", 400, 0);
            Mob EtherDrake = new Mob("Ether Drake", "Fire Creek Castle", 250, 25);
            Mob TiyanaVek = new Mob("Tiyana Vek", "HoneySuckle Shrub Herbs", 100, 60);
            Mob Pekka = new Mob("Pekka", "Outlet Oasis", 70, 50);
            Mob FrossMoth = new Mob("Fross Moth", "PopTart Plaza", 95, 15);
            List<Character> characters = new List<Character>();
            characters.Add(FireFox);
            characters.Add(OwlVengers);
            characters.Add(WeaselWicked);
            characters.Add(HellbentHawk);
            characters.Add(KingKobra);
            characters.Add(Kilik);
            characters.Add(Leviathan);
            characters.Add(Seraph);
            characters.Add(BloodHound);
            characters.Add(Kerberus);
            characters.Add(Goliath);
            characters.Add(EtherDrake);
            characters.Add(TiyanaVek);
            characters.Add(Pekka);
            characters.Add(FrossMoth);
            return "Name:" + FireFox.MobName + " HP:" + FireFox.HP + "\n Name:" + OwlVengers.MobName + " HP:" + OwlVengers.HP;
            
        }
    }
}
