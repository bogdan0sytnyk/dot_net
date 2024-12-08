namespace Task_2 {
    static class Program {
        public static void Main(string[] args) {
            Console.Clear();
            
            string[] substances = new string[3];
            char[] types = new char[3]; 
            string[] temperatures = new String[3];
            
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Введите вещество, тип, и температуру:");
                string input = Console.ReadLine()!;
                string[] values = input.Split(' ');
                substances[i] = values[0];
                types[i] = values[1][0];
                temperatures[i] = values[2];
            }
            
            Console.WriteLine();
            Console.WriteLine("\u250c--------------------------------\u2510");
            Console.WriteLine("| Температура перехода веществ в |");
            Console.WriteLine("|  сверхпроводниковое состояние  |");
            Console.WriteLine("\u251c--------------------------------\u2524");
            Console.WriteLine("| Вещество |  Тип  | Температура |");
            Console.WriteLine("\u251c--------------------------------\u2524");

            for (int i = 0; i < 3; i++) {
                Console.Write($"| {substances[i],-8} |   {types[i],-3} |");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($" {temperatures[i],-11} ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|");
            }
            
            Console.WriteLine("\u251c--------------------------------\u2524");
            Console.WriteLine("|    Тип вещества: М - металл,   |");
            Console.WriteLine("|    П - сплав, С - соединение   |");
            Console.WriteLine("\u2514--------------------------------\u2518");

            Console.ResetColor();
            Console.ReadKey(true);
        }
    }
}

// Zn M 0.8-0.8
// Pb-Au P 2.0-7.3
// NbC C 10.1-10.5