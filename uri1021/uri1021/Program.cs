/*
1021 - Notas e Moedas

Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário.
A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.
As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01.
A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.
*/

using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double entrada = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        int valor = (int)(entrada * 100);

        int notas100 = valor / 10000;
        valor %= 10000;

        int notas50 = valor / 5000;
        valor %= 5000;

        int notas20 = valor / 2000;
        valor %= 2000;

        int notas10 = valor / 1000;
        valor %= 1000;

        int notas5 = valor / 500;
        valor %= 500;

        int notas2 = valor / 200;
        valor %= 200;

        int moedas1 = valor / 100;
        valor %= 100;

        int moedas050 = valor / 50;
        valor %= 50;

        int moedas025 = valor / 25;
        valor %= 25;

        int moedas010 = valor / 10;
        valor %= 10;

        int moedas005 = valor / 5;
        valor %= 5;

        int moedas001 = valor;

        Console.WriteLine("NOTAS:");
        Console.WriteLine(notas100 + " nota(s) de R$ 100.00");
        Console.WriteLine(notas50 + " nota(s) de R$ 50.00");
        Console.WriteLine(notas20 + " nota(s) de R$ 20.00");
        Console.WriteLine(notas10 + " nota(s) de R$ 10.00");
        Console.WriteLine(notas5 + " nota(s) de R$ 5.00");
        Console.WriteLine(notas2 + " nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine(moedas1 + " moeda(s) de R$ 1.00");
        Console.WriteLine(moedas050 + " moeda(s) de R$ 0.50");
        Console.WriteLine(moedas025 + " moeda(s) de R$ 0.25");
        Console.WriteLine(moedas010 + " moeda(s) de R$ 0.10");
        Console.WriteLine(moedas005 + " moeda(s) de R$ 0.05");
        Console.WriteLine(moedas001 + " moeda(s) de R$ 0.01");
    }
}