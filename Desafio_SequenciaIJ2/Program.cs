using System;

namespace Desafio_SequenciaIJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            for(int i = 1; i <= 9; i = i + 2)
            {
                j = 7;
                for(int ii = 1; ii <= 3; ii++)
                {
                    Console.WriteLine($"I={i} J={j--}");
                }
            }
        }
    }
}
