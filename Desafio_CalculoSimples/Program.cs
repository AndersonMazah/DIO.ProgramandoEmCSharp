using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Neste problema, deve-se:
                - ler o código de uma peça 1;
                - o número de peças 1;
                - o valor unitário de cada peça 1;
                - o código de uma peça 2;
                - o número de peças 2;
                - o valor unitário de cada peça 2;
                Após, calcule e mostre o valor a ser pago.
            */
            string[] input;
            input = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(input[0]);
            int n1 = int.Parse(input[1]);
            double valor1 = double.Parse(input[2]);
            //Escreva sua lógica nos espaços em branco
            input = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(input[0]);
            int n2 = int.Parse(input[1]);
            double valor2 = double.Parse(input[2]);

            double total = (n1 * valor1) + (n2 * valor2);
            Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
        }
    }
}