using System.Collections.Generic;
using static System.Console;

public class Program
{
    public static void Main()
    {
        List<int> colecao = new List<int>();
        bool InserirNovaLinha = false;

        for (int i = 1; i <= 100; i++)
        {
            colecao.Add(i);
        }

        foreach (int item in colecao)
        {
            if(item % 3 == 0)
            {
                Write("Fizz");
                InserirNovaLinha = true;
            }

            if(item % 5 == 0)
            {
                Write("Buzz");
                InserirNovaLinha = true;
            }

            if(InserirNovaLinha)
            {
                Write(Environment.NewLine);
            }
        }

    }
}
