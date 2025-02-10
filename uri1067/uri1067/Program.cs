/*
1067 - Números ímpares

Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

Entrada
O arquivo de entrada contém 1 valor inteiro qualquer.

Saída
Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int count = 1;

        int X = Convert.ToInt32(Console.ReadLine());

        if (X >= 1 && X <= 1000)
        {
            while (count <= X)
            {
                if (count % 2 != 0)
                {
                    Console.WriteLine(count);
                }
                count++;
            }
        }
    }
}
