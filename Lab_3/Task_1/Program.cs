using System;

namespace Task_1
{
    class Program
    {
        // Функція, яка вирівнює рядок по правому краю до заданої довжини
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
            string originalString;
            int desiredLength = 20;

            while (true)
            {
                originalString = Console.ReadLine();
                if (originalString == "") break; 
                string alignedString = AlignRight(originalString, desiredLength);
                Console.WriteLine(alignedString);
            }

            // Виклик функції та виведення результату
            
        }
    }
}