using System.Globalization;
using System;

namespace Desafio_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo.
            Em caso positivo, calcule o perímetro do triângulo (soma de todos os lados) e apresente a mensagem:

            Perimetro = XX.X

            Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem:

            Area = XX.X

            Fórmula da área de um trapézio: AREA = ((A + B) x C) / 2

            Entrada
                A entrada contém três valores reais.

            Saída
                O resultado deve ser apresentado com uma casa decimal.
            */

            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            double perimetro, area;
            if (a < b + c && b < a + c && c < a + b)
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((a + b) * c) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
