using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        soma(80,90);
    }


    static void soma(int n1, int n2) 
    {
        int resultado = n1 + n2;
        Console.WriteLine($"a soma de {n1} + {n2} é: {resultado}");
    }  


}
