/*
1144 - Sequência Lógica

Escreva um programa que leia um valor inteiro N. N * 2 linhas de saída serão apresentadas na execução do programa,
seguindo a lógica do exemplo abaixo. Para valores com mais de 6 dígitos, todos os dígitos devem ser apresentados.

Entrada
O arquivo de entrada contém um número inteiro positivo N (1 < N < 1000).

Saída
Imprima a saída conforme o exemplo fornecido.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int coluna1 = i;
            int coluna2 = i * i;
            int coluna3 = i * i * i;
            Console.WriteLine($"{coluna1} + {coluna2} + {coluna3}");
            Console.WriteLine($"{coluna1} + {coluna2 + 1} + {coluna3 + 1}");
        }
    }
}