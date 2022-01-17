using System;

namespace Desafio_VaiTerCopa
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc;
            while((opc = Console.ReadLine()) != null)
            {
                int x;
                if(int.TryParse(opc, out x))
                {
                    if(x == 0) {
                        Console.WriteLine("vai ter copa!");
                    }
                    else
                    {
                        Console.WriteLine("vai ter duas!");
                    }
                }
            }
        }
    }
}
