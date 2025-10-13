using System;

class program
{
	static void Main()
	{
		while (true)
		{
			
			try
			{
				Console.WriteLine("Informe a temperatura: ");
				string tempString = Console.ReadLine();

				double temp = double.Parse(tempString);

				Console.WriteLine("Temperatura lida com sucesso: " + temp);

				break;
			}
			catch (FormatException) {

				Console.WriteLine("FORMATO INVALIDO");
			}

		}
	}
}