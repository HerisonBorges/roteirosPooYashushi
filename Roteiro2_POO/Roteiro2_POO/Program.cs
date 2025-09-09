using System;

public class Produto
{
	public string Nome { get; set; }

	private double preco { get; set; }

	public double getPreco
	{
		get { return preco; }


	}

	public void setPreco(double valor)
	{

		if (valor < 0)
		{
			Console.WriteLine("Preço não pode ser negativo. Valor ignorado.");
		}
		else
		{
			preco = valor;
		}

	}

	public Produto(string nome, double preco)
	{
		this.Nome = nome;
		this.preco = preco;


	}

	public void ExibirDetalhes()
	{
		Console.WriteLine($"{Nome}, R$ {preco:F2}");
	}
}

class Program2
{
	public static void Main()
	{
		Produto p = new Produto("Celular", 1500);
		p.ExibirDetalhes();
		p.setPreco(-200);
	}
}
