using System;
using System.Runtime.CompilerServices;

class Carro
{
	private string Modelo { get; set; }
	private double velocidadeAtual { get; set; }


	public double getvelocidadeAtual
	{
		get { return velocidadeAtual; }
	}

	public void setvelocidadeAtual(double novaVelocidade)
	{
		if (novaVelocidade < 0)
		{
			Console.WriteLine("Velocidade não pode ser negativa.");
		}
		else
		{
			velocidadeAtual = novaVelocidade;
		}
	}

	public void acelerar(int valor)
	{
		if (valor < 0)
		{
			Console.WriteLine("Valor de aceleração não pode ser negativo.");
		}
		else
		{
			velocidadeAtual += valor;
		}
	}

	public Carro(String Modelo)
	{
		this.Modelo = Modelo;

	}


	public void frear(int valor)
	{
		if (valor < 0)
		{
			Console.WriteLine("Valor de frenagem não pode ser negativo.");
		}
		else
		{
			velocidadeAtual -= valor;
			if (velocidadeAtual < 0)
			{
				velocidadeAtual = 0;
			}
		}
	}
}

class Program3
{
	public static void Main()
	{
		Carro c = new Carro("Ferrari");
		c.acelerar(50);
		Console.WriteLine(c.getvelocidadeAtual); // Deve exibir 50
		c.frear(30);
		Console.WriteLine(c.getvelocidadeAtual); // Deve exibir 20
		c.frear(50);
	}
}
