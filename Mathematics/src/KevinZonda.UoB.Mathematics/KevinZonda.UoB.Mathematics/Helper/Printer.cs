using System;

namespace KevinZonda.UoB.Mathematics.Helper
{
    public class Printer
    {
        public static int Width { get; set; } = 32;

        public static void PrintTitle(string title)
        {
            Console.WriteLine();
            PrintHead();
            Console.WriteLine($" *  {title}");
            PrintTail();
        }
        
        public static void PrintTitle(string[] titles)
        {
            Console.WriteLine();
            PrintHead();
            foreach (var title in titles)
            {
                Console.WriteLine($" *  {title}");
            }

            PrintTail();
        }

        private static void PrintHead()
        {
            Console.Write("/");
            for (int i = 1; i < Width; ++i)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
        private static void PrintTail()
        {
            Console.Write(" ");
            for (int i = 2; i < Width; ++i)
            {
                Console.Write("*");
            }
            Console.WriteLine("/");
        }
    }
}