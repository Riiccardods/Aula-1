using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listaDeCompras = new List<string>();

        while (true)
        {
            Console.WriteLine("=== Lista de Compras ===");
            ExibirListaDeCompras(listaDeCompras);

            Console.WriteLine("\nOpções:");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Limpar lista");
            Console.WriteLine("4. Sair");

            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite o item a ser adicionado: ");
                    string item = Console.ReadLine();
                    AdicionarItem(listaDeCompras, item);
                    break;

                case "2":
                    Console.Write("Digite o item a ser removido: ");
                    string itemRemover = Console.ReadLine();
                    RemoverItem(listaDeCompras, itemRemover);
                    break;

                case "3":
                    LimparLista(listaDeCompras);
                    break;

                case "4":
                    Console.WriteLine("Saindo do programa. Até mais!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.Clear();
        }
    }

    static void ExibirListaDeCompras(List<string> lista)
    {
        if (lista.Count == 0)
        {
            Console.WriteLine("A lista de compras está vazia.");
        }
        else
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lista[i]}");
            }
        }
    }

    static void AdicionarItem(List<string> lista, string item)
    {
        lista.Add(item);
        Console.WriteLine($"{item} adicionado à lista.");
    }




    static void RemoverItem(List<string> lista, string item)
    {
        if (lista.Contains(item))
        {
            lista.Remove(item);
            Console.WriteLine($"{item} removido da lista.");
        }
        else
        {
            Console.WriteLine($"{item} não encontrado na lista.");
        }
    }



    static void LimparLista(List<string> lista)
    {
        lista.Clear();
        Console.WriteLine("Lista de compras limpa.");
    }
}
