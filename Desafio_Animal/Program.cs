using System;

namespace Desafio_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.
            Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.

            Entrada
                A entrada contém 3 palavras, uma em cada linha, necessárias para identificar o animal segundo a figura acima, com todas as letras minúsculas.

            Saída
                Imprima o nome do animal correspondente à entrada fornecida.
            */
            String animal1;
            String animal2;
            String animal3;

            animal1 = Console.ReadLine();
            animal2 = Console.ReadLine();
            animal3 = Console.ReadLine();

            if ((animal1 == "vertebrado") && (animal2 == "ave") && (animal3 == "carnivoro"))
            {
                Console.WriteLine("aguia");
            }

            if ((animal1 == "vertebrado") && (animal2 == "ave") && (animal3 == "onivoro"))
            {
                Console.WriteLine("pomba");
            }

            if ((animal1 == "vertebrado") && (animal2 == "mamifero") && (animal3 == "onivoro"))
            {
                Console.WriteLine("homem");
            }

            if ((animal1 == "vertebrado") && (animal2 == "mamifero") && (animal3 == "herbivoro"))
            {
                Console.WriteLine("vaca");
            }

            if ((animal1 == "invertebrado") && (animal2 == "inseto") && (animal3 == "hematofago"))
            {
                Console.WriteLine("pulga");
            }

            if ((animal1 == "invertebrado") && (animal2 == "inseto") && (animal3 == "herbivoro"))
            {
                Console.WriteLine("lagarta");
            }

            if ((animal1 == "invertebrado") && (animal2 == "anelideo") && (animal3 == "hematofago"))
            {
                Console.WriteLine("sanguessuga");
            }

            if ((animal1 == "invertebrado") && (animal2 == "anelideo") && (animal3 == "onivoro"))
            {
                Console.WriteLine("minhoca");
            }

        }
    }
}
