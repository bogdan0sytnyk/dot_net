/*using System;

namespace Lab_1
{
    internal class Task_4
    {
        static void Main()
        {
            try
            {
                Console.Write("Введите x, y: ");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double a = 12.5;
                double b = 1.3;
                double c = 14.1;
                double d = 2.7;
                double n = 2.0;
                double t1, t2;
                double ax;
                double n1 = n - 1;
                ax = a * x;

                if (c == 0 || a == 0 || n1 == 0 || x < 0 || y <= 0 || (n1 < 0 && Math.Cos(ax) == 0))
                {
                    throw new ArgumentException("Некоректні вхідні дані. Перевірте значення x, y та констант.");
                }

                t1 = (1 / c) * ((b / a) * Math.Log(ax + b) + (d / y) * Math.Log(y * x + d));

                if (n1 < 0)
                {
                    throw new ArgumentException("Некоректні вхідні дані. n1 не може бути від'ємним при обчисленні t2.");
                }

                t2 = (1 / (a * n1)) * (Math.Sin(ax) / (Math.Pow(n1, Math.Cos(ax))));

                Console.WriteLine($"t1 = {t1}");
                Console.WriteLine($"t2 = {t2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка формату введених даних. Введіть числові значення для x та y.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла невідома помилка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Програма завершила свою роботу.");
            }
        }

    }
}
*/