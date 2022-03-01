using System;

namespace Desafio_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:      
            1 x N = N      2 x N = 2N        ...       10 x N = 10N

            Entrada
                A entrada contém um valor inteiro N (2 < N < 1000).

            Saída
                Imprima a tabuada de N, conforme o exemplo fornecido.            
            */
            int n = int.Parse(Console.ReadLine());
            int valor = 0;

            for (int i = 1; i <= 10; i++)
            {
                valor = i * n;
                Console.WriteLine($"{i} x {n} = {valor}");
            }
        }
    }
}
