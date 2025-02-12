/*
1142 - PUM

Escreva um programa que leia um valor inteiro N. Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int pums, linhas;

        linhas = Convert.ToInt32(Console.ReadLine());

        for (int i = pums = 0; i < linhas; i++, pums++)
        {
            Console.Write((++pums) + " ");
            Console.Write((++pums) + " ");
            Console.Write((++pums) + " ");
            Console.Write("PUM");
            Console.WriteLine();
        }
    }
}