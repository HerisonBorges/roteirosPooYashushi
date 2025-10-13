using System;

class Program
{
	static void Main()
	{
		try
		{

			Console.WriteLine("Digite um numero: ");
			string numSting = Console.ReadLine();

			int num = int.Parse(numSting);

			Console.WriteLine("Valor convertido! ");

		}catch (FormatException)
		{
			Console.WriteLine("Formato invalido: ");
		} 

		
	}
}