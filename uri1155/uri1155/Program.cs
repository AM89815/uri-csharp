/*
1155 - Sequência S

Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double S = 0.0;

        for (int i = 1; i <= 100; i++)
        {
            S += 1.0 / i;
        }
        Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
    }
}