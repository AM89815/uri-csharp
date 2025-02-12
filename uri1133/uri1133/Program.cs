/*
1133 - Resto de Divisão

Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.

Entrada
O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.

Saída
Imprima todos os valores conforme exemplo abaixo, sempre em ordem crescente.
*/

using System;

class URi
{

    static void Main(string[] args)
    {
        int X, Y, menorNum, maiorNum;

        X = Convert.ToInt32(Console.ReadLine());
        Y = Convert.ToInt32(Console.ReadLine());

        menorNum = Math.Min(X, Y);
        maiorNum = Math.Max(X, Y);

        for (int i = menorNum + 1; i < maiorNum; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}