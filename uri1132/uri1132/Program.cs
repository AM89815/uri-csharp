﻿/*
1132 - Múltiplos de 13

Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos números que não são múltiplos de 13 entre X e Y, incluindo ambos.

Entrada
O arquivo de entrada contém 2 valores inteiros quaisquer, não necessariamente em ordem crescente.

Saída
Imprima a soma de todos os valores não divisíveis por 13 entre os dois valores lidos na entrada, inclusive ambos se for o caso.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int X, Y, menorNum, maiorNum, numFinal = 0;

        X = Convert.ToInt32(Console.ReadLine());
        Y = Convert.ToInt32(Console.ReadLine());

        menorNum = Math.Min(X, Y);
        maiorNum = Math.Max(X, Y);

        for (int i = menorNum; i <= maiorNum; i++)
        {
            if (i % 13 != 0)
            {
                numFinal += i;
            }
        }
        Console.WriteLine(numFinal);
    }
}