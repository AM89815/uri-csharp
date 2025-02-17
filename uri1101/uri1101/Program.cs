/*
1101 - Sequência de Números e Soma

Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero).
Para cada par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).

Entrada
O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.

Saída
Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.
*/

using System;
using System.Runtime.Serialization;

class URI
{

    static void Main(string[] args)
    {
        int M = 1, N = 1;

        while (M > 0 && N > 0)
        {
            string[] var = Console.ReadLine().Split(' ');
            M = int.Parse(var[0]);
            N = int.Parse(var[1]);

            if (M > 0 && N > 0)
            {
                int menor, maior, soma = 0;

                menor = Math.Min(M, N);
                maior = Math.Max(M, N);

                for (int i = menor; i <= maior; i++)
                {
                    if (i != menor || i != maior)
                    {
                        soma += i;
                    }
                    Console.Write($"{i} ");
                }
                Console.Write($"Sum={soma}");
                Console.WriteLine();
            }
        }
    }
}