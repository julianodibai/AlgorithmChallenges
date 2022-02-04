using System;

namespace Day_12_Inheritance
{
    class Person
    {
	    protected string firstName;
	    protected string lastName;
	    protected int id;
	
	    public Person(){}
	    public Person(string firstName, string lastName, int identification)
        {
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	    }
	    public void printPerson()
        {
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	    }
    }
    class Student : Person
    {
        private int[] testScores;  
    
        public Student(string fn,string ln, int i,int[] sc):base(fn,ln,i)
        {       
           this.testScores = sc;
        }
    
        public char Calculate()
        {
           int sum = 0;
           int average = 0;
           
        
          for (int i = 0; i < testScores.Length; i++)
          {
              sum += testScores[i];
          }
           int lgth = testScores.Length;
           average = sum / lgth;
        
           if(average >= 90 && average <=100)
           {
               return 'O';
           }
           else if(average >= 80)
           {
               return 'E';
           }
           else if(average >= 70)
           {
               return 'A';
           }
           else if(average >= 55)
           {
               return 'P';
           }
           else if(average >= 40)
           {
               return 'D';
           }
           else if(average <40)
           {
               return 'T';
           }
           return 'X';
        }
    }
    class Solution 
    {
	    static void Main() 
        {
		   string[] inputs = Console.ReadLine().Split();
		   string firstName = inputs[0];
	  	   string lastName = inputs[1];
		   int id = Convert.ToInt32(inputs[2]);
		   int numScores = Convert.ToInt32(Console.ReadLine());
		   inputs = Console.ReadLine().Split();
	       int[] scores = new int[numScores];

	       for(int i = 0; i < numScores; i++)
           {
		   scores[i]= Convert.ToInt32(inputs[i]);
		   } 
	  	
	       Student s = new Student(firstName, lastName, id, scores);
		   s.printPerson();
		   Console.WriteLine("Grade: " + s.Calculate() + "\n");
	    }
    }
 
}
