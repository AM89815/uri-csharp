﻿/*
1048 - Aumento de Salário

A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

Salário	Percentual de Reajuste
0 - 400.00-----------------15%
400.01 - 800.00------------12%
800.01 - 1200.00-----------10%
1200.01 - 2000.00----------7%
Acima de 2000.00-----------4%

Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.

Entrada
A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

Saída
Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste (ambos devem ser apresentados com 2 casas decimais) e
o percentual de reajuste ganho, conforme exemplo abaixo.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double salario, reajuste;
        int percentual;

        salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario <= 400.00)
        {
            percentual = 15;
        }
        else if (salario <= 800.00)
        {
            percentual = 12;
        }
        else if (salario <= 1200.00)
        {
            percentual = 10;
        }
        else if (salario <= 2000.00)
        {
            percentual = 7;
        }
        else if (salario > 2000.00)
        {
            percentual = 4;
        }
        else
        {
            percentual = 0;
        }

        reajuste = (percentual * salario) / 100;
        salario += reajuste;

        Console.WriteLine("Novo salario: " + (salario).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + (reajuste).ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + (percentual) + " %");
    }
}