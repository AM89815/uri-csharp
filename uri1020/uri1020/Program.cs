/*
1020 - Idade em dias

Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.
Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

Entrada
O arquivo de entrada contém um valor inteiro.

Saída
Imprima a saída conforme exemplo fornecido.
*/

using System;

class URI
{
    static void Main(string[] args)
    {
        int entrada = Convert.ToInt32(Console.ReadLine());

        int anos = entrada / 365;
        int restoAnos = entrada % 365;

        int meses = restoAnos / 30;
        int restoMeses = restoAnos % 30;

        int dias = restoMeses / 1;

        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es)");
        Console.WriteLine(dias + " dia(s)");
    }
}