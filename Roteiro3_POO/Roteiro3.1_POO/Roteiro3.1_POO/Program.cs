using System;

public class Pedido
{
	public string Lanche { get; set; }

	public static void NumeroPedido()
	{
		Console.WriteLine("12345");
	}
}

public class Cliente
{
	private Pedido pedido;

	public Cliente()
	{
		pedido = new Pedido();
	}

	public void FazerPedido()
	{
		Console.WriteLine("Pedido feito!");
		Pedido.NumeroPedido();


	}

	class Program
	{
		public static void Main()
		{
			Cliente cliente = new Cliente();
			cliente.FazerPedido();
		}
	}
}