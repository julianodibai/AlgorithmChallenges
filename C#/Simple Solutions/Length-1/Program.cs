using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
     
        static void Main(string[] args)
        {
           
           List<int> list =  new List<int>() {1,2,3,4,5};                    
           
           for (int i = list.Count-1; i>=0; i--)
           {
            Console.WriteLine($"index {i} = {list[i]}");
           }
           

        }
    }
}
