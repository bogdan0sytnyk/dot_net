using System;
using System.IO;
using MystemSharp;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 4

            string inputFilePathTask4 = @"C:\University\Предметы\Дотнет\Lab_3\Task_8\input.txt";
            string outputFilePathTask4 = @"C:\University\Предметы\Дотнет\Lab_3\Task_8\output.bin";

            string inputBytesTask4 = File.ReadAllText(inputFilePathTask4);

            string modifiedText = inputBytesTask4.Replace(",", "??");

            File.WriteAllText(outputFilePathTask4, modifiedText);
            
            Console.WriteLine(inputBytesTask4.Replace(",", "??")); 

            // Завдання 5

            string inputFilePathTask5 = @"C:\University\Предметы\Дотнет\Lab_3\Task_8\input.txt";
            string outputFilePathTask5 = @"C:\University\Предметы\Дотнет\Lab_3\Task_8\output.bin";

            string inputTextTask5 = File.ReadAllText(inputFilePathTask5);
            string[] words = inputTextTask5.Split(' ');

            string abbreviation = "";

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    abbreviation += word.ToUpper()[0];
                }
            }

            File.WriteAllText(outputFilePathTask5, abbreviation);
            Console.WriteLine(abbreviation);

            // Комбінуємо результати та зберігаємо у бінарний файл

            byte[] combinedBytes = new byte[modifiedText.Length + abbreviation.Length];
            //Buffer.BlockCopy(modifiedText, 0, combinedBytes, 0, modifiedText.Length);


            for(int i = 0; i < modifiedText.Length; i++)
            {
                combinedBytes[i] = (byte)modifiedText[i];
            }

            for (int i = 0; i < abbreviation.Length; i++)
            {
                combinedBytes[modifiedText.Length + i] = (byte)abbreviation[i];
            }

            string combinedBinaryFilePath = @"C:\University\Предметы\Дотнет\Lab_3\Task_8\output.bin";
            File.WriteAllBytes(combinedBinaryFilePath, combinedBytes);

            Console.WriteLine("Результат об'єднано та записано у бiнарний файл output.bin");
        }
    }
}
