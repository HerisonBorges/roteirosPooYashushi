using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Dictionary<int, string> produtos = new Dictionary<int, string>();

        int opcao = -1;

        Console.WriteLine("==Catalogo de Produtos==");
        
        while(opcao != 0)
        {
            Console.WriteLine("\n1. Adicionar Produto");
            Console.WriteLine("2. Buscar produto por código");
            Console.WriteLine("3. Listar todos os produtos");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                Console.WriteLine("Digite o codigo do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                if (produtos.ContainsKey(codigo))
                {
                    Console.WriteLine("Já existe um produto com esse código!");
                }
                else
                {
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    produtos.Add(codigo, nome);
                    Console.WriteLine("Produto adicionado com sucesso!");
                }

            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite o codigo do produto: ");
                int codigoBusca = int.Parse(Console.ReadLine());

                if (produtos.ContainsKey(codigoBusca))
                {
                    Console.WriteLine($"Produto encontrado! {produtos[codigoBusca]}");
                }
                else
                {
                    Console.WriteLine("Produto encontrado!");
                }


            }else if (opcao == 3) {

                Console.WriteLine("==Lista de Produtos==");
                if(produtos.Count == 0)
                {
                    Console.WriteLine("Nenhum produto encontrado! ");
                }
                else
                {
                    foreach (var item in produtos)
                    {
                        Console.WriteLine($"Código: {item.Key}  Nome: {item.Value}");
                    }
                }
            }
            else if (opcao == 0)
            {
                Console.WriteLine("Encerrando o programa...");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

        }
    }
}
