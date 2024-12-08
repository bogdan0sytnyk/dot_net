namespace Task_9 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();
            
            short n;
            double x, y;
            short h;
            Console.WriteLine("|   x   |      y     |");
            Console.WriteLine("|-------|------------|");
            
            for (n = 0; n < 5; n++) {
                for (x = 0; x < 4; x += 0.25)
                {
                    if (x == 0)
                        y = 0;
                    else if (x < 1) 
                        y = -x;  
                    else if (x < 4) 
                        y = (1 - x) / 3;
                    else 
                        y = 0;

                    Console.Write($"| {x + n * 4,5:F2} | {y,10:F7} |");

                    h = (short)((y + 1) * 10);
                    if (y - 1 - h * 10 > 0.5) h++;

                    if (y == 0) {
                        for (; h > 0; h--) Console.Write("*");
                    } else {
                        for (; h > 0; h--) Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }
            
            Console.ReadKey(true); 
        }
    }
}