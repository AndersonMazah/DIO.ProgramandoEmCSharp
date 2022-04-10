using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Leia quatro valores inteiros A, B, C e D.
            A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)
            */
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            if (
            int.TryParse(Console.ReadLine(), out A) &&
            int.TryParse(Console.ReadLine(), out B) &&
            int.TryParse(Console.ReadLine(), out C) &&
            int.TryParse(Console.ReadLine(), out D))
            {
                Console.WriteLine($"DIFERENCA = {(A * B) - (C * D)}");
                Console.ReadKey();
            }
        }
    }
}