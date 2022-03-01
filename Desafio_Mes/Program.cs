using System;

namespace Desafio_Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia um valor inteiro entre 1 e 12, inclusive. Correspondente a este valor, deve ser apresentado como resposta o mês do ano por extenso, 
            em inglês, com a primeira letra maiúscula.

            Entrada
                A entrada contém um único valor inteiro.

            Saída
                Imprima por extenso o nome do mês correspondente ao número existente na entrada, com a primeira letra em maiúscula.
            */
            string text = Console.ReadLine();
            int month;
            if (!(int.TryParse(text, out month)) || (month < 1 || month > 12))
            {
                Console.WriteLine("Digite um número válido de 1 a 12");
                Environment.Exit(0);
            }
            Month name;
            name = (Month)month;
            Console.WriteLine(name);
            Console.ReadLine();
        }

        public enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
}

