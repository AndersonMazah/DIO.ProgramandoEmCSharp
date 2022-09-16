/*
Desafio
Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos. Caso contrário, retorne false. O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 

Entrada
O arquivo de entrada consiste em um inteiro n que será validada caso esteja sob as condições do desafio.

Saída
A saída consistirá em um tipo booleano: true ou false. Como nos exemplos a baixo:

Exemplo 1:
    Exemplo de Entrada                      |   Exemplo de Saída
2                                           | false
Explicação: 2 possui apenas dois divisores: 1 e 2.


Exemplo 2:
    Exemplo de Entrada                      |   Exemplo de Saída
4                                           | true
Explicação: 4 tem três divisores: 1, 2 e 4.


*/

using System;

public static class Solution
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count == 3);
    }
}