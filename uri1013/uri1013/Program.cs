/*
1013 - O Maior

Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:

a + b + abs(a - b) / 2

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int A, B, C, maiorNumAb, maiorNum;

        string[] vet = Console.ReadLine().Split(' ');
        A = Convert.ToInt32(vet[0]);
        B = Convert.ToInt32(vet[1]);
        C = Convert.ToInt32(vet[2]);

        maiorNumAb = ((A + B + Math.Abs(A - B)) / 2);
        maiorNum = ((maiorNumAb + C + Math.Abs(maiorNumAb - C)) / 2);

        Console.WriteLine(maiorNum + " eh o maior");
    }
}