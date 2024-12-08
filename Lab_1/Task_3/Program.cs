namespace Task_3 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();
            int m = 4, n = 3;
            double a = 12.5, b = 1.3;
            
            Console.WriteLine("Введите х: ");
            double x = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите y: ");
            double y = double.Parse(Console.ReadLine()!);

            double ax = a * x;
            double sqrtX = Math.Sqrt(x);
            double part1 = 2 * sqrtX / (3 * Math.Pow(b, 2));
            double part2 = 2 * Math.Pow(a, 2) * sqrtX / Math.Pow(b, 4);
            double part3 = 2 * Math.Pow(a, 3) * y / Math.Pow(b, 5);
            
            double t1 = part1 - part2 + part3;
            double t2 = (Math.Sin(n - 1) * ax + Math.Cos(m - 1) * ax) / (a * (n + m));
            
            Console.WriteLine($"t1 = {Math.Round(t1, 3)}");
            Console.WriteLine($"t2 = {Math.Round(t2, 3)}");
            Console.ReadKey(true);
        }
    }
}