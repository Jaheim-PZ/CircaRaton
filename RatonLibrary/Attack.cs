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
            Random fight = new Random();
            int combat = fight.Next(2,10);
            Random hit = new Random();
            int result = hit.Next(1, 25);
            int finalDam = playerHp - result;
            if (combat > 1)
            { 
                Console.WriteLine("You are currently fighting \n");
                Console.WriteLine(MobInformation.FireFox());
                int enemyHp = 35;
                Console.WriteLine($"You attack the Firefox dealing {result}");
                int currentHp = enemyHp - result;
                Console.WriteLine("The Firefox is left with " + currentHp);
                if(currentHp > 0)
                {
                    Console.WriteLine($"You attack the Firefox dealing {result}");
                    int FinalHp = currentHp - result;
                    Console.WriteLine("The Firefox is left with" + FinalHp);
                    if(FinalHp <= 0)
                    {
                        Console.WriteLine("You have defeated the enemy!");
                    }
                }
            }
            else
            {
                return ($"You dealt {result} of damage leaving the enemy with {finalDam} Hp");
            }

            return "";
            
         }
    }
}
