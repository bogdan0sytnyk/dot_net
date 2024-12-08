namespace Task_2 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();  // Очищення консолі перед виведенням

            try {
                Console.WriteLine("Введите размер массива");  // Виведення повідомлення
                int size = int.Parse(Console.ReadLine()!);  // Зчитування та парсинг розміру масиву

                if (size <= 0) {  // Перевірка чи розмір не менше або дорівнює 0
                    throw new Exception("\nРазмер массива не может быть меньше или равен 0");  // Генерація виключення
                }

                int[] arr = new int[size];  // Створення масиву заданого розміру
                Random random = new Random();  // Створення генератора випадкових чисел

                // Заповнення масиву випадковими числами в діапазоні від -100 до 100
                for (int i = 0; i < arr.Length; i++) {
                    arr[i] = random.Next(-100, 101);
                }

                Console.WriteLine("Исходный массив:");  // Виведення повідомлення про початковий масив
                PrintArray(arr);  // Виклик методу для виведення масиву на екран

                // Сортування масиву за вказаним порядком
                Array.Sort(arr, (a, b) => {
                    if (a == 0 && b != 0) return -1;
                    if (a != 0 && b == 0) return 1;
                    return a.CompareTo(b);
                });

                Console.WriteLine("\nМассив после сортировки:");  // Виведення повідомлення після сортування
                PrintArray(arr);  // Виклик методу для виведення відсортованого масиву на екран
            } catch (Exception e) {  // Обробка виключень
                Console.WriteLine(e.Message);  // Виведення повідомлення про помилку
            } finally {
                Console.ReadKey(true);  // Очікування натискання клавіші перед завершенням програми
            }
        }

        // Метод для виведення масиву на екран
        static void PrintArray(int[] arr) {
            short c = 0;  // Лічильник для кількості виведених елементів на рядку

            foreach (var num in arr) {
                Console.Write($"{num, 5}");  // Виведення елемента масиву з вирівнюванням
                c++;
                if (c == 10) {
                    c = 0;
                    Console.WriteLine();  // Перехід на новий рядок після виведення 10 елементів
                }
            }
        }
    }
}