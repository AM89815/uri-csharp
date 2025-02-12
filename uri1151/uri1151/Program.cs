/*
1151 - Fibonacci Fácil

A seguinte sequência de números 0 1 1 2 3 5 8 13 21... é conhecida como série de Fibonacci. Nessa sequência, cada número, depois dos 2 primeiros,
é igual à soma dos 2 anteriores. Escreva um algoritmo que leia um inteiro N (N < 46) e mostre os N primeiros números dessa série.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 46).

Saída
Os valores devem ser mostrados na mesma linha, separados por um espaço em branco. Não deve haver espaço após o último valor.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int N, primeiroNum = 1, segundoNum = 1, terceiroNum = 2;

        N = Convert.ToInt32(Console.ReadLine());

        if (0 < N && N < 46)
        {
            if (N >= 1)
            {
                Console.Write("0");
            }
            if (N >= 2)
            {
                Console.Write($" {primeiroNum}");
            }
            if (N >= 3)
            {
                Console.Write($" {segundoNum}");
            }
            if (N > 3)
            {
                for (int i = 3; i < N; i++)
                {
                    terceiroNum = primeiroNum + segundoNum;
                    Console.Write($" {terceiroNum}");
                    primeiroNum = segundoNum;
                    segundoNum = terceiroNum;
                }
            }
            Console.WriteLine();
        }
    }
}