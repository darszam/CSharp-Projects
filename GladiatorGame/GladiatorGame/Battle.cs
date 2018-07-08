using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorGame
{
    class Battle
    {
         public static void StartFight(Warrior first, Warrior second)
        {
            while(first.Health>0 && second.Health>0)
            {
                double damage = first.Attack() - second.Block();
                damage = damage > 0 ? damage : 0;
                second.Health -= damage;
                Console.WriteLine(first.Name + " attacks " + second.Name + " and deals " + damage + " damage\n" + second.Name+ " has " + second.Health + "health\n");
                if (second.Health > 0)
                {
                    damage = second.Attack() - first.Block();
                    damage = damage > 0 ? damage : 0;
                    first.Health -= damage;
                    Console.WriteLine(second.Name + " attacks " + first.Name + " and deals " + damage + " damage\n" + first.Name + " has " + first.Health + "health\n");
                }
            }
            if (first.Health > 0)
            {
                Console.WriteLine(first.Name + " has died and " + second.Name + " is victorius\n");
            }
            else
            {
                Console.WriteLine(first.Name + " has died and " + second.Name + " is victorius\n");
            }
            Console.WriteLine("Game Over");
        }
    }
}
