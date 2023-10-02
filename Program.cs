using System;

class Program
{
    static void Main()
    {
        // Vamos usar um loop for para imprimir um nome 10 vezes.

        // A estrutura básica do for é: for (inicialização; condição; expressão de iteração)
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("SeuNomeAqui");
        }

        // Aguardar o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();
    }
}
