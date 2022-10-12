using System;
namespace Пианино
{
    internal class Program
    {
        static int[] Octave1 = { 1037, 1038, 1039, 1040, 1041, 1043, 1046, 1049, 1055, 1058, 1061, 1063 };
        static int[] Octave2 = { 1065, 1069, 1073, 1077, 1082, 1087, 1092, 1098, 1103, 1110, 1116, 1123 };
        static int[] Octave3 = { 1130, 1138, 1146, 1155, 1165, 1174, 1185, 1196, 1207, 1220, 1233, 1246 };
        static int[] Octave4 = { 1261, 1277, 1293, 1311, 1329, 1349, 1370, 1392, 1415, 1440, 1466, 1493 };
        static int[] Octave5 = { 1523, 1554, 1587, 1622, 1659, 1698, 1740, 1784, 1830, 1880, 1932, 1987 };
        static void Main(string[] args)
        {
            Console.WriteLine("Выбери октаву: F1, F2, F3, F4, F5 \n " +
                "Клавиши: D, R, F, T, G, Y, H, U, J, I, K, L");
            while (true)
            {
                int[] lol = Octave();
                if (lol == Octave1)
                {
                    Console.WriteLine("Первая октава: ");
                    Sound(lol);
                }
                if (lol == Octave2)
                {
                    Console.WriteLine("Вторая октава");
                    Sound(lol);

                }
                else if (lol == Octave3)
                {
                    Console.WriteLine("Третья октава");
                    Sound(lol);
                }
                else if (lol == Octave4)
                {
                    Console.WriteLine("Четвертая октава: ");
                    Sound(lol);
                }
                else if (lol == Octave5)
                {
                    Console.WriteLine("Пятая октава");
                    Sound(lol);
                }
            }
            static int[] Octave()
            {
                int[] poop = new int[13];
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Console.WriteLine(Key.Key);
                    if (Key.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("Первая октава: ");
                        poop = Octave1;
                        return poop;
                    }
                    else if (Key.Key == ConsoleKey.F2)
                    {
                        Console.WriteLine("Вторая октава: ");
                        poop = Octave2;
                        return poop;
                    }
                    else if (Key.Key == ConsoleKey.F3)
                    {
                        Console.WriteLine("Третья октава: ");
                        poop = Octave3;
                        return poop;
                    }
                    else if (Key.Key == ConsoleKey.F4)
                    {
                        Console.WriteLine("Четвертая октава: ");
                        poop = Octave4;
                        return poop;
                    }
                    else if (Key.Key == ConsoleKey.F5)
                    {
                        Console.WriteLine("Пятая октава");
                        poop = Octave5;
                        return poop;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Выбери октаву: F1, F2, F3, F4, F5 \n " +
                            "Клавиши: D, R, F, T, G, H, U, J, I, K, L");
                        return poop;
                    }
                }
                }
            }

        static int[] Sound(int[] lol)
        {
            int[] clavisha = new int[13];
            while (true)
            {
                ConsoleKey KeySound = Console.ReadKey().Key;
                switch (KeySound)
                {
                    case ConsoleKey.D:
                        Console.Beep(lol[0], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.R:
                        Console.Beep(lol[1], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.F:
                        Console.Beep(lol[2], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.T:
                        Console.Beep(lol[3], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.G:
                        Console.Beep(lol[4], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(lol[5], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.H:
                        Console.Beep(lol[6], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.U:
                        Console.Beep(lol[7], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.J:
                        Console.Beep(lol[8], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.I:
                        Console.Beep(lol[9], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.K:
                        Console.Beep(lol[10], 250);
                        Console.Clear();
                        continue;
                        break;
                    case ConsoleKey.L:
                        Console.Beep(lol[11], 250);
                        Console.Clear();
                        continue;
                        break;
              
                    case ConsoleKey.F1:
                        lol = Octave1;
                        return lol;
                        break;
                    case ConsoleKey.F2:
                        lol = Octave2;
                        return lol;
                        break;
                    case ConsoleKey.F3:
                        lol = Octave3;
                        return lol;
                        break;
                    case ConsoleKey.F4:
                        lol = Octave4;
                        return lol;
                        break;
                    case ConsoleKey.F5:
                        lol = Octave5;
                        return lol;
                        break;
                    default:
                        Console.Clear();
                        continue;
                        break;

                }
            }
        }
    }
    }






