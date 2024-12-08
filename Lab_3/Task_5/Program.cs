using System;
using System.IO;

namespace Task_5
{
    class Program
    {
        // Головна функція програми
        static void Main(string[] args)
        {
            // Шлях до вхідного файлу
            string inputFilePath = @"C:\University\Предметы\Дотнет\Lab_3\Task_5\input.txt";
            // Шлях до вихідного файлу
            string outputFilePath = @"C:\University\Предметы\Дотнет\Lab_3\Task_5\output.txt";

            // Зчитуємо вміст вхідного файлу
            string inputText = File.ReadAllText(inputFilePath);

            // Розділяємо рядок на слова
            string[] words = inputText.Split(' ');

            // Змінна для зберігання абревіатури
            string abbreviation = "";

            // Проходимо через кожне слово
            foreach (string word in words)
            {
                // Перевіряємо, чи слово не є порожнім або складається тільки з пробілів
                if (!string.IsNullOrWhiteSpace(word))
                {
                    // Додаємо першу букву слова до абревіатури
                    abbreviation += word.ToUpper()[0];
                }
            }

            // Записуємо результат назад у файл
            File.WriteAllText(outputFilePath, abbreviation);

            // Виводимо повідомлення про завершення операції
            Console.WriteLine("Операцiя завершена. Результат записано у файл output.txt");
        }
    }
}