using System;
using static System.Console;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(ReadLine());

            for (int i = 1; i <= num; i++)
            {
                WriteLine($"{i} {i*i} {i*i*i}");
            }

        }
    }
}