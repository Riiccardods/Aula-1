
Random random = new Random();
int numero = random.Next(0, 11);

int usuario = 0;

Console.WriteLine($"Ola digite um numero de 0 a 100");
usuario = int.Parse(Console.ReadLine());

if (usuario == numero)
{
    Console.WriteLine("acertou");
}
else
{
    Console.WriteLine($"Errou  tente novamente, o numero era {numero}");

}

Console.ReadLine();












    }
}
