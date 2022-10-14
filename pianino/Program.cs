while (true)
{
    int[] octave1 = new int[] {261, 277, 293, 311, 329, 349, 370, 392 };
    int[] octave2 = new int[] {523, 554, 587, 622, 659, 698, 740, 784 };
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    if (key.Key == ConsoleKey.Z)
    {      
        xui(octave1);
        static void xui(int[] oct)
        {
            {
                sound(oct[0]);
            }
        }
    }
    if (key.Key == ConsoleKey.S)
    {
        xui(octave1);
        static void xui(int[] oct)
        {
            {
                sound(oct[1]);
            }
        }
    }
    if (key.Key == ConsoleKey.X)
    {
        xui(octave1);
        static void xui(int[] oct)
        {
            {
                sound(oct[2]);
            }
        }
    }
    if (key.Key == ConsoleKey.D)
    {
        xui(octave1);
        static void xui(int[] oct)
        {
            {
                sound(oct[3]);
            }
        }
    }
    if (key.Key == ConsoleKey.C)
    {
        xui(octave1);
        static void xui(int[] oct)
        {
            {
                sound(oct[4]);
            }
        }
    }
    if (key.Key == ConsoleKey.F)
    {
        xui(octave1);
        static void xui(int[] oct)
        {
            {
                sound(oct[5]);
            }
        }
    }
    if (key.Key == ConsoleKey.V)
    {
        xui(octave1);
        static void xui(int[] oct)
        {
            {
                sound(oct[6]);
            }
        }
    }
    if (key.Key == ConsoleKey.G)
    {
        xui(octave1);
        static void xui(int[] oct)
        {
            {
                sound(oct[7]);
            }
        }
    }
    if (key.Key == ConsoleKey.Q)
    {
        xui(octave2);
        static void xui(int[] oct)
        {
            {
                soun(oct[0]);
            }
        }
    }
    if (key.Key == ConsoleKey.W)
    {
        xui(octave2);
        static void xui(int[] oct)
        {
            {
                soun(oct[1]);
            }
        }
    }
    if (key.Key == ConsoleKey.E)
    {
        xui(octave2);
        static void xui(int[] oct)
        {
            {
                soun(oct[2]);
            }
        }
    }
    if (key.Key == ConsoleKey.R)
    {
        xui(octave2);
        static void xui(int[] oct)
        {
            {
                soun(oct[3]);
            }
        }
    }
    if (key.Key == ConsoleKey.T)
    {
        xui(octave2);
        static void xui(int[] oct)
        {
            {
                soun(oct[4]);
            }
        }
    }
    if (key.Key == ConsoleKey.Y)
    {
        xui(octave2);
        static void xui(int[] oct)
        {
            {
                soun(oct[5]);
            }
        }
    }
    if (key.Key == ConsoleKey.U)
    {
        xui(octave2);
        static void xui(int[] oct)
        {
            {
                soun(oct[6]);
            }
        }
    }
    if (key.Key == ConsoleKey.I)
    {
        xui(octave2);
        static void xui(int[] oct)
        {
            {
                soun(oct[7]);
            }
        }
    }
    if (key.Key == ConsoleKey.Escape)
    {
        break;
    }
    static void sound(int octave1)
    {
        Console.Beep(octave1, 250);
    }
    static void soun(int octave2)
    {
        Console.Beep(octave2, 250);
    }
}