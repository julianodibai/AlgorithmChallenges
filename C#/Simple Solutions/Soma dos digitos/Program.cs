public class Program
{
    static void Main()
    {
        int n = 55; 
        int sum = 0;

        for (int i = n; i > 0; i = i / 10)
        {   
            sum = sum + i % 10;
        }

    }
}

