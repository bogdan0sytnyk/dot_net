/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Task_8
    {
        static void Main()
        {
            Console.Write("Введите погрешность (eps): ");
            double eps = double.Parse(Console.ReadLine());

            Console.Write("Введите максимальное количество членов ряда: ");
            int maxTerms = int.Parse(Console.ReadLine());

            long n = 0;
            double dbln = 0.0;
            double sum = 0.0;
            double term = 0.0;
            short k1 = 1;

            while (n < maxTerms)
            {
                dbln = n;
                term = k1 * (dbln + 1) / (dbln * dbln * dbln + 2);
                sum += term;

                if (Math.Abs(term) < eps)
                {
                    Console.WriteLine($"Сумма ряда с точностью {eps:F7} достигнута после {n + 1} членов ряда.");
                    break;
                }

                k1 = (short)(-k1);
                n++;
            }

            Console.WriteLine($"Полная сумма ряда = {sum:F7}");
        }
    }
}
*/