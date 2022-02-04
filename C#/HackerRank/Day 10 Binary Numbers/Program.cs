using System;

namespace Day_10_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          int n = Convert.ToInt32(Console.ReadLine().Trim());
          int reminder = 0;
          int count = 0;
          int max = 0;
        
          while(n>0)
          {
            reminder = n % 2;
            n /=2;
            
            if(reminder == 1)
            {
                count++;
                max = Math.Max(max,count);
            }
            else{
                count =0;
            }
          }
          Console.WriteLine(max);
        }
    }
}
