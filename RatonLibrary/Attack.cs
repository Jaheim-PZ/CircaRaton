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
    public static class Attack
    {
        public static string DisplayAttackResults()
         {
             int playerHp = 100;
             Random hit = new Random();

             int result = hit.Next(1, 20);

            return ($"You took {result} of damage leaving you with {playerHp - result} Hp");
            
         }
    }
}
 