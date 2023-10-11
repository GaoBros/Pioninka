namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в мою Пионинку");
            Console.WriteLine("Небольшая инструкция:");
            Console.WriteLine("1. Выбор одной из четырех по нажатию клавиши F1, F2, F3, F4");
            Console.WriteLine("2. Белые клавиши A, S, D, F, G, H, J");
            Console.WriteLine("3. Черные клавиши W, E, R, T, I");
            Console.WriteLine("4. Вернуться к выбору октавы по клавише Backspace");
            Console.WriteLine("5. Выход по нажатию клавиши Escape");
            ConsoleKeyInfo Key = Console.ReadKey();
            Console.Clear();
            switch (Key.Key)                  //Брал частоты с сайта caitik.ru/notes.html
            {
                case ConsoleKey.F1:
                    O1();
                    break;
                case ConsoleKey.F2:
                    O2();
                    break;
                case ConsoleKey.F3:
                    O3();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }
        static void O1()
        {
            int[] Oct = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            Note(Oct);
        }

        static void O2()
        {
            int[] Oct = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            Note(Oct);

        }

        static void O3()
        {
            int[] Oct = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            Note(Oct);
        }

        static void Note(int[] Oct)
        {
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey();
                Console.Clear();
                switch (Key.Key)
                {
                    case ConsoleKey.A:
                        MkSd(Oct[0]);
                        break;
                    case ConsoleKey.W:
                        MkSd(Oct[1]);
                        break;
                    case ConsoleKey.S:
                        MkSd(Oct[2]);
                        break;
                    case ConsoleKey.E:
                        MkSd(Oct[3]);
                        break;
                    case ConsoleKey.D:
                        MkSd(Oct[4]);
                        break;
                    case ConsoleKey.F:
                        MkSd(Oct[5]);
                        break;
                    case ConsoleKey.R:
                        MkSd(Oct[6]);
                        break;
                    case ConsoleKey.G:
                        MkSd(Oct[7]);
                        break;
                    case ConsoleKey.T:
                        MkSd(Oct[8]);
                        break;
                    case ConsoleKey.H:
                        MkSd(Oct[9]);
                        break;
                    case ConsoleKey.J:
                        MkSd(Oct[10]);
                        break;
                    case ConsoleKey.Backspace:
                        Main();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void MkSd(int Chastota)
        {
            Console.Beep(Chastota, 200);
            Console.Clear();
        }
    }
}