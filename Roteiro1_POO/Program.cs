using System;

public class Jogo
{

	public string habilidade;
	public string nick;
	public string cor;


	public void GerarFantasma()
	{
		Console.WriteLine($"Habilidade: {habilidade}, nick: {nick}, cor: {cor}: ");
	}

	public void Mover(string direcao)
	{

		Console.WriteLine(nick + " moveu para " + direcao);
	}

}

public class Program
{

	public static void Main()
	{

		Jogo j1 = new Jogo();
		j1.nick = "choraagoraridepois";
		j1.habilidade = "Porrada";
		j1.cor = "Azul";
		j1.GerarFantasma();
		j1.Mover("esquerda");
	}

}