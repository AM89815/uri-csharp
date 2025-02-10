/*
1072 - Intervalo 2

Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.

Entrada
A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 

Saída
Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.
*/

using System;

class URI
{
    static void Main(string[] args)
    {
        int N, dentro = 0, fora = 0;

        N = Convert.ToInt32(Console.ReadLine());

        if (N < 10000)
        {
            for (int i = 1; i <= N; ++i)
            {
                int teste = Convert.ToInt32(Console.ReadLine());

                if (teste >= 10 && teste <= 20)
                {
                    ++dentro;
                }
                else
                {
                    ++fora;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}