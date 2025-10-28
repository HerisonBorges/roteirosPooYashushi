class Program
{
	static void Main()
	{
		Queue<string> fila = new Queue<string>();
		int opcao = 0;

		Console.Clear();
		Console.WriteLine("=== Fila de Atendimento ===");

		while (opcao != 4)
		{
			Console.WriteLine("\n1 - Adicionar cliente à fila");
			Console.WriteLine("2 - Atender próximo cliente");
			Console.WriteLine("3 - Ver quantos clientes estão na fila");
			Console.WriteLine("4 - Sair");
			Console.Write("\nEscolha uma opção: ");

			try
			{
				opcao = int.Parse(Console.ReadLine());

				if (opcao == 1)
				{
					Console.Write("\nDigite o nome do cliente: ");
					string nome = Console.ReadLine();

					if (!string.IsNullOrWhiteSpace(nome))
					{
						fila.Enqueue(nome);
						Console.WriteLine($"\nCliente '{nome}' adicionado à fila!");
					}
					else
					{
						Console.WriteLine("\nNome inválido!");
					}


				} else if (opcao == 2)
				{
					if (fila.Count > 0)
					{
						string clienteAtendido = fila.Dequeue();
						Console.WriteLine($"\n O clinte: {clienteAtendido}");
					}
					else
					{
						Console.WriteLine("\nNão ha clientes");

					}
				}else if (opcao == 3)
				{
					Console.WriteLine($"\nhá {fila.Count} clientes na fila");
					if(fila.Count > 0)
					{
						Console.WriteLine("Fila atual: " + string.Join(", ", fila));

					}
				}else if (opcao == 4)
				{
					Console.WriteLine("\nOperação encerrada");

				}
				else
				{
					Console.WriteLine("Opção invalida");

				}
			}
			catch
			{
				Console.WriteLine("Digite apenas numeros");
			}


		}

			
		

	}
}