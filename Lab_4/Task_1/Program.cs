using System;
using System.Collections.Generic;

namespace Task_1
{
    class Worker
    {
        private string fullName; // ПІБ працівника
        private string position; // Посада
        private int startYear; // Рік надходження на роботу
        private double salary; // Зарплата

        public Worker(string fullName, string position, int startYear, double salary)
        {
            this.fullName = fullName;
            this.position = position;
            this.startYear = startYear;
            this.salary = salary;
        }

        // Методи для отримання значень полів
        public string GetFullName()
        {
            return fullName;
        }

        public string GetPosition()
        {
            return position;
        }

        public int GetStartYear()
        {
            return startYear;
        }

        public double GetSalary()
        {
            return salary;
        }

        // Метод для зміни зарплати
        public void SetSalary(double newSalary)
        {
            salary = newSalary;
        }

        // Метод для виведення інформації про працівника
        public void ShowInfo()
        {
            Console.WriteLine(
                $"Iм'я: {fullName}, Посада: {position}, Рiк надходження: {startYear}, Зарплата: {salary}");
        }
    }

    class Program
    {
        static string[] firstNames = { "Iван", "Iрина", "Богдан", "Алiна", "Михайло", "Емiлiя", "Давiд", "Сара" };
        static string[] lastNames = { "Смiт", "Джонсон", "Браун", "Девiс", "Лi", "Кiм", "Вiлсон", "Кларк" };

        // Метод для генерації випадкового імені
        static string GenerateRandomName()
        {
            Random random = new Random();
            string firstName = firstNames[random.Next(firstNames.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];
            return $"{firstName} {lastName}";
        }

        static void Main()
        {
            List<Worker> workers = new List<Worker>();
            Random random = new Random();

            // Додати декілька працівників у список
            for (int i = 0; i < 5; i++)
            {
                string fullName = GenerateRandomName();
                string position = "Посада " + (i + 1);
                int startYear = random.Next(2000, 2023);
                double salary = random.Next(30000, 80000);

                workers.Add(new Worker(fullName, position, startYear, salary));
            }

            // Вивести всіх працівників
            foreach (var worker in workers)
            {
                worker.ShowInfo();
            }

            // Вивести працівників, стаж яких перевищує певне число років
            int yearsThreshold = 10;
            Console.WriteLine($"\nПрацiвники зi стажем бiльше {yearsThreshold} рокiв:");
            foreach (var worker in workers)
            {
                if (DateTime.Now.Year - worker.GetStartYear() > yearsThreshold)
                {
                    worker.ShowInfo();
                }
            }

            // Вивести працівників, зарплата яких більша за певну суму
            double salaryThreshold = 60000;
            Console.WriteLine($"\nПрацiвники з зарплатою бiльше {salaryThreshold}:");
            foreach (var worker in workers)
            {
                if (worker.GetSalary() > salaryThreshold)
                {
                    worker.ShowInfo();
                }
            }

            // Вивести працівників за певною посадою
            string positionToFind = "Посада 3";
            Console.WriteLine($"\nПрацiвники з посадою {positionToFind}:");
            foreach (var worker in workers)
            {
                if (worker.GetPosition() == positionToFind)
                {
                    worker.ShowInfo();
                }
            }
        }
    }
}