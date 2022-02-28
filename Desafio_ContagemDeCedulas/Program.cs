using System;

namespace Desafio_ContagemDeCedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Desafio
            Faça a leitura de um valor inteiro.
            Em seguida, calcule o menor número de notas possíveis (cédulas) onde o valor pode ser decomposto.
            As notas que você deve considerar são de 100, 50, 20, 10, 5, 2 e 1. Na sequência mostre o valor lido e a relação de notas necessárias.

            Entrada
            Você receberá um valor inteiro N (0 < N < 1000000).

            Saída
            Exiba o valor lido e a quantidade mínima de notas de cada tipo necessárias, seguindo o exemplo de saída abaixo.
            Após cada linha deve ser imprimido o fim de linha.
            */
            int n, resto;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            resto = n;
            CalcularCedulas(ref resto, 100);
            CalcularCedulas(ref resto, 50);
            CalcularCedulas(ref resto, 20);
            CalcularCedulas(ref resto, 10);
            CalcularCedulas(ref resto, 5);
            CalcularCedulas(ref resto, 2);
            CalcularCedulas(ref resto, 1);
        }
        public static void CalcularCedulas(ref int valor, int nota)
        {
            int quociente = valor / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            valor = valor % nota;
        }
    }
}
