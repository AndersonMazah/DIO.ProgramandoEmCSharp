/*
    Ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0.
    Para cada D lido:
        - imprima a soma dos 5 pares consecutivos a partir de D,
        - inclusive ele mesmo, se for par.
    Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12
    Enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.
*/

string? text;
int x, par, somaPar;
do
{
    text = Console.ReadLine();

    if (!(int.TryParse(text, out x)) || (x == 0))
        break;
    par = 0;
    somaPar = 0;
    for (int i = 1; i <= 5; i++)
    {
        par = ProximoNrPar(x);
        somaPar += par;
        x = par + 1;
    }
    Console.WriteLine(somaPar);

} while (true);
Environment.Exit(0);

static int ProximoNrPar(int nr)
{
    while (nr % 2 != 0)
        nr++;
    return nr;
}