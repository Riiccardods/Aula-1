using System;

class JogoAdivinhacao
{
    private int numeroAleatorio;
    private int[] palpites;
    private int tentativas;
    private bool acertou;

    public JogoAdivinhacao()
    {
        palpites = new int[100];
        acertou = false;
    }

    public void IniciarJogo()
    {
        Console.Clear();
        Console.WriteLine("Vou gerar um número aleatório entre 1 e 100. Tente adivinhar!");

        Random random = new Random();
        numeroAleatorio = random.Next(1, 101);

        do
        {
            ObterPalpite();

            if (palpites[tentativas] == numeroAleatorio)
            {
                acertou = true;
                Console.WriteLine($"Parabéns! Você acertou em {tentativas + 1} tentativas.");
            }
            else
            {
                Console.WriteLine("Palpite errado. Tente novamente.");

                // Adicione dicas aqui, por exemplo:
                if (palpites[tentativas] < numeroAleatorio)
                    Console.WriteLine("Tente um número maior.");
                else
                    Console.WriteLine("Tente um número menor.");

                tentativas++;
            }

        } while (!acertou);

        MostrarPalpites();
        PerguntarSeQuerJogarNovamente();
    }

    private void ObterPalpite()
    {
        try
        {
            Console.Write("Digite seu palpite: ");
            string palpiteStr = Console.ReadLine();

            int palpite = int.Parse(palpiteStr);
            palpites[tentativas] = palpite; // Armazenar palpite no array
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }

    private void MostrarPalpites()
    {
        Console.WriteLine("Seus palpites:");

        for (int i = 0; i <= tentativas; i++)
        {
            Console.Write($"{palpites[i]} ");
        }
        Console.WriteLine();
    }

    private void PerguntarSeQuerJogarNovamente()
    {
        Console.Write("Deseja jogar novamente? (S/N): ");
        string jogarNovamenteStr = Console.ReadLine();

        if (jogarNovamenteStr.ToUpper() == "N")
        {
            Console.WriteLine("Obrigado por jogar!");
            Environment.Exit(0);
        }
    }
}

class Menu
{
    public static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao Jogo Adivinhação!");
        Console.WriteLine("1. Jogar");
        Console.WriteLine("2. Sair");
        Console.Write("Escolha uma opção: ");
    }
}

class Program
{
    static void Main()
    {
        bool jogarNovamente = true;

        while (jogarNovamente)
        {
            Menu.MostrarMenu();

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    JogoAdivinhacao jogo = new JogoAdivinhacao();
                    jogo.IniciarJogo();
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
}
