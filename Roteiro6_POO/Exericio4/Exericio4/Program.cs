using System;

public class indadeInvalidaExeption : Exception
{
	public indadeInvalidaExeption(string message) : base(message)
	{

	}
}

class Program
{
	public static void verificarIdade(int idade)
	{
		if (idade < 18)
		{

			throw new indadeInvalidaExeption("Erro! Idade minima 18 anos. ");
		}

		Console.WriteLine("Acesso permitido! ");

	}

	static void Main()
	{
		Console.WriteLine("Informe a sua idade: ");
		string idadeString = Console.ReadLine();

		try
		{

			int idade = int.Parse(idadeString);
			Console.WriteLine("Idade convertida. ");

			verificarIdade(idade);
			Console.WriteLine("Idade valida! ");
		}
		catch (indadeInvalidaExeption ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (FormatException ex)
		{

			Console.WriteLine("A idade deve ser um inteiro " + ex.Message);

		}
	}
}