namespace Task_6 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();
            
            Console.WriteLine("Введите x и у:");
            string[] input = Console.ReadLine()!.Split(" ");
            double x = double.Parse(input[0]);
            double y = double.Parse(input[1]);
            double xy = x * x + y * y;
            
            string result = (y >= 0 && xy <= 1) || (y < 0 && Math.Abs(x) <= 1) ?
                    "Точка попадает в область" : 
                    "Точка не попадает в область";
            
            Console.WriteLine(result);
            
            Console.ReadKey(true); 
        }
    }
}