using System;

namespace Desafio_PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Desafio
            Desenvolva um programa que leia um valor inteiro N. Este N refere-se à quantidade de linhas de saída que serão apresentadas na execução do programa.

            Entrada
            O arquivo de entrada contém um número inteiro positivo N.

            Saída
            Imprima a saída conforme o exemplo fornecido.
            */
            int N = int.Parse(Console.ReadLine());

            int primeiro = 1;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"{primeiro++} ");
                }
                primeiro++;
                Console.Write("PUM\n");
            }
        }
    }
}
