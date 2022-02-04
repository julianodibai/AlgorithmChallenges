using System;

namespace Day_16_Exceptions___String_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
             string str = Console.ReadLine();
        
            try
            {
                var i = int.Parse(str);
                Console.WriteLine(i);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
