using System;
using System.IO;

namespace Task_7
{
    class Program
    {
        // Завдання з видаленням 'К', 'к', 'k', 'K'
        static string RemoveKCharacters(string input)
        {
            string result = input.Replace("К", "").Replace("к", "").Replace("k", "").Replace("K", "");
            return result;
        }

        // Завдання з вирівнювання по правому краю (відлік з кінця)
        static string AlignRightFromEnd(string input, int length)
        {
            if (input.Length >= length)
            {
                return input;
            }
            else
            {
                return input.PadLeft(length);
            }
        }

        // Завдання з вирівнювання по правому краю
        static string AlignRight(string input, int length)
        {
            if (input.Length >= length)
            {
                return input;
            }
            else
            {
                return input.PadLeft(length);
            }
        }

        static void Main()
        {
            string filePath = @"C:\University\Предметы\Дотнет\Lab_3\Task_7\input.txt"; // Шлях до вхідного файлу

            try
            {
                string originalString = File.ReadAllText(filePath); // Зчитуємо вміст файлу

                // Завдання з видаленням 'К', 'к', 'k', 'K'
                string stringWithoutK = RemoveKCharacters(originalString);

                // Завдання з вирівнювання по правому краю (відлік з кінця)
                int desiredLength1 = 30; // Приклад бажаної довжини
                string alignedString1 = AlignRightFromEnd(originalString, desiredLength1);

                // Завдання з вирівнювання по правому краю
                int desiredLength2 = 30; // Приклад бажаної довжини
                string alignedString2 = AlignRight(originalString, desiredLength2);

                // Записуємо результати у вихідний файл
                File.WriteAllText(@"C:\University\Предметы\Дотнет\Lab_3\Task_7\output.txt",
                    $"Результат без 'К': {stringWithoutK}\n\nВирівняно по правому краю (відлік з кінця): {alignedString1}\n\nВирівняно по правому краю: {alignedString2}");

                Console.WriteLine("Результат записано у файл output.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
    }
}