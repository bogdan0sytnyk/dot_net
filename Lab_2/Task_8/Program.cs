namespace Task_8 {

    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Введите размер матрицы n * n");  // Повідомлення для введення розміру матриці
                int n = int.Parse(Console.ReadLine()!);  // Зчитування та парсинг розміру

                if (n <= 0) throw new Exception("Неверный размер матрицы");  // Перевірка правильності введеного розміру

                int[][] matrix = new int[n][];  // Створення масиву масивів (матриці)
                int number = 1;  // Початкове число для заповнення

                // Ініціалізуємо рядки матриці
                for (int row = 0; row < n; row++) {
                    matrix[row] = new int[n];
                }

                // Заповнюємо числами до головної діагоналі включно
                for (int diagonal = 0; diagonal < n; diagonal++) {
                    for (int row = 0; row <= diagonal; row++) {
                        int col = diagonal - row;
                        matrix[row][col] = number++;
                    }
                }

                // Заповнюємо матрицю після головної діагоналі
                for (int i = 0; i < n; i++) {
                    int row = i + 1;
                    int col = n - 1;
                    while (row != n) {
                        matrix[row][col] = number++;
                        row++;
                        col--;
                    }
                }

                PrintColorfulMatrix(n, matrix);  // Виклик методу для виведення кольорової матриці
            } catch (Exception e) {
                Console.WriteLine(e.Message);  // Виведення повідомлення про помилку
            } finally {
                Console.ReadKey(true);  // Очікування натискання клавіші перед завершенням програми
            }
        }

        private static void PrintColorfulMatrix(int n, int[][] matrix) {
            ConsoleColor[] colors = { ConsoleColor.Cyan, ConsoleColor.Green, 
                ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Magenta };  // Масив кольорів для чисел
            Random random = new Random();  // Генератор випадкових чисел

            for (int row = 0; row < n; row++) {
                for (int col = 0; col < n; col++) {            
                    Console.ForegroundColor = colors[random.Next(0, colors.Length)];  // Вибір випадкового кольору
                    Console.Write($"{matrix[row][col],2} ");  // Виведення числа
                }

                Console.WriteLine();  // Перехід на новий рядок
            }
        }
    }
}