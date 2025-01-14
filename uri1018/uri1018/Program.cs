/*
1018 - Cédulas

Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto.
As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.
Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
*/

using System;

class URI
{
    static void Main(string[] args)
    {
        int entrada = Convert.ToInt32(Console.ReadLine());

        int notas100 = entrada / 100;
        int resto100 = entrada % 100;

        int notas50 = resto100 / 50;
        int resto50 = resto100 % 50;

        int notas20 = resto50 / 20;
        int resto20 = resto50 % 20;

        int notas10 = resto20 / 10;
        int resto10 = resto20 % 10;

        int notas5 = resto10 / 5;
        int resto5 = resto10 % 5;

        int notas2 = resto5 / 2;
        int resto2 = resto5 % 2;
            
        int notas1 = resto2 / 1;

        Console.WriteLine(entrada);
        Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
        Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
        Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
        Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
        Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
        Console.WriteLine(notas2 + " nota(s) de R$ 2,00");
        Console.WriteLine(notas1 + " nota(s) de R$ 1,00");
    }
}