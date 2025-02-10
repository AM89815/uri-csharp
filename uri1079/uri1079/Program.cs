/*
1079 - Médias Ponderadas

Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais,
cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores,
sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

Entrada
O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um caso de
teste com três valores com uma casa decimal cada valor.

Saída
Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {

            double N1, N2, N3, media;

            string[] var = Console.ReadLine().Split(' ');
            N1 = Convert.ToDouble(var[0], CultureInfo.InvariantCulture);
            N2 = Convert.ToDouble(var[1], CultureInfo.InvariantCulture);
            N3 = Convert.ToDouble(var[2], CultureInfo.InvariantCulture);

            media = ((N1 * 2.0) + (N2 * 3.0) + (N3 * 5.0)) / 10.0;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}