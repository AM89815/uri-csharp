/*
1154 - Idades

Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, que não entrará nos cálculos,
contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.

Entrada
A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.

Saída
A saída contém um valor correspondente à média de idade dos indivíduos.

A média deve ser impressa com dois dígitos após o ponto decimal.
*/

using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int idade, idadeTotal = 0, individuos = 0;
        double media;

        idade = Convert.ToInt32(Console.ReadLine());

        while (idade >= 0)
        {
            idadeTotal += idade;
            individuos++;
            idade = Convert.ToInt32(Console.ReadLine());
        }
        media = (double)idadeTotal / (double)individuos;
        Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
    }
}