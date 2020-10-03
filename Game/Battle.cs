using System;

namespace CSharpTutA.cs
{
    class Battle
    {
        // Start fight
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while(true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetAttackResult(Warrior warrior1, Warrior warrior2)
        {
            double warAAttkAmt = warrior1.Attack();
            double warBBlkAmt = warrior2.Block();

            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            if (dmg2WarB > 0)
            {
                warrior2.Health = warrior2.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warrior1.Name, warrior2.Name, dmg2WarB);

            Console.WriteLine("{0} Has {1} Health \n", warrior2.Name, warrior1.Name);

            if (warrior2.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorious\n", warrior2.Name, warrior1.name);
                return "Game Over";
            } else return "Fight Again";
        }
    }
}