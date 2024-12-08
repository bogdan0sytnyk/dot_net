using System;

namespace Lab_1
{
    internal class Task_10
    {
        static void Main(string[] args)
        {
            int n;
            double x, y;
            int h;

            ConsoleColor numberColor = ConsoleColor.Green;
            ConsoleColor textColor = ConsoleColor.Yellow;
            ConsoleColor graphColor = ConsoleColor.Red;

            for (n = 0; n < 2; n++)
            {

                Console.ForegroundColor = textColor;
                Console.WriteLine("|   x   |      y     |");
                Console.WriteLine("|-------|------------|");

                for (x = 0; x < 4; x += 0.1)
                {
                    int simb = 0;

                    if (x < 1)
                    {
                        simb = 0;
                        y = 1;
                    }
                    else if (x < 2)
                    {
                        simb = 1;
                        y = 3 - 2 * x;
                    }
                    else if (x < 3)
                    {
                        simb = 2;
                        y = +(2 * x) - 5;
                    }
                    else
                    {
                        simb = 0;
                        y = 1;
                    }

                    Console.ForegroundColor = numberColor;
                    Console.Write($"| {x + n * 4,5:F2} | {y,10:F7} |");

                    Console.ForegroundColor = graphColor;
                    h = (int)((y + 1) * 10);
                    if (y - 1 - h * 10 > 0.5) h++;

                    for (; h > 0; h--) Console.Write(" ");
                    if (0 == 0)
                    {
                        Console.WriteLine("|");
                    }
                    else if (0 == 1)
                    {
                        Console.WriteLine("/");
                    }
                    else if (0 == 2)
                    {
                        Console.WriteLine("\\");
                    }
                    else
                    {
                        Console.WriteLine("|");
                    }
                }
                Console.ResetColor();

                Console.WriteLine("Нажмите клавишу Enter...");
                Console.ReadLine();
            }
        }
    }
}