/*using System;

namespace Lab_1
{
    internal class Task_9
    {
        static void Main(string[] args)
        {
            int n;
            double x, y;
            int h;

            for (n = 0; n < 2; n++)
            {
                Console.WriteLine("|   x   |      y     |");
                Console.WriteLine("|-------|------------|");

                for (x = 0; x < 4; x += 0.1)
                {
                    if (x < 1) y = 1;
                    else if (x < 2) y = 3 - 2 * x;
                    else if (x < 3) y = + (2 * x) - 5;
                    else y = 1;

                    Console.Write($"| {x + n * 4,5:F2} | {y,10:F7} |");

                    h = (int)((y + 1) * 10);
                    if (y - 1 - h * 10 > 0.5) h++;

                    for (; h > 0; h--) Console.Write(" ");
                    Console.WriteLine("*");
                }

                Console.WriteLine("Нажмите клавишу Enter...");
                Console.ReadLine();
            }
        }
    }
}
*/