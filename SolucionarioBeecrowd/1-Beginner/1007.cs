using System;
using System.Globalization;

class Difference
{
    static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        //Lemos os valores de entrada utilizando o Console.ReadLine e convertemos para inteiro
        int N1 = int.Parse(Console.ReadLine());

        int N2 = int.Parse(Console.ReadLine());

        int N3 = int.Parse(Console.ReadLine());

        int N4 = int.Parse(Console.ReadLine());

        //Calculamos a diferença conforme a fórmula fornecida
        int Difference = (N1 * N2) - (N3 * N4);

        //Imprimimos o resultado no formato solicitado
        Console.WriteLine($"DIFERENCA = {Difference}");

    }
}