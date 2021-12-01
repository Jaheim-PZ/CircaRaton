using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RatonLibrary
{
    public class Weapon : IItems
    {
        public Weapon(string weaponType, string damageType, int attackPower)
        {
            WeaponType = weaponType;
            DamageType = damageType;
            AttackPower = attackPower;
        }
        public string WeaponType { get; set; }
        public string DamageType { get; set; }
        public int AttackPower { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Value { get; set; }
    }
}
