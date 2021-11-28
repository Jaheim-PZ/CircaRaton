using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonLibrary
{
     public static class PlayerHealth
    {
        public static string DisplayPlayerHealth()
        {
            int playerHp = 100;

            Random hit = new Random();

            int result = hit.Next(1, 20);

            int finalDam = playerHp - result;



            return ($"You have {result} of health remaining you with {finalDam} Hp");
        }
    }
}
