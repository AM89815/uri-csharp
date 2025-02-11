/*
1080 - Maior e Posição

Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída
Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int numero, maiorNum = 0, posicaoMaiorNum = 0;

        for (int i = 1; i <= 100; i++)
        {
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > maiorNum)
            {
                maiorNum = numero;
                posicaoMaiorNum = i;
            }
        }
        Console.WriteLine(maiorNum);
        Console.WriteLine(posicaoMaiorNum);
    }
}