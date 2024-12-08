using System;  // Підключення необхідної бібліотеки для введення-виведення та інших операцій
using System.IO;  // Підключення бібліотеки для роботи з файлами
using System.Linq;  // Підключення бібліотеки для використання LINQ запитів

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Зчитуємо текст з консолі
            Console.WriteLine("Введiть текст:");
            string inputText = Console.ReadLine();

            // Підраховуємо кількість великих літер
            int uppercaseCount = inputText.Count(char.IsUpper);

            // Виводимо кількість великих літер на консоль та записуємо у файл
            Console.WriteLine($"Кiлькiсть великих лiтер: {uppercaseCount}");
            File.WriteAllText("output.txt", $"Кiлькiсть великих лiтер: {uppercaseCount}\n");

            // Розбиваємо текст на слова та знаходимо мінімальну кількість літер у слові
            int minWordLength = inputText.Split(' ')
                .Where(word => !string.IsNullOrWhiteSpace(word)) // Видаляємо порожні слова
                .Min(word => word.Count(char.IsLetter)); // Знаходимо мінімальну кількість літер у слові

            // Знаходимо слова, що мають мінімальну кількість літер
            string[] shortestWords = inputText.Split(' ')
                .Where(word =>
                    !string.IsNullOrWhiteSpace(word) &&
                    word.Count(char.IsLetter) == minWordLength) // Вибираємо слова з мінімальною кількістю літер
                .ToArray();

            // Виводимо слова з мінімальною кількістю літер на консоль та записуємо у файл
            Console.WriteLine("Слова з мiнiмальною кiлькiстю лiтер:");
            File.AppendAllText("output.txt", "Слова з мiнiмальною кiлькiстю лiтер:\n");

            foreach (string word in shortestWords)
            {
                Console.WriteLine(word);
                File.AppendAllText("output.txt", word + "\n");
            }

            // Видаляємо слова, що починаються з малої літери
            string[] wordsToRemove = inputText.Split(' ')
                .Where(word =>
                    !string.IsNullOrWhiteSpace(word) &&
                    char.IsLower(word[0])) // Вибираємо слова, які починаються з малої літери
                .ToArray();

            foreach (string wordToRemove in wordsToRemove)
            {
                inputText = inputText.Replace(wordToRemove, ""); // Видаляємо ці слова
            }

            // Записуємо відредагований текст у файл
            File.AppendAllText(@"C:\University\Предметы\Дотнет\Lab_3\Task_6\output.txt", "\nВідредагований текст:\n");
            File.AppendAllText(@"C:\University\Предметы\Дотнет\Lab_3\Task_6\output.txt", inputText);

            Console.WriteLine("Результати записано у файл output.txt");
        }
    }
}