using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(number(2, 1));
            Console.WriteLine(number(2, 3));
            Console.WriteLine(number(2, 2));
            Console.ReadLine();
        }

        private static int number(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}