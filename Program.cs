using System;
using System.Collections.Generic;
using aula1;

class Program
{
    static void Main()
    {
        // Criar alguns livros.
        Livro livro1 = new Livro("Aprendend C# OOP", "Autor 1");
        Livro livro2 = new Livro("POO em Prátic", "Autor 2");

        // Criar alguns usuários.
        Usuario usuario1 = new Usuario("João");
        Usuario usuario2 = new Usuario("Maria");

        // Exemplo de Uso
        usuario1.EmprestarLivro(livro1);
        usuario2.EmprestarLivro(livro1);  // Tentando emprestar o mesmo livro.

        usuario2.EmprestarLivro(livro2);
        usuario1.DevolverLivro(livro1);

        // Mostrar status dos livros
        Console.WriteLine($"Status do Livro 1: Emprestado - {livro1.EstaEmprestado}");
        Console.WriteLine($"Status do Livro 2: Emprestado - {livro2.EstaEmprestado}");
    }
}
