/*
1014 - Consumo

Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km) e o total de combustível gasto (em litros).

Entrada
O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km),
e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.

Saída
Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".
*/

using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int X;
        double Y;

        X = Convert.ToInt32(Console.ReadLine());
        Y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double XY = X / Y;

        Console.WriteLine((XY).ToString("F3", CultureInfo.InvariantCulture) + " km/l");
    }

}