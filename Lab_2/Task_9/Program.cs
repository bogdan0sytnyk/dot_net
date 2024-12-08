namespace Task_9 {

    class Program {
        static void Main(string[] args) {
            Console.Clear();
            try {
                Console.WriteLine("Введите размер матрицы n * n:");  // Повідомлення для введення розміру матриці
                int n = int.Parse(Console.ReadLine()!);  // Зчитування та парсинг розміру

                if (n <= 0) {
                    throw new Exception("Неверный размер матрицы");  // Перевірка правильності введеного розміру
                }

                double[,] matrix = new double[n, n];  // Створення двовимірної матриці
                Random random = new Random();  // Генератор випадкових чисел

                // Заповнюємо матрицю випадковими значеннями
                for (int row = 0; row < n; row++) {
                    for (int col = 0; col < n; col++) {
                        matrix[row, col] = random.NextDouble() * 10;  // Генеруємо випадкове число від 0 до 10
                    }
                }

                Console.WriteLine("Матрица:");  // Виведення матриці
                PrintMatrix(matrix);

                Console.Write("Введите величину, с которой будем сравнивать среднее арифметическое: ");  // Повідомлення для введення порогу
                double limit = double.Parse(Console.ReadLine()!);  // Зчитування та парсинг порогу

                int count = 0;  // Лічильник кількості рядків

                // Перевіряємо кожний рядок матриці
                for (int row = 0; row < n; row++) {
                    double sum = 0;

                    for (int col = 0; col < n; col++) {
                        sum += matrix[row, col];  // Обчислення суми елементів рядка
                    }

                    double average = sum / n;  // Обчислення середнього арифметичного

                    if (average < limit) {  // Порівняння з порогом
                        count++;
                    }
                }

                Console.WriteLine($"Количество строк с средним арифметическим меньше {limit}: {count}");  // Виведення результату
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);  // Виведення повідомлення про помилку
            }
            finally {
                Console.ReadKey(true);  // Очікування натискання клавіші перед завершенням програми
            }
        }

        static void PrintMatrix(double[,] matrix) {
            int size = matrix.GetLength(0);  // Отримання розміру матриці

            for (int row = 0; row < size; row++) {
                for (int col = 0; col < size; col++) {
                    Console.Write($"{matrix[row, col],5:F2} ");  // Виведення елементу матриці з 2 знаками після коми
                }
                Console.WriteLine();  // Перехід на новий рядок
            }
        }
    }
}