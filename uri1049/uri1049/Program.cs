/*
1049 - Animal

Neste problema, você deverá ler 3 palavras que definem o tipo de animal possível segundo o esquema abaixo, da esquerda para a direita.
Em seguida conclua qual dos animais seguintes foi escolhido, através das três palavras fornecidas.
*/

using System;

class URI {

    static void Main(string[] args)
    {
        string tipo1 = Console.ReadLine();
        string tipo2 = Console.ReadLine();
        string tipo3 = Console.ReadLine();

        if (tipo1 == "vertebrado")
        {
            if (tipo2 == "ave")
            {
                if (tipo3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                if (tipo3 == "onivoro")
                {
                    Console.WriteLine("pomba");
                }
            }
            if (tipo2 == "mamifero")
            {
                if (tipo3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                if (tipo3 == "herbivoro")
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        if (tipo1 == "invertebrado")
        {
            if (tipo2 == "inseto")
            {
                if (tipo3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                if (tipo3 == "herbivoro")
                {
                    Console.WriteLine("lagarta");
                }
            }
            if (tipo2 == "anelideo")
            {
                if (tipo3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                if (tipo3 == "onivoro")
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }   
}