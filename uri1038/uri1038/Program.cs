/*
1038 - Lanche

Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir,
calcule e mostre o valor da conta a pagar.

Entrada
O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

Saída
O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        String[] var = Console.ReadLine().Split(' ');
        int lanche = int.Parse(var[0]);
        int quantidade = int.Parse(var[1]);

        double valor = 0;

        switch (lanche)
        {
            case 1:
                valor += 4.00;
                break;
            case 2:
                valor += 4.50;
                break;
            case 3:
                valor += 5.00;
                break;
            case 4:
                valor += 2.00;
                break;
            case 5:
                valor += 1.50;
                break;
        }
        valor *= quantidade;

        Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
    }
}