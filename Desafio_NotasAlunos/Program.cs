using System;
using System.Globalization;

namespace Desafio_NotasAlunos
{
    class Program
    {

        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.Clear();

            /*
            Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno.
            Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". 
            Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.".
            Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.".
            Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

            No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno.
            Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada.
            Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2) e imprima a mensagem 
            "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). 
            Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem 
            "Media final: " seguido da média final para esse aluno.
            */
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            double a, b, c, d, avg;

            string[] values = Console.ReadLine().Split();
            // string[] values = new string[5] { "2.0", "4.0", "7.5", "8.0", "6.4" };  // exemplo 1
            // string[] values = new string[5] { "2.0", "6.5", "4.0", "9.0", "0.0" };  // exemplo 2
            // string[] values = new string[5] { "9.0", "4.0", "8.5", "9.0", "0.0" };  // exemplo 3
            // string[] values = new string[5] { "2.0", "4.0", "7.5", "8.0", "2.2" };  // teste 1
            // string[] values = new string[5] { "0.0", "9.9", "10.0", "0.0", "5.1" };  // teste 2
            // string[] values = new string[5] { "1.0", "10.0", "10.0", "0.0", "0.0" };  // teste 3
            // string[] values = new string[5] { "10.0", "10.0", "0.0", "0.0", "4.9" };  // teste 4

            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);
            d = double.Parse(values[3]);
            //e = double.Parse(values[4]);

            avg = ((a * 2) + (b * 3) + (c * 4) + (d * 1)) / 10;
            Console.WriteLine("Media: " + avg.ToString("N1"));
            if (avg >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (avg < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (avg <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double e = double.Parse(Console.ReadLine());
                avg = (avg + e) / 2;
                Console.WriteLine("Nota do exame: " + e.ToString("N1"));
                if (avg >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: " + avg.ToString("N1"));
            }
            Console.ReadKey();
        }
    }
}
