/*
1145 - Sequência Lógica 2

Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

Entrada
O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

Saída
Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número,
conforme exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int X, Y, X2;

        string[] var = Console.ReadLine().Split(' ');
        X = int.Parse(var[0]);
        Y = int.Parse(var[1]);

        X2 = X;

        if ((1 < X && X < 20) && (X < Y && Y < 100000))
        {
            for (int i = 1; i <= Y; i++)
            {
                Console.Write(i);

                if (i + 1 <= X)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.WriteLine();
                    X += X2;
                }
            }
        }
    }
}