using System;

public class Animal
{
	public string Nome;
	public string som;

	public void emitirSom(string som)
	{
		Console.WriteLine("Au au");
	}
}

public class Cachorro : Animal
{

}

class Program
{
	static void Main()
	{
		Cachorro cachorro = new Cachorro();
		cachorro.Nome = "REX";
		cachorro.emitirSom("Qualquer som");
	}
}