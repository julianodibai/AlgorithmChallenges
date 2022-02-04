using System;
using System.IO;


namespace Day_9_Recursion_3
{
    class Program
    {
          public static int factorial(int n)
          {
            if (n==1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n-1);
            }
          }
        static void Main(string[] args)
        {

          int n = Convert.ToInt32(Console.ReadLine().Trim());

          int result = factorial(n);

          Console.WriteLine(result);    
        }
    }
}
