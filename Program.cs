using System;

class Program
{
    static void Main()
    {
        // Array de strings
        string[] palavras = { "Olá", "mundo", "isso", "é", "um", "exemplo" };

        // Usando foreach para percorrer o array
        foreach (string palavra in palavras)
        {
            // Imprimindo cada palavra
            Console.WriteLine(palavra);
        }
    }
}
