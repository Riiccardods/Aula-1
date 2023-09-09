using System;

namespace aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool continuar = true;

            while (continuar)
            {


                Console.WriteLine("Pressione Enter para gerar um número Aleatório");
                Console.ReadLine();

                Random random = new Random();
                int numeroAlea = random.Next(1, 101);


                Console.WriteLine($"O numero Aleatório é: {numeroAlea}");
                Console.WriteLine();
                Console.WriteLine();




                bool respostaValida = false;           // Flag para controlar a validação da resposta

                while (!respostaValida)             // Enquanto a resposta não for válida
                {
                    Console.WriteLine("Deseja gerar outro numero? s/n");
                    Console.WriteLine();
                    char resposta = Console.ReadKey().KeyChar;

                    if (resposta == 's' || resposta == 'S')
                    {
                        respostaValida = true;            // Marca a resposta como válida e sai do loop de validação
                        Console.Clear();
                    }
                    else if (resposta == 'n' || resposta == 'N')
                    {
                        continuar = false;
                        respostaValida = true;          // Marca a resposta como válida e sai do loop de validação
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Digite somente: s/n - S/N");
                        // Não marca como válida, então o loop de validação vai continuar
                    }
                }







            }






            Console.Clear();
            Console.WriteLine("Volte Sempre!!");
            Console.ReadLine();
        }














    }
}
