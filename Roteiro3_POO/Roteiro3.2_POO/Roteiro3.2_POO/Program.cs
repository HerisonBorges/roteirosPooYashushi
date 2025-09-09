using System;

public interface IVeiculo
{
	void Mover();

}

public class Carro : IVeiculo
{
	public void Mover()
	{
		Console.WriteLine("O carro esta se movendo:");
	}
}

public class Bicicleta : IVeiculo
{
	public void Mover()
	{
		Console.WriteLine("A bicicleta esta se movendo:");
	}
}

class Program
{
	public static void Main()
	{
		IVeiculo veiculo = new Carro();
		IVeiculo veiculo1 = new Bicicleta();
		veiculo.Mover();
		veiculo1.Mover();

	}
}

