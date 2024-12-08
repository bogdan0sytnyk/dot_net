using System;
using System.Text;
using MystemSharp;

namespace Task_2
{
    class Program
    {
        static string ReplaceCharacters(string input, string sourceAlphabet, string targetAlphabet)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int index = sourceAlphabet.IndexOf(currentChar);

                if (index >= 0 && index < targetAlphabet.Length)
                {
                    result.Append(targetAlphabet[index]);
                }
                else
                {
                    result.Append(currentChar);
                }
            }

            return result.ToString();
        }

        static void Main()
        {
            string englishAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string ukrainianAlphabet = "zyxwvutsrgponmlkjihgfedcba";

            Console.WriteLine("Введите текст для замены:");
            string input = Console.ReadLine();

            string resultEnglishToUkrainian = ReplaceCharacters(input, englishAlphabet, ukrainianAlphabet);
            string resultUkrainianToEnglish = ReplaceCharacters(input, ukrainianAlphabet, englishAlphabet);

            Console.WriteLine("Результат замены с английского на украинский:");
            Console.WriteLine(resultEnglishToUkrainian);

            Console.WriteLine("Результат замены с украинского на английский:");
            Console.WriteLine(resultUkrainianToEnglish);
        }
    }
}