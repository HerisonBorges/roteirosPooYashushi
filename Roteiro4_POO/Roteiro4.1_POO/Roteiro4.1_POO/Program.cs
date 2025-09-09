using System;

abstract class Funcionario
{
	public string Nome { get; set; }
	public int Dias { get; set; }
	public double Horas { get; set; }

	public abstract double CalcularSalario();
}

class Gerente : Funcionario
{
	public override double CalcularSalario()
	{
		return Dias * Horas * 100;
	}
}

class Programador : Funcionario
{
	public override double CalcularSalario()
	{
		return Dias * Horas * 50;
	}
}

class Program
{
	static void Main()
	{
		Gerente gerente = new Gerente();
		gerente.Nome = "João";
		gerente.Dias = 20;
		gerente.Horas = 8;

		Programador programador = new Programador();
		programador.Nome = "Herison";
		programador.Dias = 20;
		programador.Horas = 8;

		Console.WriteLine(gerente.Nome);
		Console.WriteLine(gerente.CalcularSalario());
		Console.WriteLine(programador.Nome);
		Console.WriteLine(programador.CalcularSalario());
	}
}
