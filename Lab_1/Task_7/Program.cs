namespace Task_7 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();
            
            const double eps = 0.000001;
            double sum = 0;
            
            for (int i = 0; ; i++) {
                double current = Math.Pow(-1, i) * (2 * i + 1) / (Math.Pow(i, 3) + 1);
                if (Math.Abs(current) <= eps) 
                    break;
                
                sum += current;
                
                if (i == 9) 
                    Console.WriteLine($"Сумма первых 10 = {sum:F3}");
            }
            Console.WriteLine($"Полная cумма ряда = {sum:F3}");
            
            Console.ReadKey(true); 
        }
    }
}