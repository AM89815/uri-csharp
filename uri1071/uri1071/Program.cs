/*
1071 - Soma de Impares Consecutivos I

Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.

Entrada
O arquivo de entrada contém dois valores inteiros.

Saída
O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares
que estão entre os valores fornecidos na entrada que deverá caber em um inteiro
*/

using System;

class URI
{
    static void Main(string[] args)
    {
        int X, Y, menor, maior, soma = 0;

        X = Convert.ToInt32(Console.ReadLine());
        Y = Convert.ToInt32(Console.ReadLine());

        menor = Math.Min(X, Y);
        maior = Math.Max(X, Y);

        for (int i = menor + 1; i < maior; ++i)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
    }
}