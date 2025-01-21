﻿/*
1041 - Coordenadas de um Ponto

Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir,
determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

Entrada
A entrada contem as coordenadas de um ponto.

Saída
A saída deve apresentar o quadrante em que o ponto se encontra.
*/

using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double X, Y;
        String[] var = Console.ReadLine().Split(' ');
        X = double.Parse(var[0], CultureInfo.InvariantCulture);
        Y = double.Parse(var[1], CultureInfo.InvariantCulture);

        if (X == 0.0 && Y == 0.0)
        {
            Console.WriteLine("Origem");
        }
        else if (X == 0.0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (Y == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (X > 0.0 && Y > 0.0)
        {
            Console.WriteLine("Q1");
        }
        else if (X < 0.0 && Y > 0.0)
        {
            Console.WriteLine("Q2");
        }
        else if (X < 0.0 && Y < 0.0)
        {
            Console.WriteLine("Q3");
        }
        else if (X > 0.0 && Y < 0.0)
        {
            Console.WriteLine("Q4");
        }
        else
        {
            Console.WriteLine("Como isso foi parar ai?");
        }
    } 
}