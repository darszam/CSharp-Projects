using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt_data = DateTime.Now;


            /* //Format DD-MM-YYYY HH:mm:ss
             Console.WriteLine("First Format: {0:dd-MM-yyyy HH:mm:ss}", dt_data);

             //Second format Name of day of month MONTH Year
             Console.WriteLine("Second Format: {0:dddd} of month {0:MMMM yyyy}", dt_data);

             //Third format 
             //Day Name of day
             //Month Name of month
             //Year 2018
             Console.WriteLine("Third Format:\n" +
                 "Day {0:dddd} \n" +
                 "Month {0:MMMM}\n" +
                 "Year {0:yyyy}", dt_data);
             */
            Console.WriteLine("What was the day of the week of your birthday?");
            Console.WriteLine("Please type year of your birthday");
            int i_year = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type month of your birthday");
            int i_month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type day of your birthday");
            int i_day = int.Parse(Console.ReadLine());
            DateTime dt_birthday = new DateTime(i_year, i_month, i_day);
            Console.WriteLine("It was {0}", dt_birthday.DayOfWeek);
            Console.ReadKey();
        }
    }
}
