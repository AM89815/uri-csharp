/*
1015 - Distância Entre Dois Pontos

Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles,
mostrando 4 casas decimais, segundo a fórmula:

Distancia = Math.Sqrt(Math.Pow(2, (x2 - x1) + Math.Pow(2, (y2 - y1))

Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args) {

        double x1, y1, x2, y2;

        string[] p1 = Console.ReadLine().Split(' ');
        x1 = Convert.ToDouble(p1[0], CultureInfo.InvariantCulture);
        y1 = Convert.ToDouble(p1[1], CultureInfo.InvariantCulture);

        string[] p2 = Console.ReadLine().Split(' ');
        x2 = Convert.ToDouble(p2[0], CultureInfo.InvariantCulture);
        y2 = Convert.ToDouble(p2[1], CultureInfo.InvariantCulture);

        double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

        Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
    }

}