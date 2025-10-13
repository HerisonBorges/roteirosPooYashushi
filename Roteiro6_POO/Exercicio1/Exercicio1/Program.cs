using System;
using System.Linq.Expressions;

class Program
{
	static void Main()
	{
		
		Console.WriteLine("Digite o nome do produto: ");
		string nomeProduto = Console.ReadLine();
		Console.WriteLine("Digite o preço do produto: ");
		string precoProdutoString = Console.ReadLine();

		try
		{
			if (string.IsNullOrWhiteSpace(nomeProduto))
			{
				throw new ArgumentException("O nome do produto não pode estar vazio");
			}

			double preco = double.Parse(precoProdutoString);

			if (preco <= 0)
			{
				throw new ArgumentException("O preço é menor que zero");
			}
		}
		catch (ArgumentException ex)
		{

			Console.WriteLine("Erro: " + ex.Message);

		}catch (FormatException ex)
		{
			Console.WriteLine("O preço deve ser um valor numerico");


		}



	}
}