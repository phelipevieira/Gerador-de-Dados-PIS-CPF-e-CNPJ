﻿using System;

namespace Gerador_de_PIS
{
    class GeradorPIS
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de PIS a ser gerado:");
            int numGerar = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < numGerar; i++)
            {

                int n1 = 1;
                int n2 = 2;
                int n3 = rnd.Next(5, 10);
                int n4 = rnd.Next(10);
                int n5 = rnd.Next(10);
                int n6 = rnd.Next(10);
                int n7 = rnd.Next(10);
                int n8 = rnd.Next(10);
                int n9 = rnd.Next(10);
                int n10 = rnd.Next(10);

                int somatorio = (n1 * 3) + (n2 * 2) + (n3 * 9) + (n4 * 8) + (n5 * 7) + (n6 * 6) + (n7 * 5) + (n8 * 4) + (n9 * 3) + (n10 * 2);
                int resto = (somatorio % 11);
                int resultado = 0;
                if (resto > 1)
                {
                    resultado = 11 - resto;
                };

                string numeroPuro = string.Concat(n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, resultado);
                Console.WriteLine(numeroPuro);
            };
            Console.ReadLine();
        }
    }
}

