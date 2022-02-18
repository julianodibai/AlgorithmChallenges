using System;
using static System.Console;

namespace DIO2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int D = int.Parse(ReadLine());
                int armazemD = D;
                int soma = 0;

                if(D % 2 == 0)
                {
                    soma += D;
                }
                else
                {
                    armazemD = D+1;
                    soma += armazemD;
                }

                for (int i = 1; i < 5; i++)
                {
                    armazemD += 2;
                    soma += armazemD;
                }

                if(D == 0)
                    break;

                WriteLine(soma);
                soma = 0;    
            }

        }
    }
}