using System;

namespace Desafio_Xenlongao
{
    class Program
    {
        static void Main(string[] args)
        {
            // quantidade de casos de testes
            int C = Convert.ToInt32(Console.ReadLine());
            while(C-- > 0)
            {
                // pega a quantidade de esferas a serem testadas
                int val = Convert.ToInt32(Console.ReadLine());
                int newval = (int)Math.Sqrt(val);
                int resposta = val - newval;
                Console.WriteLine(resposta);                
            }
        }
    }
}
