/*
1004 - Produto Simples

Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
A seguir mostre a variável PROD com mensagem correspondente.   

Entrada
O arquivo de entrada contém 2 valores inteiros.

Saída
Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade. Não esqueça de imprimir o fim de linha após o produto,
caso contrário seu programa apresentará a mensagem: “Presentation Error”.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());

        int prod = valor1 * valor2;

        Console.WriteLine("PROD = " + prod);
    }

}