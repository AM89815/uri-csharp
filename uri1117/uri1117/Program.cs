﻿/*
1117 - Validação de Nota

Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral.
Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

Entrada
A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo.
O valor deve ser apresentado com duas casas após o ponto decimal.
*/

using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double nota1, nota2, media;

        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (nota1 < 0 || nota1 > 10.0)
        {
            Console.WriteLine("nota invalida");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (nota2 < 0 || nota2 > 10.0)
        {
            Console.WriteLine("nota invalida");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        media = ((nota1 + nota2) / 2);

        Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}