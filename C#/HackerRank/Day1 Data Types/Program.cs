using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
         int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        string c = Console.ReadLine();

        


        Console.WriteLine(i+a);
        Console.WriteLine((d+b).ToString("f1"));
        Console.WriteLine(s+c);
        }
    }
}
