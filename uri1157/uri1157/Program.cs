/*
1157 - Divisores

Ler um número inteiro N e calcular todos os seus divisores.

Entrada
O arquivo de entrada contém um valor inteiro.

Saída
Escreva todos os divisores positivos de N, um valor por linha.
*/

using System;

class URi
{

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            if (N % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
