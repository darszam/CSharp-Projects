using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorGame
{
    class Warrior
    {
        public string Name { get ; set ; } = "Warrior";
        public double Health { get; set; } = 0;
        public double MaxAttack { get; set; } = 0;
        public double MaxBlock { get; set; } = 0;
        Random rnd = new Random();
        public Warrior()
        {
        }
        public Warrior(string name = "Warrior", double hp = 0, double attack=0, double block=0)
        {
            Name = name;
            Health =  hp;
            MaxAttack = attack;
            MaxBlock = block;
        }
        public double Attack()
        {      
            return rnd.Next(1, (int)MaxAttack);
        }
        public double Block()
        {
            return rnd.Next(1, (int)MaxBlock);
        }
    }
}
