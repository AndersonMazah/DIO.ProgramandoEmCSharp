using System;

public static class DIO
{
    static void Main(string[] args)
    {
        int nrEntrada = int.Parse(Console.ReadLine());
        int produtoDigitos = 1, somaDigitos = 0;
        int resultado;
        while (nrEntrada > 0)
        {
            int digito = nrEntrada % 10;
            produtoDigitos *= digito;
            somaDigitos += digito;
            nrEntrada /= 10;
        }
        resultado = produtoDigitos - somaDigitos;
        Console.WriteLine(resultado);
    }
}

/* PROJETO QUE FOI ENTREGUE NO PORTAL DA DIO.
    using System;

    public static class DIO {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 1, s = 0;
            while (n > 0)
            {
            int l = n % 10;
            p *= l;
            s += l;
            n /= 10;
            }
            Console.WriteLine(p-s);
        }
    }
*/