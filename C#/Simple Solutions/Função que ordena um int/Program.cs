using System;

namespace Função_que_ordena_um_int
{
    class Program
    {
        public static int ReorderInt(int num)
        { 
            int numAbs = Math.Abs(num);
            int log = ((int)Math.Log10(numAbs > 0 ? numAbs : 1))+1;
            int[] arrInt = new int[log];

            for (int i = 0; i < log; i++)
            {
                arrInt[(log -i) -1] = numAbs % 10;
                numAbs /= 10;
            }
            if (num < 0)
                  
                arrInt[0] *= -1;
                Array.Sort(arrInt);
                Array.Reverse(arrInt);

                int result = 0;
            
             for (int i = 0; i < arrInt.Length; i++)
             {
                 int index = arrInt.Length -i -1;
                 result += ((int)Math.Pow(10, index)) * arrInt[i];               
             }
            
            
            return result;
        }
        static void Main(string[] args)
        {
            int n = 12345;

            Console.WriteLine(ReorderInt(n));
        }
    }
}
