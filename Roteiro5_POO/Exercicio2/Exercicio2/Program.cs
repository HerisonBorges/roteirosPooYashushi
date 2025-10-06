using System;


class Program
{
	static void Main()
	{
		Console.WriteLine("Digite uma frase: ");
		string frase = Console.ReadLine();
		string fraseLimpa = frase.Trim();

		Console.WriteLine("Frase.Trim: " + fraseLimpa);

		string[] palavras = fraseLimpa.Split(',');

		foreach (string palavra in palavras)
		{
			Console.Write($"[{palavra}]");

		}

		Console.WriteLine();

		string fraseNovaPalavra = fraseLimpa.Replace(palavras[4], "Thoor");
		Console.WriteLine("Frase.Replace:" + fraseNovaPalavra);

		bool comecaComOla = fraseLimpa.StartsWith("ola");
		Console.WriteLine($"Começa com ola? .StartsWith: {comecaComOla}");

		if (comecaComOla)
		{

			Console.WriteLine("Sim!");
		}

		bool terminaComHerison = fraseLimpa.EndsWith("Herison");
		if (terminaComHerison)
		{

			Console.WriteLine("Sim!");


		}
	}
}
