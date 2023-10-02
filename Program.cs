using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira o nome
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        // Solicitar ao usuário que insira a idade
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Exibir as informações inseridas pelo usuário
        Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos.");

        // Aguardar o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();
    }
}
