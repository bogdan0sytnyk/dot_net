namespace Task_5 {

    class Program {
        static void Main(string[] args) {
            const int N = 9;  // Задаємо розмірність квадратної матриці
            int[,] matrix = new int[N, N];  // Створюємо квадратну матрицю
            int number = 1;  // Початкове число

            // Заповнюємо числа до головної діагоналі включно
            for (int diagonal = 0; diagonal < N; diagonal++) {
                for (int row = 0; row <= diagonal; row++) {
                    int col = diagonal - row;
                    matrix[row, col] = number++;
                }
            }

            // Заповнюємо матрицю після головної діагоналі
            for (int i = 0; i < N; i++) {
                int row = i + 1;
                int col = 8;
                while (row != N) {
                    matrix[row, col] = number++;
                    row++;
                    col--;
                }
            }

            // Виводимо матрицю на екран
            for (int row = 0; row < N; row++) {
                for (int col = 0; col < N; col++) {
                    Console.Write($"{matrix[row, col], 2} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);  // Очікування натискання клавіші перед завершенням програми
        }
    }
}