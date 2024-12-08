using System;
using System.Collections.Generic;

namespace Task_2
{
    abstract class Work
    {
        protected string title; // Назва роботи
        protected int hoursWorked; // Години виконання роботи

        // Конструктор класу Work
        public Work(string title, int hoursWorked)
        {
            this.title = title;
            this.hoursWorked = hoursWorked;
        }

        // Абстрактний метод для відображення інформації
        public abstract void DisplayInfo();
    }

    class RegularWork : Work
    {
        protected string department; // Відділ, де виконується робота

        // Конструктор класу RegularWork
        public RegularWork(string title, int hoursWorked, string department) : base(title, hoursWorked)
        {
            this.department = department;
        }

        // Реалізація методу для відображення інформації
        public override void DisplayInfo()
        {
            Console.WriteLine($"Назва: {title}, Витрачено годин: {hoursWorked}, Вiддiл: {department}");
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }

    class OvertimeWork : Work
    {
        protected string reason; // Причина позачасової роботи

        // Конструктор класу OvertimeWork
        public OvertimeWork(string title, int hoursWorked, string reason) : base(title, hoursWorked)
        {
            this.reason = reason;
        }

        // Реалізація методу для відображення інформації
        public override void DisplayInfo()
        {
            Console.WriteLine($"Назва: {title}, Витрачено годин: {hoursWorked}, Причина: {reason}");
        }
    }

    class HighPriorityWork : RegularWork
    {
        protected string supervisor; // Назва наглядача

        // Конструктор класу HighPriorityWork
        public HighPriorityWork(string title, int hoursWorked, string department, string supervisor) : base(title,
            hoursWorked, department)
        {
            this.supervisor = supervisor;
        }

        // Власний метод для відображення додаткової інформації
        public void Display()
        {
            Console.WriteLine(
                $"Назва: {title}, Витрачено годин: {hoursWorked}, Вiддiл: {department}, Наглядач: {supervisor}");
        }
    }

    class LowPriorityWork : RegularWork
    {
        protected string comments; // Коментарі

        // Конструктор класу LowPriorityWork
        public LowPriorityWork(string title, int hoursWorked, string department, string comments) : base(title,
            hoursWorked, department)
        {
            this.comments = comments;
        }

        // Власний метод для відображення додаткової інформації
        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Назва: {title}, Витрачено годин: {hoursWorked}, Вiддiл: {department}, Коментарi: {comments}");
        }
    }

    class Worker
    {
        private string fullName; // ПІБ працівника
        private string position; // Посада
        private int startYear; // Рік надходження на роботу
        private double salary; // Зарплата

        // Конструктор класу Worker
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

            int yearsThreshold = 10;
            Console.WriteLine($"\nПрацiвники зi стажем бiльше {yearsThreshold} рокiв:");
            foreach (var worker in workers)
            {
                if (DateTime.Now.Year - worker.GetStartYear() > yearsThreshold)
                {
                    worker.ShowInfo();
                }
            }

            double salaryThreshold = 60000;
            Console.WriteLine($"\nПрацiвники з зарплатою бiльше {salaryThreshold}:");
            foreach (var worker in workers)
            {
                if (worker.GetSalary() > salaryThreshold)
                {
                    worker.ShowInfo();
                }
            }

            string positionToFind = "Посада 3";
            Console.WriteLine($"\nПрацiвники з посадою {positionToFind}:");
            foreach (var worker in workers)
            {
                if (worker.GetPosition() == positionToFind)
                {
                    worker.ShowInfo();
                }
            }

            Work[] works = new Work[]
            {
                new RegularWork("Настройка серверу", 40, "IT"),
                new OvertimeWork("Невiдкладне завдання", 10, "Urgent Task"),
                new HighPriorityWork("Оцiнка кандитатiв", 30, "HR", "Supervisor X"),
                new LowPriorityWork("Розробка бюджету", 20, "Finance", "Reviewed and Approved")
            };

            Console.WriteLine("\nРоботи:");
            foreach (var work in works)
            {
                work.DisplayInfo();
            }

            Console.WriteLine("\nДодаткова iнформацiя:");
            foreach (var work in works)
            {
                if (work is RegularWork regularWork)
                {
                    regularWork.DisplayInfo();
                }
            }
        }
    }
}