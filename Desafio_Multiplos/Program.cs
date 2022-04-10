using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Leia 2 valores inteiros (A e B).
            Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.
            */
            int A = 0;
            int B = 0;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B))
            {
                if (A % B == 0 || B % A == 0)
                {
                    Console.WriteLine($"Sao Multiplos");
                }
                else
                {
                    Console.WriteLine($"Nao sao Multiplos");
                }
            }
        }
    }
}