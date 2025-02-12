/*
1153 - Factoial Simples

Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.

Entrada
A entrada contém um valor inteiro N (0 < N < 13).

Saída
A saída contém um valor inteiro, correspondente ao fatorial de N.
*/

using System;

class URI
{
    static void Main(string[] args)
    {
        int N, factoral = 1;

        N = Convert.ToInt32(Console.ReadLine());

        if (0 < N && N < 13)
        {
            for (int i = 1; i <= N; i++)
            {
                factoral *= i;
            }
            Console.WriteLine(factoral);
        }
    }
}