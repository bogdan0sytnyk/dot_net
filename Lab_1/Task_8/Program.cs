namespace Task_8 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();
            
            Console.WriteLine("Введите погрешность и количество членов ряда");
            string[] input = Console.ReadLine()!.Split(" ");
            double eps = double.Parse(input[0]);
            int limit = int.Parse(input[1]);
            
            double sum = 0;
            
            for (int i = 0; ; i++) {
                double current = Math.Pow(-1, i) * (2 * i + 1) / (Math.Pow(i, 3) + 1.0);
                if (Math.Abs(current) <= eps) 
                    break;
                
                sum += current;
                
                if (i == limit - 1) 
                    Console.WriteLine($"Сумма первых {limit} = {sum:F3}");
            }
            Console.WriteLine($"Полная cумма ряда = {sum:F3}");
            
            Console.ReadKey(true); 
        }
    }
}