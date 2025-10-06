using System;
using System.Globalization;
using System.Diagnostics;

class Program
{
	static void Main()
	{
		Console.WriteLine("Informe seu nome:");
		string nome = Console.ReadLine();

		Console.WriteLine("Informe o horário do compromisso :");
		string dataCompromissoStr = Console.ReadLine();

		DateTime agora = DateTime.Now;
		DateTime dataCompromisso = DateTime.Parse(dataCompromissoStr);

		TimeSpan duracao = dataCompromisso - agora;

		int diasFaltando = (int)Math.Ceiling(duracao.TotalDays);

		
		string diaDaSemana = dataCompromisso.ToString("dddd", new CultureInfo("pt-BR"));


		Console.WriteLine($"Olá, {nome}!");
		Console.WriteLine($"Seu compromisso será em {diasFaltando} dias, na {diaDaSemana}.");
		Console.WriteLine($"Data marcada: {dataCompromisso.ToString("dd/MM/yyyy")} às {dataCompromisso.ToString("HH:mm")}");
	}
}