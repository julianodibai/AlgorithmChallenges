using System;

namespace Day_6_Let_s_Review
{
    class Program
    {
        static void LetsReview (string s)
        {
            string strEven = "";
            string strOdd  = "";

            for (int i = 0; i < s.Length ; i++)
            {
                if(i % 2 == 0)
                {
                    strEven += s[i];
                }
                else
                {
                    strOdd += s[i];
                    
                }
            }
            Console.WriteLine($"{strEven} {strOdd}");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                LetsReview(s);

            }
            
        }
    }
}
