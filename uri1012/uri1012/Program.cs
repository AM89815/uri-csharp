/*
1012 - Esfera

Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.

Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e
um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double A, B, C;

        string[] vet = Console.ReadLine().Split(' ');
        A = Convert.ToDouble(vet[0], CultureInfo.InvariantCulture);
        B = Convert.ToDouble(vet[1], CultureInfo.InvariantCulture);
        C = Convert.ToDouble(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine("TRIANGULO: " + ((A * C) / 2).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + (3.14159 * Math.Pow(C, 2)).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + (((A + B) * C) / 2).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + (B * B).ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + (A * B).ToString("F3", CultureInfo.InvariantCulture));
    }

}