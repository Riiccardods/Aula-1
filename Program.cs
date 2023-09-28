using System;

class Program
{
    static int GerarNumeroAleatorio()
    {
        Random random = new Random();
        return random.Next(1, 101); // Gere um número aleatório entre 1 e 100
    }

    static bool VerificarPalpite(int palpite, int numeroAleatorio)
    {
        if (palpite < numeroAleatorio)
        {
            Console.WriteLine("Tente um número maior.");
            return false;
        }
        else if (palpite > numeroAleatorio)
        {
            Console.WriteLine("Tente um número menor.");
            return false;
        }
        else
        {
            Console.WriteLine($"Parabéns! Você adivinhou o número {numeroAleatorio}.");
            return true;
        }
    }

    static void Main()
    {
        int[] tentativas = new int[10]; // Vamos limitar o jogo a 10 tentativas
        int numeroAleatorio = GerarNumeroAleatorio();
        int tentativasFeitas = 0;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        while (tentativasFeitas < tentativas.Length)
        {
            Console.Write("Digite sua suposição: ");
            if (int.TryParse(Console.ReadLine(), out int palpite))
            {
                tentativas[tentativasFeitas] = palpite;
                tentativasFeitas++;

                if (VerificarPalpite(palpite, numeroAleatorio))
                {
                    break; // O jogo termina se o usuário acertar
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }
        }

        if (tentativasFeitas == tentativas.Length)
        {
            Console.WriteLine($"Você excedeu o número máximo de tentativas. O número era {numeroAleatorio}.");
        }

        Console.WriteLine("O jogo acabou. Obrigado por jogar!");
    }
}
