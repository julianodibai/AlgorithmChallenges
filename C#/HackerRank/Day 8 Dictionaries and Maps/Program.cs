using System;
using System.Collections.Generic;

namespace Day_8_Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
           var phoneBook = new Dictionary<string, string>();

           for (int i = 0; i < n; i++)
           {
               string[] s = Console.ReadLine().Split(' ');
               string name = s[0];
               string number = s[1];

               phoneBook.Add(name, number);
           }
           string searchName ="";     
           while ((searchName = Console.ReadLine()) != null)
           {
               if(phoneBook.ContainsKey(searchName))
               {
                   Console.WriteLine(searchName +"="+ phoneBook[searchName]);
               }
               else
               {
                   Console.WriteLine("Not found");
               }
           }
        }      
    }
}
