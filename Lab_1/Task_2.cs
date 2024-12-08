using System;


namespace Lab_1
{
    internal class Task_2
    {
        static void Main()
        {

            string[] firms = new string[3];
            int[] productCounts = new int[3];
            long[] annualSales = new long[3];
            double[] marketShare = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1}. Введите: Фирма, Количество продуктов, Годовой объем продажи ($), Часть рынка (%) > ");
                string input = Console.ReadLine();
                string[] inputParts = input.Split(' ');
                firms[i] = inputParts[0];
                productCounts[i] = int.Parse(inputParts[1]);
                annualSales[i] = long.Parse(inputParts[2]);
                marketShare[i] = double.Parse(inputParts[3]);
            }

            Console.Clear(); 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue; 

            Console.WriteLine("┌───────────┬───────────────────────┬───────────────────────────┬──────────────────┐");
            Console.WriteLine("│ Фирма     │ Количество. продуктов │ Годовой объем продажи ($) │ Часть рынка (%)  │");
            Console.WriteLine("├───────────┼───────────────────────┼───────────────────────────┼──────────────────┤");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"│ {firms[i],-9} │ {productCounts[i],-21} │ {annualSales[i],-25} │ {marketShare[i],-16:F1} │");
            }

            Console.WriteLine("├───────────┴───────────────────────┴───────────────────────────┴──────────────────┤");

            Console.WriteLine("│ Примечание: по данным Gartner Group за 1999г                                     │");
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────┘");
            Console.ResetColor();

            Console.ReadKey();

        }
    }
}
