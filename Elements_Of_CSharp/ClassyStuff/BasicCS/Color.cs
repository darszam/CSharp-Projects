using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ClassyStuff.BasicCS
{
    class Color
    {
        public static void ConsoleOperationExamples()
        {
            WriteLine("Console Color example\n");
            var colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            WriteLine("All available colors");
            (int background, int foreground) userInput;
            do
            {
                userInput = DisplayColorMenu(colors);
                if (userInput.foreground == colors.Length + 1 || userInput.background == colors.Length + 1)
                {
                    WriteLine("Resetting to default...");
                    ResetColor();
                    Write("Press any key to continue...");
                    ReadLine();
                    Clear();
                    userInput = DisplayColorMenu(colors);
                }
                else if (userInput.foreground < 0 || userInput.background < 0)
                {
                    WriteLine("-ve values are no allowed.");
                    Clear();
                    userInput = DisplayColorMenu(colors);
                }
                else if (userInput.background == colors.Length + 2 || userInput.foreground == colors.Length + 2)
                {
                }
                else
                {
                    BackgroundColor = colors[userInput.background];
                    ForegroundColor = colors[userInput.foreground];

                    WriteLine($"Foreground color is {ForegroundColor}");
                    WriteLine($"Background color is {BackgroundColor}");
                    WriteLine();

                    Write("Type anything to see the changes:");
                    ReadLine();
                }
            } while (userInput.background != colors.Length + 2 || userInput.foreground != colors.Length + 2);
        }

        private static (int, int) DisplayColorMenu(ConsoleColor[] colors)
        {
            var count = 0;

            foreach (var color in colors)
            {
                WriteLine($"{count} {color}");
                count += 1;
            }
            WriteLine($"{count + 1} Reset");
            WriteLine($"{count + 2} Exit");

            Write("Choose Foreground color:");
            var foreground = Convert.ToInt32(ReadLine());
            Write("Choose Background color:");
            var background = Convert.ToInt32(ReadLine());

            return new ValueTuple<int, int>(background, foreground);
        }
    }
}
