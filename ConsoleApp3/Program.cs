using System.Security.Cryptography;

namespace prakticheskaya3
{
    internal class Program
    {
        static int[] DO = new int[] { 65, 131, 262, 523 };
        static int[] do_dies = new int[] { 69, 139, 277, 554 };
        static int[] re = new int[] { 73, 147, 294, 587 };
        static int[] re_dies = new int[] { 78, 156, 311, 622 };
        static int[] mi = new int[] { 82, 165, 330, 659 };
        static int[] fa = new int[] { 87, 175, 349, 699 };
        static int[] fa_dies = new int[] { 93, 185, 370, 740 };
        static int[] sol = new int[] { 98, 196, 392, 784 };
        static int[] sol_dies = new int[] { 104, 208, 415, 831 };
        static int[] lya = new int[] { 110, 220, 440, 880 };
        static int[] lya_dies = new int[] { 117, 233, 466, 932 };
        static int[] ci = new int[] { 124, 247, 494, 988 };
        static void Main()
        {
            Console.WriteLine("Введите вашу октаву");
            Console.WriteLine("F1 - Первая октава");
            Console.WriteLine("F2 - Вторая октава");
            Console.WriteLine("F3 - Третья октава");
            Console.WriteLine("Escape - выход из программы");
            Console.WriteLine("Выбор октавы");
            Console.WriteLine("A - 'До' \nS - 'Ре'\nD - 'Ми'\nF - Фа'\nG - 'Соль'\nH - 'Ля'\nJ - 'Си");
            Console.WriteLine("W - 'До диез'\nE - 'Ре диез'\nT - Фадиез '\nY - 'Соль диез'\nU - 'Ля диез");
            ConsoleKey ikey;
            do
            {
                ikey = Console.ReadKey().Key;
                int coil = octavia(ikey);
                ConsoleKey key = Console.ReadKey().Key;
                while (key != ConsoleKey.Escape)
                {
                    switch (key)
                    {
                        case ConsoleKey.A:
                            Console.Beep(DO[coil], 200);
                            break;
                        case ConsoleKey.S:
                            Console.Beep(re[coil], 200);
                            break;
                        case ConsoleKey.D:
                            Console.Beep(mi[coil], 200);
                            break;
                        case ConsoleKey.F:
                            Console.Beep(fa[coil], 200);
                            break;
                        case ConsoleKey.G:
                            Console.Beep(sol[coil], 200);
                            break;
                        case ConsoleKey.H:
                            Console.Beep(lya[coil], 200);
                            break;
                        case ConsoleKey.J:
                            Console.Beep(ci[coil], 200);
                            break;
                        case ConsoleKey.W:
                            Console.Beep(do_dies[coil], 200);
                            break;
                        case ConsoleKey.E:
                            Console.Beep(re_dies[coil], 200);
                            break;
                        case ConsoleKey.R:
                            Console.Beep(fa_dies[coil], 200);
                            break;
                        case ConsoleKey.T:
                            Console.Beep(sol_dies[coil], 200);
                            break;
                        case ConsoleKey.Y:
                            Console.Beep(lya_dies[coil], 200);
                            break;
                    }
                    key = Console.ReadKey().Key;
                }
                Console.WriteLine("Нажата Escape");
            } while (ikey != ConsoleKey.Escape);
        }
        static int octavia(ConsoleKey oktava)
        {
            int i = 0;
            if (oktava == ConsoleKey.F1)
            {
                i = 0;
            }
            else if (oktava == ConsoleKey.F2)
            {
                i = 1;
            }
            else if (oktava == ConsoleKey.F3)
            {
                i = 2;
            }
            else if (oktava == ConsoleKey.F4)
            {
                i = 3;
            }
            return i;
        }
    }
}

