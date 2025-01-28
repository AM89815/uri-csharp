/*
1047 - Tempo de Jogo com Minutos

Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

Entrada
Quatro números inteiros representando a hora de início e fim do jogo.

Saída
Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .
*/

using System;

class URI
{
    static void Main(string[] args)
    {
        string[] var = Console.ReadLine().Split(' ');
        int horasInicio = int.Parse(var[0]);
        int minutosInicio = int.Parse(var[1]);
        int horasTermino = int.Parse(var[2]);
        int minutosTermino = int.Parse(var[3]);

        int inicioTotal = horasInicio * 60 + minutosInicio;
        int terminoTotal = horasTermino * 60 + minutosTermino;

        int duracaoMinutos = terminoTotal - inicioTotal;

        if (duracaoMinutos <= 0)
        {
            duracaoMinutos += 24 * 60;
        }

        int duracaoHoras = duracaoMinutos / 60;
        duracaoMinutos = duracaoMinutos % 60;

        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", duracaoHoras, duracaoMinutos);
    }
}