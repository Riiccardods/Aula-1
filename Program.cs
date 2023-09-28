
Random random = new Random();
int numero = random.Next(0, 11);

int usuario;
Console.WriteLine("digite um numero");
if (int.TryParse(Console.ReadLine(), out usuario))
{



    if (numero == usuario)
    {
        Console.WriteLine("Acertou");
    }
    else if (numero > usuario)
    {
        Console.WriteLine($"O número é maior. {numero}");
    }
    else
    {
        Console.WriteLine($"O número é menor {numero}");
    }
}



else
{

    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
}
Console.ReadLine();



