namespace Task_5 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();
            
            Console.WriteLine("Введите x и у:");
            string[] input = Console.ReadLine()!.Split(" ");
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            double xy = x * x + y * y;
            
            if ((y >= 0 && xy <= 1) || (y < 0 && Math.Abs(x) <= 1))
                Console.WriteLine("Точка попадает в область");
            else 
                Console.WriteLine("Точка не попадает в область");
            
            Console.ReadKey(true); 
        }
    }
}