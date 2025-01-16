/*
1046 - Tempo de Jogo

Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e
terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

Entrada
A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.

Saída
Apresente a duração do jogo conforme exemplo abaixo.
*/

using System;

class URI
{

    static void Main(string[] args)
    {
        int inicio, termino, duracao = 0;

        string[] var = Console.ReadLine().Split(' ');
        inicio = int.Parse(var[0]);
        termino = int.Parse(var[1]);

        if (inicio > 24 || inicio < 0 || termino > 24 || termino < 0)
        {
            Console.WriteLine("INVALIDO");
        }
        else if (inicio == termino)
        {
            duracao = 24;
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
        else
        {
            if (termino < inicio)
            {
                duracao = (24 - inicio) + termino;
            }
            else
            {
                duracao = termino - inicio;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
