using System;

internal class Programm
{
    static void Main(string[] args)
    {
        while (true)
        {
            int[] mhz = Octave(1);
            Console.WriteLine("Нажми либо F1 F2 F3 \n");
            ConsoleKeyInfo Ef = Console.ReadKey();
            if (Ef.Key == ConsoleKey.F1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("LETS GOOOOOOOOOOOOOOOOOOOOO\n");
                    Ef = Console.ReadKey();
                    if (Ef.Key == ConsoleKey.C)
                    {
                        Beep(mhz[0]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.C)
                    {
                        Beep(mhz[1]);
                    }
                    if (Ef.Key == ConsoleKey.D)
                    {
                        Beep(mhz[2]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.E)
                    {
                        Beep(mhz[3]);
                    }
                    if (Ef.Key == ConsoleKey.E)
                    {
                        Beep(mhz[4]);
                    }
                    if (Ef.Key == ConsoleKey.F)
                    {
                        Beep(mhz[5]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.F)
                    {
                        Beep(mhz[6]);
                    }
                    if (Ef.Key == ConsoleKey.G)
                    {
                        Beep(mhz[7]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.G)
                    {
                        Beep(mhz[8]);
                    }
                    if (Ef.Key == ConsoleKey.A)
                    {
                        Beep(mhz[9]);
                    }
                    if (Ef.Key == ConsoleKey.B)
                    {
                        Beep(mhz[10]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.B)
                    {
                        Beep(mhz[11]);
                    }
                    Console.Clear();
                    if (Ef.Key == ConsoleKey.F2)
                    {
                        break;
                    }
                    if (Ef.Key == ConsoleKey.F3)
                    {
                        break;
                    }
                    if (Ef.Key == ConsoleKey.L)
                    {
                        
                    }
                } while (Ef.Key != ConsoleKey.F1 && Ef.Key != ConsoleKey.F2 && Ef.Key != ConsoleKey.F3 && Ef.Key != ConsoleKey.Escape);
                }
            if (Ef.Key == ConsoleKey.F2)
            {
                int[] mhz2 = Octave(2);
                do
                {
                    Console.Clear();
                    Console.WriteLine("LETS GOOOOOOOOOOOOOOOOOO\n");
                    Ef = Console.ReadKey();
                    if (Ef.Key == ConsoleKey.C)
                    {
                        Beep2(mhz2[0]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.C)
                    {
                        Beep2(mhz2[1]);
                    }
                    if (Ef.Key == ConsoleKey.D)
                    {
                        Beep2(mhz2[2]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.E)
                    {
                        Beep2(mhz2[3]);
                    }
                    if (Ef.Key == ConsoleKey.E)
                    {
                        Beep2(mhz2[4]);
                    }
                    if (Ef.Key == ConsoleKey.F)
                    {
                        Beep2(mhz2[5]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.F)
                    {
                        Beep2(mhz2[6]);
                    }
                    if (Ef.Key == ConsoleKey.G)
                    {
                        Beep2(mhz2[7]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.G)
                    {
                        Beep2(mhz2[8]);
                    }
                    if (Ef.Key == ConsoleKey.A)
                    {
                        Beep2(mhz2[9]);
                    }
                    if (Ef.Key == ConsoleKey.B)
                    {
                        Beep2(mhz2[10]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.B)
                    {
                        Beep2(mhz2[11]);
                    }
                    Console.Clear();
                    if (Ef.Key == ConsoleKey.F2)
                    {
                        break;
                    }
                    if (Ef.Key == ConsoleKey.F3)
                    {
                        break;
                    }
                    if (Ef.Key == ConsoleKey.L)
                    {
                        
                    }
                } while (Ef.Key != ConsoleKey.F1 && Ef.Key != ConsoleKey.F2 && Ef.Key != ConsoleKey.F3 && Ef.Key != ConsoleKey.Escape);
                
            }
            if (Ef.Key == ConsoleKey.F3)
            {
                int[] mhz3 = Octave(3);
                do
                {
                    Console.Clear();
                    Console.WriteLine("LETS GOOOOOOOOOOOOOOOO\n");
                    Ef = Console.ReadKey();
                    if (Ef.Key == ConsoleKey.C)
                    {
                        Beep3(mhz3[0]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.C)
                    {
                        Beep3(mhz3[1]);
                    }
                    if (Ef.Key == ConsoleKey.D)
                    {
                        Beep3(mhz3[2]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.E)
                    {
                        Beep3(mhz3[3]);
                    }
                    if(Ef.Key == ConsoleKey.E);
                        {
                        Beep3(mhz3[4]);
                    }
                    if (Ef.Key == ConsoleKey.F)
                    {
                        Beep3(mhz3[5]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.F)
                    {
                        Beep3(mhz3[6]);
                    }
                    if (Ef.Key == ConsoleKey.G)
                    {
                        Beep3(mhz3[7]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.G)
                    {
                        Beep3(mhz3[8]);
                    }
                    if (Ef.Key == ConsoleKey.A)
                    {
                        Beep3(mhz3[9]);
                    }
                    if (Ef.Key == ConsoleKey.B)
                    {
                        Beep3(mhz3[10]);
                    }
                    if (Ef.Modifiers.HasFlag(ConsoleModifiers.Alt) && Ef.Key == ConsoleKey.B)
                    {
                        Beep3(mhz3[11]);
                    }
                    Console.Clear();
                    if (Ef.Key == ConsoleKey.F2)
                    {
                        break;
                    }
                    if (Ef.Key == ConsoleKey.F3)
                    {
                        break;
                    }
                    if (Ef.Key == ConsoleKey.L)
                    {
                       
                    }
                } while (Ef.Key != ConsoleKey.F1 && Ef.Key != ConsoleKey.F2 && Ef.Key != ConsoleKey.F3 && Ef.Key != ConsoleKey.Escape);
            }

            if (Ef.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("ПОШЕЛ ВОН");
                Console.ReadLine();
                break;
            }
        }


    }

    static void Beep(int mhz)
    {
        Console.Beep(mhz, 1000);

    }
    static void Beep2(int mhz2)
    {
        Console.Beep(mhz2, 1000);
    }
    static void Beep3(int mhz3)
    {
        Console.Beep(mhz3, 1000);
    }

    static int[] Octave(int octave)
    {
        int[] first_octavka1 = { 300, 305, 145, 652, 629, 561, 467, 175, 475, 933, 156, 367 };
        int[] second_octav = { 124, 322, 22, 763, 08, 156, 9655, 563, 576, 11, 33, 65 };
        int[] third_octav = { 436, 17, 19, 765, 134, 835,  8455, 1565, 90, 50, 1072 };
        
        if (octave == 1)
        {
            return first_octavka1;
        }
        else if (octave == 2)
        {
            return second_octav;
        }
        else
        {
            return third_octav;
        }
    }
}