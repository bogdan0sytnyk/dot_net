/*using System;
using System.ComponentModel.Design;
using System.Data.SqlTypes;

namespace Lab_1
{
    internal class Task5
    {
        static bool IsOnCurve(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
            {
                if (x > 0 & y > 0)
                {
                    return false;
                }
                else if (x < 0 & y < 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        static void Main()
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());

            if (IsOnCurve(x, y))
            {
                Console.WriteLine("Точка попадает в область");
            }
            else
            {
                Console.WriteLine("Точка не попадает в область");

            }
        }
    }
}
*/