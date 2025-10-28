using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numerosUnicos = new HashSet<int>();

        Console.WriteLine("Digite números inteiros (Digite 0 para parar)");

        while (true)
        {
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
                break;

            if (numerosUnicos.Add(numero))
            {
                Console.WriteLine("Número adicionado!");
            }
            else
            {
                Console.WriteLine("Número duplicado.");
            }
        }

        Console.WriteLine("\nNúmeros únicos digitados:");
        foreach (int n in numerosUnicos)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("\nFim.");
    }
}


