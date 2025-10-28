using System;
using System.Collections.Generic;

class listaDeCompras
{
    static void Main()
    {
        List<string> listaDeCompras = new List<string>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nLista de Compras");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Listar itens");
            Console.WriteLine("4. Mostrar total de itens");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Digite o nome do item para adicionar: ");
                string itemAdicionar = Console.ReadLine();
                listaDeCompras.Add(itemAdicionar);
                Console.WriteLine($"'{itemAdicionar}' adicionado à lista!");
            }
            else if (opcao == "2")
            {
                Console.Write("Digite o nome do item para remover: ");
                string itemRemover = Console.ReadLine();
                bool remove = listaDeCompras.Remove(itemRemover);
                if (remove)
                {
                    Console.WriteLine($"'{itemRemover}' removido da lista!");
                }
                else
                {
                    Console.WriteLine($" Item '{itemRemover}' não encontrado na lista.");
                }
            }
            else if (opcao == "3")
            {
                Console.WriteLine("\n Itens na sua lista de compras:");
                if (listaDeCompras.Count == 0)
                {
                    Console.WriteLine("(Lista vazia)");
                }
                else
                {
                    foreach (string item in listaDeCompras)
                    {
                        Console.WriteLine($"- {item}");
                    }
                }
            }
            else if (opcao == "4")
            {
                Console.WriteLine($" Total de itens na lista: {listaDeCompras.Count}");
            }
            else if (opcao == "5")
            {
                continuar = false;
                Console.WriteLine(" Saindo do programa...");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}

