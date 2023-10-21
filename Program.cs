using System;

class Program
{
    static void Main()
    {
        bool jogarNovamente = true;

        while (jogarNovamente)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao Jogo Adivinhação!");
            Console.WriteLine("1. Jogar");
            Console.WriteLine("2. Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    JogoAdivinhacao();
                    break;
                case "2":
                    jogarNovamente = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        Console.WriteLine("Obrigado por jogar!");
    }

    static void JogoAdivinhacao()
    {
        Console.Clear();
        Console.WriteLine("Vou gerar um número aleatório entre 1 e 100. Tente adivinhar!");

        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int tentativas = 0;
        bool acertou = false;
        int[] palpites = new int[100]; // Array para armazenar palpites

        do
        {
            try
            {
                Console.Write("Digite seu palpite: ");
                string palpiteStr = Console.ReadLine();

                int palpite = int.Parse(palpiteStr);
                palpites[tentativas] = palpite; // Armazenar palpite no array

                tentativas++;

                if (palpite == numeroAleatorio)
                {
                    acertou = true;
                    Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
                }
                else
                {
                    Console.WriteLine("Palpite errado. Tente novamente.");

                    // Adicione dicas aqui, por exemplo:
                    if (palpite < numeroAleatorio)
                        Console.WriteLine("Tente um número maior.");
                    else
                        Console.WriteLine("Tente um número menor.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
            }

        } while (!acertou);

        Console.WriteLine("Seus palpites:");

        for (int i = 0; i < tentativas; i++)
        {
            Console.Write($"{palpites[i]} ");
        }

        Console.Write("\nDeseja jogar novamente? (S/N): ");
        string jogarNovamenteStr = Console.ReadLine();

        if (jogarNovamenteStr.ToUpper() == "N")
        {
            Console.WriteLine("Obrigado por jogar!");
            Environment.Exit(0);
        }
    }
}
