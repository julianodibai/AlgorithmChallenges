using System;
using System.Collections.Generic;
using System.Linq;

namespace Soma_de_divisores
{
    class Program
    {
      public static int DivisorSum(int n)
      {
        var sum =0;
        
        for(var i= 1; i <= n; i++)
        {
            if(n % i ==0)
            {
                sum += i;
            }
        }
        return sum;
      }
      public static void DivisorAll(int n)
      {
        List<int> lista = new List<int>();

        for(var i= 1; i <= n; i++)
        {
            if(n % i ==0)
            {
                lista.Add(i);
            }
        }
        Console.Write($"Divisores de {n}: ");
        foreach (var item in lista)
        {
            Console.Write(item + " ");
        }     
                
      }
    
      
      
        static void Main(string[] args)
        {
            int num = 25;

            Console.WriteLine($"Soma dos divisores de {num}: {DivisorSum(num)}"); // 1+5+25 = 31
            DivisorAll(num);

        }
    }
}
