
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_7_Arrays
{
    class Program
    {
        static void ReversePrint(List<int> arr)
        {

         for (int i = arr.Count -1; i >=0; i--)
         {
             if(i != 0)
             {
                 Console.Write(arr[i] + " ");
             }
             else
             {
                 Console.Write(arr[i]);
             }
             
         }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            
            ReversePrint(arr);
        }

    }
}
