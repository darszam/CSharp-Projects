using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyStuff
{
    class Fizzbuzz
    {

        static public void DoIt(int fizz = 3, int buzz = 5, int start = 1, int finish = 100)
        {
            for (; start < finish; start++)
            {
                if ((start % fizz == 0) || (start % buzz == 0))
                {
                    if (start % fizz == 0)
                        Console.Write("Fizz");
                    if (start % buzz == 0)
                        Console.Write("Buzz");
                }
                else
                    Console.Write(start);
                Console.Write(" ");
            }
        }
    }
}
