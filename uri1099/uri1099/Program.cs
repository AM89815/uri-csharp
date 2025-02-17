/*
1099 - Soma de Ímpares Consecutivos II

Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y.
Você deve apresentar a soma de todos os ímpares existentes entre X e Y.

Entrada
A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir.
Cada caso de teste consiste em uma linhacontendo dois inteiros X e Y.

Saída
Imprima a soma de todos valores ímpares entre X e Y.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int X, Y, maior, menor, somaImpares = 0;

            string[] var = Console.ReadLine().Split(' ');
            X = int.Parse(var[0]);
            Y = int.Parse(var[1]);

            menor = Math.Min(X, Y);
            maior = Math.Max(X, Y);

            for (int j = menor + 1; j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    somaImpares += j;
                }
            }
            Console.WriteLine(somaImpares);
        }
    }
}