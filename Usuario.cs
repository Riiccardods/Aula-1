using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1
{
    class Usuario
    {
        public string Nome { get; set; }

        public Usuario(string nome)
        {
            Nome = nome;
        }

        public void EmprestarLivro(Livro livro)


        {

            livro.EmprestarLivro();



        }

        public void DevolverLivro(Livro livro)
        {
            livro.DevolverLivro();
        }
    }
}
