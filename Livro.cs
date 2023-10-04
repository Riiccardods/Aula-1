using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool EstaEmprestado { get; set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            EstaEmprestado = false;
        }

        public void EmprestarLivro()
        {
            if (!EstaEmprestado)
            {
                EstaEmprestado = true;
                Console.WriteLine($"Livro \"{Titulo}\" emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Desculpe, o livro \"{Titulo}\" já está emprestado.");
            }
        }

        public void DevolverLivro()
        {
            if (EstaEmprestado)
            {
                EstaEmprestado = false;
                Console.WriteLine($"O livro \"{Titulo}\" foi devolvido. Obrigado!");
            }
            else
            {
                Console.WriteLine($"Este livro \"{Titulo}\" não está emprestado no momento.");
            }
        }
    }
}
