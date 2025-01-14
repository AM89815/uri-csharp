/*
1010 - Cálculo Simples

Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$".
O valor deverá ser apresentado com 2 casas após o ponto.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int codigoPeca1, numPeca1, codigoPeca2, numPeca2;
        double precoPeca1, precoPeca2, precoTotal;

        string[] vetPeca1 = Console.ReadLine().Split(' ');
        codigoPeca1 = Convert.ToInt32(vetPeca1[0]);
        numPeca1 = Convert.ToInt32(vetPeca1[1]);
        precoPeca1 = Convert.ToDouble(vetPeca1[2], CultureInfo.InvariantCulture);

        string[] vetPeca2 = Console.ReadLine().Split(' ');
        codigoPeca2 = Convert.ToInt32(vetPeca2[0]);
        numPeca2 = Convert.ToInt32(vetPeca2[1]);
        precoPeca2 = Convert.ToDouble(vetPeca2[2], CultureInfo.InvariantCulture);

        precoTotal = (numPeca1 * precoPeca1) + (numPeca2 * precoPeca2);

        Console.WriteLine("VALOR A PAGAR: R$ " + (precoTotal).ToString("F2", CultureInfo.InvariantCulture));
    }

}