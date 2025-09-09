using System;

class Pagamento
{
	public virtual void ProcessarPagamento()
	{
		Console.WriteLine("Processando pagamento");
	}
}

class CartaoDeCredito : Pagamento
{
	public override void ProcessarPagamento()
	{
		Console.WriteLine("Pagamento credito processado");
	}
}

class boletoBancario : Pagamento
{
	public override void ProcessarPagamento()
	{
		Console.WriteLine("Pagamento boleto processado");
	}
}
class pix : Pagamento
{
	public override void ProcessarPagamento()
	{
		Console.WriteLine("Pagamento pix processado");
	}
}

class Program
{
	static void Main()
	{
		Pagamento pagamento = new CartaoDeCredito();
		pagamento.ProcessarPagamento();
		Pagamento pagamento2 = new boletoBancario();
		pagamento2.ProcessarPagamento();
		Pagamento pagamento3 = new pix();
		pagamento3.ProcessarPagamento();

	}
}

