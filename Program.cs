using System;

class Carro
{
    // Atributos (propriedades)
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    // Método construtor
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    // Método para exibir informações do carro
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
    }
}

class Program
{
    static void Main()
    {
        // Criando uma instância da classe Carro
        Carro meuCarro = new Carro("Toyota", "Corolla", 2020);

        // Chamando o método para exibir informações do carro
        meuCarro.ExibirInformacoes();

        // Aguardando o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();
    }
}
