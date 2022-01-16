using System;

namespace Desafio_SequenciaS
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, S = 1;
            for (int i = 2; i <= 100; i ++)
            {
                c = 1.0 / i;
                S += c;
            }
            var x = Math.Round(S, 2);
            Console.WriteLine(x);
         }
    }
}
