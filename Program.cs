using System;

namespace aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero = random.Next(1,3);

            if(numero >= 2) 
            {
                Console.WriteLine($"Seu numero é: {numero}");
            
            }

            else
            {
                Console.WriteLine("O numero nao é nehnum encotrado");
            }

            Console.ReadLine();


        }














    }
}
