using System;

namespace Desafio_AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:
                - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.
            
            Entrada
                A entrada contém um valor de ponto flutuante (dupla precisão), no caso, a variável raio.
            
            Saída
                Apresentar a mensagem "A=" seguido pelo valor da variável area, conforme exemplo abaixo, com 4 casas após o ponto decimal.
                Utilize variáveis de dupla precisão (double).
                Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".
            */

            const double PI = 3.14159;
            double raio = Math.Round(double.Parse(Console.ReadLine()), 2);
            double area = Math.Pow(raio, 2) * PI;
            System.Console.WriteLine($"A={area.ToString("0.0000")}");
        }
    }
}
