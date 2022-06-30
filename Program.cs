using System;
using static System.Console;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("x = 3 << 2;");
            WriteLine("y = 10 >> 1;");

            int x = 3 << 2;
            int y = 10 >> 1;
            WriteLine($"x = {x} и y = {y}");
            WriteLine();

        }
    }
}

