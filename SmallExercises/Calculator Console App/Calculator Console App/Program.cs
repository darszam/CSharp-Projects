using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Console_App.Models;

namespace Calculator_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello! Do you want to do operation on integers or doubles?");
            string answer = Console.ReadLine();
            Operation op = new Operation(answer);
            Console.WriteLine("This calculator can show you result of sum, substraction, division, multiplication and modulo");
            Console.WriteLine("Result of sum 1 + 2 = " + Operation.Add(1, 2));
            Console.WriteLine("Result of sum 1,3 + 2,5 = " + Operation.Add(1.3, 2.5));
            Console.ReadKey();
        }
    }
}
