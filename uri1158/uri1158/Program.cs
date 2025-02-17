/*
1158 - Soma de ímpares Consecutivos III

Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y.
Você deve apresentar a soma de Y ímpares consecutivos a partir de X inclusive o próprio X se ele for ímpar. Por exemplo:
para a entrada 4 5, a saída deve ser 45, que é equivalente à: 5 + 7 + 9 + 11 + 13
para a entrada 7 4, a saída deve ser 40, que é equivalente à: 7 + 9 + 11 + 13

Entrada
A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.

Saída
Imprima a soma dos consecutivos números ímpares a partir do valor X.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int X, Y, soma = 0, j = 0;

            string[] var = Console.ReadLine().Split(' ');
            X = int.Parse(var[0]);
            Y = int.Parse(var[1]);

            while (j < Y)
            {
                if (X % 2 != 0)
                {
                    soma += X;
                    j++;
                }
                X++;
            }
            Console.WriteLine(soma);
        }
    }
}