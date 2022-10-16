namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение между октавами F1, F2, F3, F4, F5 \nTAB - Смена октав");
            Change_Octave();
        }

        static void Change_Octave()
        {
            while (true)
            {
                ConsoleKeyInfo change = Console.ReadKey();
                if (change.Key == ConsoleKey.F1)
                {
                    octave1_();
                }

                if (change.Key == ConsoleKey.F2)
                {
                    octave2_();
                }

                if (change.Key == ConsoleKey.F3)
                {
                    octave3_();
                }

                if (change.Key == ConsoleKey.F4)
                {
                    octave4_();
                }

                if (change.Key == ConsoleKey.F5)
                {
                    octave5_();
                }
            }
        }


        static void octave1_()
        {
            Console.WriteLine("Первая октава");
            int[] Octave1 = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            ConsoleKeyInfo button = Console.ReadKey();
            while (true)
            {
                if (button.Key == ConsoleKey.Q)
                {
                    Console.Beep(Octave1[0], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.W)
                {
                    Console.Beep(Octave1[1], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.E)
                {
                    Console.Beep(Octave1[2], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.R)
                {
                    Console.Beep(Octave1[3], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.T)
                {
                    Console.Beep(Octave1[4], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.Y)
                {
                    Console.Beep(Octave1[5], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.U)
                {
                    Console.Beep(Octave1[6], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.I)
                {
                    Console.Beep(Octave1[7], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.O)
                {
                    Console.Beep(Octave1[8], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.P)
                {
                    Console.Beep(Octave1[9], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.A)
                {
                    Console.Beep(Octave1[10], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.S)
                {
                    Console.Beep(Octave1[11], 500);
                    Console.Clear();
                }

                button = Console.ReadKey();
                if (button.Key == ConsoleKey.Tab)
                {
                    Change_Octave();
                }
            }

        }

        static void octave2_()
        {
            Console.WriteLine("Вторая октава");
            int[] Octave2 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            ConsoleKeyInfo button = Console.ReadKey();
            while (true)
            {
                if (button.Key == ConsoleKey.D)
                {
                    Console.Beep(Octave2[0], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.F)
                {
                    Console.Beep(Octave2[1], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.G)
                {
                    Console.Beep(Octave2[2], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.H)
                {
                    Console.Beep(Octave2[3], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.J)
                {
                    Console.Beep(Octave2[4], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.K)
                {
                    Console.Beep(Octave2[5], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.L)
                {
                    Console.Beep(Octave2[6], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.Z)
                {
                    Console.Beep(Octave2[7], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.X)
                {
                    Console.Beep(Octave2[8], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.C)
                {
                    Console.Beep(Octave2[9], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.V)
                {
                    Console.Beep(Octave2[10], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.B)
                {
                    Console.Beep(Octave2[11], 500);
                    Console.Clear();
                }

                button = Console.ReadKey();
                if (button.Key == ConsoleKey.Tab)
                {
                    Change_Octave();
                }
            }
        }

        static void octave3_()
        {
            Console.WriteLine("Третья октава");
            int[] Octave3 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987};
            ConsoleKeyInfo button = Console.ReadKey();
            while (true)
            {
                if (button.Key == ConsoleKey.Q)
                {
                    Console.Beep(Octave3[0], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.W)
                {
                    Console.Beep(Octave3[1], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.E)
                {
                    Console.Beep(Octave3[2], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.R)
                {
                    Console.Beep(Octave3[3], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.T)
                {
                    Console.Beep(Octave3[4], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.Y)
                {
                    Console.Beep(Octave3[5], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.U)
                {
                    Console.Beep(Octave3[6], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.I)
                {
                    Console.Beep(Octave3[7], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.O)
                {
                    Console.Beep(Octave3[8], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.P)
                {
                    Console.Beep(Octave3[9], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.A)
                {
                    Console.Beep(Octave3[10], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.S)
                {
                    Console.Beep(Octave3[11], 500);
                    Console.Clear();
                }

                button = Console.ReadKey();
                if (button.Key == ConsoleKey.Tab)
                {
                    Change_Octave();
                }
            }

        }
        static void octave4_()
        {
            Console.WriteLine("Четвёртая октава");
            int[] Octave4 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            ConsoleKeyInfo button = Console.ReadKey();
            while (true)
            {
                if (button.Key == ConsoleKey.Q)
                {
                    Console.Beep(Octave4[0], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.W)
                {
                    Console.Beep(Octave4[1], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.E)
                {
                    Console.Beep(Octave4[2], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.R)
                {
                    Console.Beep(Octave4[3], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.T)
                {
                    Console.Beep(Octave4[4], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.Y)
                {
                    Console.Beep(Octave4[5], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.U)
                {
                    Console.Beep(Octave4[6], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.I)
                {
                    Console.Beep(Octave4[7], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.O)
                {
                    Console.Beep(Octave4[8], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.P)
                {
                    Console.Beep(Octave4[9], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.A)
                {
                    Console.Beep(Octave4[10], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.S)
                {
                    Console.Beep(Octave4[11], 500);
                    Console.Clear();
                }

                button = Console.ReadKey();
                if (button.Key == ConsoleKey.Tab)
                {
                    Change_Octave();
                }
            }

        }
        static void octave5_()
        {
            Console.WriteLine("Пятая октава");
            int[] Octave5 = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            ConsoleKeyInfo button = Console.ReadKey();
            while (true)
            {
                if (button.Key == ConsoleKey.Q)
                {
                    Console.Beep(Octave5[0], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.W)
                {
                    Console.Beep(Octave5[1], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.E)
                {
                    Console.Beep(Octave5[2], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.R)
                {
                    Console.Beep(Octave5[3], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.T)
                {
                    Console.Beep(Octave5[4], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.Y)
                {
                    Console.Beep(Octave5[5], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.U)
                {
                    Console.Beep(Octave5[6], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.I)
                {
                    Console.Beep(Octave5[7], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.O)
                {
                    Console.Beep(Octave5[8], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.P)
                {
                    Console.Beep(Octave5[9], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.A)
                {
                    Console.Beep(Octave5[10], 500);
                    Console.Clear();
                }

                if (button.Key == ConsoleKey.S)
                {
                    Console.Beep(Octave5[11], 500);
                    Console.Clear();
                }

                button = Console.ReadKey();
                if (button.Key == ConsoleKey.Tab)
                {
                    Change_Octave();
                }
            }

        }
    }
}