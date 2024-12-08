/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Task_6
    {
        static bool IsOnCurve(double x, double y)
        {
            bool isInside = Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;
            bool isNotInQuadrant = x > 0 && y > 0 || x < 0 && y < 0;
            return isInside ? !isNotInQuadrant : false;
        }

        static void Main()
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = double.Parse(Console.ReadLine());

            bool isOnCurve = IsOnCurve(x, y);

            Console.WriteLine(isOnCurve ? "Точка попадает в область" : "Точка не попадает в область");
        }
    }
}
*/