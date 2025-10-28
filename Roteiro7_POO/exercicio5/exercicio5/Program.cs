using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Console.Write("Digite uma palavra: ");
		string palavra = Console.ReadLine();

		Stack<char> pilha = new Stack<char>();

		foreach (char caractere in palavra)
		{
			pilha.Push(caractere);
		}

		string invertida = "";
		while (pilha.Count > 0)
		{
			invertida += pilha.Pop();
		}

		Console.WriteLine($"\nPalavra invertida: {invertida}");
	}
}
