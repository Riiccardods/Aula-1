using System;

namespace aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool continuar = true;
            int contador = 0;

            if (continuar == true) 
            {
                Console.WriteLine("o valor e Verdadeiro");
                contador =+2;
                Console.WriteLine(contador);
            }

            else 
            {
                Console.WriteLine("Falso");
                continuar = true;
            
            }

            Console.WriteLine($"agora mudou é: {continuar} ");





        }














    }
}
