using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public class MobInformation
    {
        public static string FireFox()
        {
            Mob FireFox = new Mob("Fire Fox", "Marios MatchBox Bank", 35, 25);
            return "Name:" + FireFox.MobName + "\nHP:" + FireFox.HP + "\nAP:" + FireFox.AP;
        }
        public static string OwlVengers()
        {
            Mob OwlVengers = new Mob("The Owl-Vengers", "Gutter Express", 250, 20);
            return "Name:" + OwlVengers.MobName + "\nHP:" + OwlVengers.HP + "\nAP:" + OwlVengers.AP;
        }
        public static string WeaselWicked()
        {
            Mob WeaselWicked = new Mob("Weasel Wicked", "Swill Roll Burrows", 75, 10);
            return "Name:" + WeaselWicked.MobName + "\nHP:" + WeaselWicked.HP + "\nAP:" + WeaselWicked.AP;
        }
        public static string HellbentHawk()
        {
            Mob HellbentHawk = new Mob("Hellbent Hawk", "Shadow Sirened Swamps", 50, 35);
            return "Name:" + HellbentHawk.MobName + "\nHP:" + HellbentHawk.HP + "\nAP:" + HellbentHawk.AP;
        }
        public static string KingKobra()
        {
            
            Mob KingKobra = new Mob("King Kobra", "Mystic Melody Forest", 20, 75);           
            return "Name:" + KingKobra.MobName + "\nHP:" + KingKobra.HP + "\nAP:" + KingKobra.AP;
        }
        public static string Kilik()
        {
            Mob Kilik = new Mob("Kilik", " Wall Cavity Falls", 100, 50);
            return "Name:" + Kilik.MobName + "\nHP:" + Kilik.HP + "\nAP:" + Kilik.AP;
        }
        public static string Leviathan()
        {
            Mob Leviathan = new Mob("Leviathan", "Me Nifridge Melts", 350, 10);
            return "Name:" + Leviathan.MobName + "\nHP:" + Leviathan.HP + "\nAP:" + Leviathan.AP;
        }
        public static string Seraph()
        {
            Mob Seraph = new Mob("Seraph", "Gutter Express", 70, 15);
            return "Name:" + Seraph.MobName + "\nHP:" + Seraph.HP + "\nAP:" + Seraph.AP;
        }
        public static string BloodHound()
        {
            Mob BloodHound = new Mob("Bloodhound", "Giant Gnome Garden", 50, 50);
            return "Name:" + BloodHound.MobName + "\nHP:" + BloodHound.HP + "\nAP:" + BloodHound.AP;
        }
        public static string Goliath()
        {
            Mob Goliath = new Mob("Goliath", "Fire Creek Castle", 400, 0);
            return "Name:" + Goliath.MobName + "\nHP:" + Goliath.HP + "\nAP:" + Goliath.AP;
        }
        public static string Kerberus()
        {
            Mob Kerberus = new Mob("Kerberus", "Man Mole Hotel", 125, 75);
            return "Name:" + Kerberus.MobName + "\nHP:" + Kerberus.HP + "\nAP:" + Kerberus.AP;
        }
        public static string EtherDrake()
        {
            Mob EtherDrake = new Mob("Ether Drake", "Fire Creek Castle", 250, 25);
            return "Name:" + EtherDrake.MobName + "\nHP:" + EtherDrake.HP + "\nAP:" + EtherDrake.AP;
        }
        public static string TiyanaVek()
        {
            Mob TiyanaVek = new Mob("Tiyana Vek", "HoneySuckle Shrub Herbs", 100, 60);
            return "Name:" + TiyanaVek.MobName + "\nHP:" + TiyanaVek.HP + "\nAP:" + TiyanaVek.AP;
        }
        public static string Pekka()
        {
            Mob Pekka = new Mob("Pekka", "Outlet Oasis", 70, 50);
            return "Name:" + Pekka.MobName + "\nHP:" + Pekka.HP + "\nAP:" + Pekka.AP;
        }
        public static string FrossMoth()
        {
            Mob FrossMoth = new Mob("Fross Moth", "PopTart Plaza", 95, 15);
            return "Name:" + FrossMoth.MobName + "\nHP:" + FrossMoth.HP + "\nAP:" + FrossMoth.AP;
        }
         
    }
}
