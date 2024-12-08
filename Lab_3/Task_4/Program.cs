using System;  // Підключення необхідної бібліотеки для введення-виведення та інших операцій
using System.IO;  // Підключення бібліотеки для роботи з файлами

namespace Task_4 {
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C:\University\Предметы\Дотнет\Lab_3\Task_4\input.txt"; 
            string outputFilePath = @"C:\University\Предметы\Дотнет\Lab_3\Task_4\output.txt";

            // Зчитуємо вміст вхідного файлу і зберігаємо його в змінну inputText
            string inputText = File.ReadAllText(inputFilePath);

            // Заміна кожної коми на два знаки питання та збереження зміненого тексту в modifiedText
            string modifiedText = inputText.Replace(",", "??");

            // Запис зміненого тексту назад у файл output.txt
            File.WriteAllText(outputFilePath, modifiedText);

            // Виведення повідомлення про завершення операції
            Console.WriteLine("Операцiя завершена. Результат записано у файл output.txt");
        }
    }
}