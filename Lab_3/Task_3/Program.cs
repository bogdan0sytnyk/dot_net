using System;

namespace Task_3
{
    class Program
    {
        // Функція, яка видаляє з рядка всі входження 'К', 'к', 'k' та 'K'
        static string RemoveKCharacters(string input)
        {
            // Використовуємо Replace для заміни всіх входжень 'К', 'к', 'k' та 'K' на пустий рядок
            string result = input.Replace("К", "").Replace("к", "").Replace("k", "").Replace("K", "");
            return result; // Повертаємо оброблений рядок
        }

        static void Main()
        {
            string originalString = "Kaka Ккрутий гравець";

            string stringWithoutK = RemoveKCharacters(originalString); // Виклик функції для обробки рядка

            Console.WriteLine(stringWithoutK); // Виводимо результат
        }
    }
}