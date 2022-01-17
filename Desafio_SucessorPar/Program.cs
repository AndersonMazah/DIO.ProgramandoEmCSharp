using System;

namespace Desafio_SucessorPar
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc = Console.ReadLine();
            if(int.TryParse(opc, out int x))
            {
                while(true) {
                    x++;
                    if(x % 2 == 0)
                    {
                        Console.WriteLine(x);
                        break;
                    }
                }
            }
            
        }
    }
}
