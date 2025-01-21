/*
1045 - Tipos de Triângulos

Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados.
A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

Entrada
A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

Saída
Imprima todas as classificações do triângulo especificado na entrada.
*/

using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double A, B, C, temp;

        String[] var = Console.ReadLine().Split(' ');
        A = double.Parse(var[0]);
        B = double.Parse(var[1]);
        C = double.Parse(var[2]);

        if (0.0 < A && 0.0 < B && 0.0 < C)
        {
            if (A < B) { temp = A; A = B; B = temp; }
            if (A < C) { temp = A; A = C; C = temp; }
            if (B < C) { temp = B; B = C; C = temp; }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if ((A == B && B != C) || (B == C && C != A) || (C == A && A != B))
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
        else
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
    }
}