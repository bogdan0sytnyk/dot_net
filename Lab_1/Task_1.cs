using System;

class Program
{
    const int NumCompanies = 3;

    static void Main()
    {
        string[] firms = new string[NumCompanies];
        int[] productCounts = new int[NumCompanies];
        long[] annualSales = new long[NumCompanies];
        double[] marketShare = new double[NumCompanies];

        InputData(firms, productCounts, annualSales, marketShare);
        PrintHeader();
        PrintCompanyData(firms, productCounts, annualSales, marketShare);

        Console.WriteLine("|------------------------------------------------------------------------------------|");
        Console.WriteLine("| Примечание: по данным Gartner Group за 1999 год                                    |");
        Console.WriteLine("|------------------------------------------------------------------------------------|");
        Console.ReadKey();
    }

    static void InputData(string[] firms, int[] productCounts, long[] annualSales, double[] marketShare)
    {
        for (int i = 0; i < NumCompanies; i++)
        {
            Console.Write($"{i + 1}. Введите: Фирма, Количество продуктов, Годовой объем продажи ($), Часть рынка (%) > ");
            string input = Console.ReadLine();
            string[] inputParts = input.Split(' ');
            firms[i] = inputParts[0];
            productCounts[i] = int.Parse(inputParts[1]);
            annualSales[i] = long.Parse(inputParts[2]);
            marketShare[i] = double.Parse(inputParts[3]);
        }
    }

    static void PrintHeader()
    {
        Console.WriteLine("|------------------------------------------------------------------------------------|");
        Console.WriteLine("| Фирмы - производители СКБД                                                         |");
        Console.WriteLine("|------------------------------------------------------------------------------------|");
        Console.WriteLine("| Фирма     | Количество. продуктов | Годовой объем продажи ($)  | Часть рынка (%)   |");
        Console.WriteLine("|-----------|-----------------------|----------------------------|-------------------|");
    }

    static void PrintCompanyData(string[] firms, int[] productCounts, long[] annualSales, double[] marketShare)
    {
        for (int i = 0; i < NumCompanies; i++)
        {
            Console.WriteLine($"| {firms[i],-9} | {productCounts[i],-21} | {annualSales[i],-26} | {marketShare[i],-17} |");
        }
    }
}