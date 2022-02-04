using System;

namespace Day_13_Abstract_Classes
{
   abstract class Book
   {
    
      protected String title;
      protected  String author;
    
      public Book(String t,String a)
      {
         title=t;
         author=a;
      }
      public abstract void display();
   }
   class MyBook : Book
   {
      public int price =0;
    
      public MyBook(string title, string author, int myPrice):base(title, author)
      {
         price = myPrice;
      }
      public override void display()
      {
         Console.WriteLine($"Title: {title}");
         Console.WriteLine($"Author: {author}");
         Console.WriteLine($"Price: {price}");
      }
   }
    class Solution 
    {
        static void Main(String[] args)
        {
             String title=Console.ReadLine();
             String author=Console.ReadLine();
             int price=Int32.Parse(Console.ReadLine());

             Book new_novel=new MyBook(title,author,price);
             new_novel.display();
        }
    }
}
