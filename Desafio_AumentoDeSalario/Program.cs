/* 
Desafio
    A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

        Salário     |   Percentual de Reajuste
       0 - 400.00   |       15%
  400.01 - 800.00   |       12%
 800.01 - 1200.00   |       10%
1200.01 - 2000.00   |        7%
 Acima de 2000.00   |        4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

Entrada
    A entrada contém apenas um valor de ponto flutuante, que pode ser maior ou igual a zero, com duas casas decimais.

Saída
    Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.

    Exemplo de Entrada  |	Exemplo de Saída
----------------------------------------------------
        400.00          |   Novo salario:  460.00
                        |   Reajuste ganho: 60.00
                        |   Em percentual:     15 %
----------------------------------------------------
        800.01          |   Novo salario:  880.01
                        |   Reajuste ganho: 80.00
                        |   Em percentual:     10 %
----------------------------------------------------
       2000.00          |   Novo salario:  2140.00
                        |   Reajuste ganho: 140.00
                        |   Em percentual:       7 %
----------------------------------------------------
*/
using System;
using System.Globalization;

public static class minhaClasse
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
        decimal salario = 0.00M;
        decimal reajuste = 0.00M;
        decimal novoSalario = 0.00M;
        decimal percentual = 0.00M;

        salario = decimal.Parse(Console.ReadLine());

        if (salario < 0)
        {
            return;
        }
        else if (salario <= 400M)
        {
            percentual = 15;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        else if (salario <= 800M)
        {
            percentual = 12;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        else if (salario <= 1200M)
        {
            percentual = 10;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        else if (salario <= 2000M)
        {
            percentual = 7;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        else
        {
            percentual = 4;
            reajuste = salario * percentual * 0.01M;
            novoSalario = salario + reajuste;
        }
        Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
        Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
        Console.WriteLine("Em percentual: {0} %", percentual);
    }
}


/* DESAFIO ORIGINAL (A RESOLVER)
using System;  

class minhaClasse { 

  static void Main(string[] args) {  

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 

//TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    if( < ) { 
      return; 

    } else if ( <= ) { 
      percentual = ; 
      reajuste =  ; 
      novoSalario =   ; 


    } else if (     <= ) { 
      percentual =   ; 
      reajuste =  ;         
      novoSalario = ; 

    } else if (    <= ) { 
      percentual = ; 
      reajuste =  ; 
      novoSalario = ; 

    } else if (   <= ) { 
      percentual =  ; 
      reajuste =   ; 
      novoSalario =  ; 

    } else { 
      percentual = ; 
      reajuste = ; 
      novoSalario = ; 

    } 

    Console.WriteLine("Novo salario: {0:0.00}",              ); 
    Console.WriteLine("Reajuste ganho: {0:0.00}",             ); 
    Console.WriteLine("Em percentual: {0} %", percentual *     ); 

  } 
*/








