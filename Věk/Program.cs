using System;

namespace Věk
{
    class Program
    {
        static void Main(string[] args)
        {
            double rok_narozeni;
            double vek;

            Console.CursorVisible = false;
            Console.SetCursorPosition (10, 10);
            Console.WriteLine();
            Console.SetCursorPosition(10, 11);
            Console.WriteLine(" Kolik ti je let?");
            double.TryParse(Console.ReadLine(), out rok_narozeni);
            Console.SetCursorPosition(10, 12);
            Console.WriteLine();
            Console.ReadLine();

                

        }





      


        }
    }

