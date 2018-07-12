using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Main is also thread so Main and Thread y will share time for their operations until they are completed
             * Thread y = new Thread(Print1);
            y.Start();
            for(int i=0;i<1000;i++)
            {
                Console.Write(0);
            }
            */
            //Sleep example
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);

                // Pause for 1 second
                Thread.Sleep(1000);

                num++;
            }

            Console.WriteLine("Thread Ends");

            Console.ReadLine();
        }
        static void Print1()
        {
            for(int i=0;i<1000;i++)
            {
                Console.Write(1);
            }
        }
    }
}
