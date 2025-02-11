/*
1116 - Dividindo X por Y

Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo.
Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

Entrada
A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

Saída
Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

Obs.: Cuide que a divisão entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int repeat = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < repeat; i++)
        {
            string[] var = Console.ReadLine().Split(' ');
            int X = Convert.ToInt32(var[0]);
            int Y = Convert.ToInt32(var[1]);

            double resultado = (double)X / (double)Y;

            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            }
            else {
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}