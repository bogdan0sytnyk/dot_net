/*using System;

namespace Lab_1
{
    internal class Task_7
    {
        static void Main()
        {
            long n = 0;          // Параметр ряда
            double dbln = 0.0;   // Параметр ряда в форме с плавающей точкой
            double sum = 0.0;    // Сумма членов ряда
            double term = 0.0;   // Значение текущего члена
            const double eps = 0.000001;  // Предел точности
            short k1 = 1;         // Math.Pow(-1, n)

            // Основной цикл; в модификациях вычисляются следующие значения Math.Pow(2, n) и Math.Pow(-1, n)
            while (true)
            {
                // Преобразование n в форму с плавающей точкой
                dbln = n;

                // Вычисление очередного члена
                term = k1 * (dbln + 1) / (dbln * dbln * dbln + 2);

                // Проверка достижения предела точности
                if (Math.Abs(term) >= eps)
                {
                    // Если не достигнут - накопление суммы
                    sum += term;
                }
                else
                {
                    break; // Если достигнут - выход из цикла
                }

                // Если 10 членов - вывод суммы
                if (n == 9)
                {
                    Console.WriteLine($"Сумма 10 членов ряда = {sum:F7}");
                }

                // Смена знака k1
                k1 = (short)(-k1);
                n++;
            }

            // Вывод окончательной суммы
            Console.WriteLine($"Полная сумма ряда = {sum:F7}");
        }
    }
}
*/