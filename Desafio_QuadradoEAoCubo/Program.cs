using System;

namespace Desafio_QuadradoEAoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Desafio
            Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000).
            Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

            Entrada
                O arquivo de entrada contém um número inteiro positivo N.

            Saída
                Imprima a saída conforme o exemplo fornecido.
            */
            string text = Console.ReadLine();
            int n;
            if (!int.TryParse(text, out n))
                Environment.Exit(0);

            int inicio = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{inicio} {inicio * inicio} {inicio * inicio * inicio}");
                inicio++;
            }
        }
    }
}
