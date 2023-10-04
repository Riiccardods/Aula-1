using System;

class Bicicleta
{
    public string Modelo { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public double PrecoUnitario { get; set; }

    public Bicicleta(string modelo, int quantidade, double preco)
    {
        Modelo = modelo;
        QuantidadeEmEstoque = quantidade;
        PrecoUnitario = preco;
    }

    public override string ToString()
    {
        return $"{Modelo} - Estoque: {QuantidadeEmEstoque} - Preço: {PrecoUnitario:C}";
    }
}

class EstoqueBicicletaria
{
    private Bicicleta[] inventario;

    public EstoqueBicicletaria(int capacidade)
    {
        inventario = new Bicicleta[capacidade];
    }

    public void AdicionarBicicleta(Bicicleta bicicleta, int quantidade)
    {
        int indice = EncontrarIndiceBicicleta(bicicleta);

        if (indice == -1)
        {
            Console.WriteLine("Bicicleta não encontrada no estoque.");
            return;
        }

        inventario[indice].QuantidadeEmEstoque += quantidade;
        Console.WriteLine($"{quantidade} unidades de {bicicleta.Modelo} adicionadas ao estoque.");
    }

    public void MostrarInventario()
    {
        Console.WriteLine("Inventário da Bicicletaria:");
        foreach (var bicicleta in inventario)
        {
            if (bicicleta != null)
                Console.WriteLine(bicicleta);
        }
    }

    private int EncontrarIndiceBicicleta(Bicicleta bicicleta)
    {
        for (int i = 0; i < inventario.Length; i++)
        {
            if (inventario[i] != null && inventario[i].Modelo == bicicleta.Modelo)
            {
                return i;
            }
        }
        return -1;
    }
}

class Program
{
    static void Main()
    {
   

        Bicicleta bike1 = new Bicicleta("Mountain Bike", 10, 799.99);
        Bicicleta bike2 = new Bicicleta("Cidade", 15, 499.99);

 
        EstoqueBicicletaria estoque = new EstoqueBicicletaria(10);

        estoque.AdicionarBicicleta(bike1, 5);
        estoque.AdicionarBicicleta(bike2, 10);

      
        estoque.MostrarInventario();
    }
}
