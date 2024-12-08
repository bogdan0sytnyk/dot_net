namespace Task_4 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();  // Очищення консолі перед виведенням

            try {
                Console.WriteLine("Введите размер списка");  // Виведення повідомлення
                int size = int.Parse(Console.ReadLine()!);  // Зчитування та парсинг розміру списку

                if (size <= 0) {  // Перевірка чи розмір не менше або дорівнює 0
                    throw new Exception("\nРазмер списка не может быть меньше или равен 0");  // Генерація виключення
                }

                List<int> list = new List<int>(size);  // Створення списку з вказаною величиною
                Random random = new Random();  // Створення генератора випадкових чисел

                // Додавання випадкових чисел в список в діапазоні від -100 до 100
                for (int i = 0; i < size; i++) {
                    list.Add(random.Next(-100, 101));
                }

                Console.WriteLine("Исходный список:");  // Виведення повідомлення про початковий список
                PrintList(list);  // Виклик методу для виведення списку на екран

                // Сортування списку за вказаним порядком
                list.Sort((a, b) => {
                    if (a == 0 && b != 0) return -1;
                    if (a != 0 && b == 0) return 1;
                    return a.CompareTo(b);
                });

                Console.WriteLine("\nСписок после сортировки:");  // Виведення повідомлення після сортування
                PrintList(list);  // Виклик методу для виведення відсортованого списку на екран
            }
            catch (Exception e) {  // Обробка виключень
                Console.WriteLine(e.Message);  // Виведення повідомлення про помилку
            } finally {
                Console.ReadKey(true);  // Очікування натискання клавіші перед завершенням програми
            }
        }

        // Метод для виведення списку на екран
        static void PrintList(List<int> list) {
            short c = 0;  // Лічильник для кількості виведених елементів на рядку

            foreach (var num in list) {
                if (num == 0)
                    Console.ForegroundColor = ConsoleColor.Magenta;  // Зміна кольору для чисел, які рівні нулю
                else if (num < 0)
                    Console.ForegroundColor = ConsoleColor.Cyan;  // Зміна кольору для від'ємних чисел
                else
                    Console.ForegroundColor = ConsoleColor.Red;  // Зміна кольору для додатних чисел

                Console.Write($"{num,5}");  // Виведення елемента списку з вирівнюванням
                c++;
                if (c == 10) {
                    c = 0;
                    Console.WriteLine();  // Перехід на новий рядок після виведення 10 елементів
                }
            }

            Console.ForegroundColor = ConsoleColor.White;  // Повернення стандартного кольору тексту
        }
    }
}