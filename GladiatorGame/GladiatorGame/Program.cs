using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior marius = new Warrior("Marius", 1000, 120, 40);
            Warrior marcus = new Warrior("Marcus", 1000, 120, 40);
            Battle.StartFight(marius, marcus);
            Console.ReadLine();
        }
    }
}
