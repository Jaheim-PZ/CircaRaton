using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
    public class Weapon : Items
    {
        public Weapon(string name, string weaponType, string damageType, int attackPower,double weight, int value) : base(name, weight, value)
        {
            WeaponType = weaponType;
            DamageType = damageType;
            AttackPower = attackPower;
        }
        public string WeaponType { get; set; }
        public string DamageType { get; set; }
        public int AttackPower { get; set; }
    }
}
