namespace Task_1 {
    static class Program {
        static void Main(string[] args) {
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
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|Температура перехода веществ в     |");
            Console.WriteLine("|сверхпроводниковое состояние       |");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|Вещество \t|Тип \t|Температура|");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < 3; i++) {
                Console.WriteLine($"|{substances[i]} \t\t|{types[i]}     \t|  {temperatures[i]}  |");
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|    Тип вещества: М - металл,      |");
            Console.WriteLine("|    П - сплав, С - соединение      |");
            Console.WriteLine("-------------------------------------");
            Console.ReadKey(true);
        }
    }
}
// Zn M 0.8-0.8
// Pb-Au P 2.0-7.3
// NbC C 9.1-9.5