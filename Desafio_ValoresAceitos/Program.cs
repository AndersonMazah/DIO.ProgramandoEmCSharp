using System;

namespace Desafio_ValoresAceitos
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Leia 4 valores inteiros A, B, C e D.
                - se o valor de B for maior do que de C -> ok
                - se D for maior do que A -> ok
                - se a soma de C com D for maior que a soma de A e B -> ok
                - se tanto C quanto D forem positivos -> ok
                - se a variável A for par -> ok
                se tudo der OK, então, escreva a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".
                testes:
                    5 6 7 8 => Valores nao aceitos
                    2 3 2 6 => Valores aceitos
            */

            string[] selections = Console.ReadLine().Split(' ');
            int a = int.Parse(selections[0]);
            int b = int.Parse(selections[1]);
            int c = int.Parse(selections[2]);
            int d = int.Parse(selections[3]);

            // Implemente a condição abaixo para ter o resultado esperado
            if (
                    ValidarSeBmaiorQueC(b, c) && ValidarSeDmaiorQueA(d, a) &&
                    ValidarSeSomaCDmaiorQueSomaAB(c, d, a, b) && ValidarSeCeDsaoPositivos(c, d) && ValidarSeAPah(a))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }

        // se o valor de B for maior do que de C
        public static bool ValidarSeBmaiorQueC(int b, int c)
        {
            return b > c;
        }
        // se D for maior do que A
        public static bool ValidarSeDmaiorQueA(int d, int a)
        {
            return d > a;
        }
        //se a soma de C com D for maior que a soma de A e B -> ok
        public static bool ValidarSeSomaCDmaiorQueSomaAB(int c, int d, int a, int b)
        {
            return (c + d) > (a + b);
        }
        // se tanto C quanto D forem positivos
        public static bool ValidarSeCeDsaoPositivos(int c, int d)
        {
            return (c >= 0) && (d >= 0);
        }
        //se a variável A for par
        public static bool ValidarSeAPah(int a)
        {
            return (a % 2 == 0);
        }
    }
}
