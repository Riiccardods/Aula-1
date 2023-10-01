using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma lista de números inteiros.....
        List<int> numeros = new List<int>();

        // Adicionando elementos à lista
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        // Iterando sobre a lista e imprimindo os elementos..
        Console.WriteLine("Elementos na Lista:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        // Removendo um elemento da lista..
        numeros.Remove(20);

        // Imprimindo a lista após a remoção
        Console.WriteLine("\nElementos na Lista após Remoção:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
