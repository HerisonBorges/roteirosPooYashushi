using System;

class Program
{
	static void Main()
	{
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine("Digite um numero: ");
			double numero = double.Parse(Console.ReadLine());

			Console.WriteLine("Math.Round: " + Math.Round(numero));
			Console.WriteLine("Math.Floor: " + Math.Floor(numero));
			Console.WriteLine("Math.Ceiling: " + Math.Ceiling(numero));
			Console.WriteLine("Math.Truncate: " + Math.Truncate(numero));
		}

	}
}